using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace Motor_GUI
{
    public partial class Form1 : Form
    {
        //===================================================>
        //		VARIABLES DEFINATIONS
        //===================================================<
        //------------------------------------------>
        //  
        //------------------------------------------<
        bool ConnectFlag = false;
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        //*--- Communication Data ---//
        public string ReadBufferString = "";
        //CMD ID
        public const byte CMD_MOTOR_A_FW = 0x01;
        public const byte CMD_MOTOR_A_BW = 0x02;
        public const byte CMD_MOTOR_A_STOP = 0x03;
        public const byte CMD_MOTOR_B_FW = 0x04;
        public const byte CMD_MOTOR_B_BW = 0x05;
        public const byte CMD_MOTOR_B_STOP = 0x06;
        public const byte CMD_MOTOR_READ = 0x07;
        public const byte CMD_MOTOR_A_MOVE_TO = 0x08;
        public const byte CMD_MOTOR_B_MOVE_TO = 0x09;
        public const byte CMD_PID_OUTPUT_LIMIT = 0x0A;
        public const byte CMD_MOTOR_RESET_PIC = 0x1F;
        //CRC
        public const UInt16 CRC_POLYNOMIAL=0x1021; // CRC-CCITT, can change to CRC-16
        public const UInt16 CRC_INITIALE_VALUE = 0x0000;

        //===================================================>
        //		FUNCTIONS : Initialize and End
        //===================================================<
        //------------------------------------------>
        //  Fucntion: Form Start
        //------------------------------------------<
        public Form1()
        {
            InitializeComponent();
            FindPorts();
        }
        //------------------------------------------>
        //  Fucntion: Form Load
        //------------------------------------------<
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize when Form is Loaded.
            textBox_target.Text = "FF";
            textBox_command_id.Text = "01";
            textBox_cmd_data1.Text = "B4";
            textBox_cmd_data2.Text = "00";
            textBox_A_FW.Text = "180";
            textBox_A_BW.Text = "180";
            textBox_B_FW.Text = "180";
            textBox_B_BW.Text = "180";
            textBox_A_MoveTo.Text = "30000";
            textBox_B_MoveTo.Text = "30000";
            textBox_pid_output_limix.Text = "80";
        }
        //------------------------------------------>
        //  Fucntion: Form Closed
        //------------------------------------------<
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerialPort.Close();
        }

        //------------------------------------------>
        //  Fucntion: Find Avaliable Ports
        //------------------------------------------<
        private void FindPorts()
        {
            Ports_comboBox.Items.Clear();
            System.Object[] ComPorts = SerialPort.GetPortNames();
            Ports_comboBox.Items.AddRange(ComPorts);
        }

        //===================================================>
        //		EVENT FUNCTIONS : Specilized Interrupts
        //===================================================<
        //------------------------------------------>
        //  Event Function : Data From SerialPort Received
        //------------------------------------------<
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //*--- NOTE: Interrupts may happen during the communication between ---//
            //---- PC and MCU, therefore the data stream may be choped into     ---//
            //---  mutiple segements. Wait a period for the whole stream to be  ---//
            //---  passed into the PC buffer before reading.                    ---//
            Thread.Sleep(25);
            //*--- Read the data stream from MCU ---//
            SerialPort sp = (SerialPort)sender;
            int BytesNo = sp.BytesToRead;
            byte[] indata = new byte[BytesNo];
            sp.Read(indata, 0, BytesNo);

            //Show Hex
            message_richTextBox.Invoke(this.myDelegate, new Object[] { BitConverter.ToString(indata).Replace("-", " ") + "\n" });

            //Show ASCII
            //ReadBufferString = System.Text.Encoding.Default.GetString(indata);
            //message_richTextBox.Invoke(this.myDelegate, ReadBufferString);
        }

        //------------------------------------------>
        //  Event Function : Send out command data through SerialPort
        //------------------------------------------<
        public void Send_Command(byte target, byte cmd_id, byte cmd_data1, byte cmd_data2)
        {
            UInt16 crc = 0;
            byte[] cmd_data = new byte[7];

            cmd_data[0] = 0x55;
            cmd_data[1] = target;
            cmd_data[2] = cmd_id;
            cmd_data[3] = cmd_data1;
            cmd_data[4] = cmd_data2;
            cmd_data[5] = 0;
            cmd_data[6] = 0;
            crc = GenerateCRC(cmd_data,7);
            byte[] b = BitConverter.GetBytes(crc);
            cmd_data[5] = b[1];//Higher Byte
            cmd_data[6] = b[0];//Lower Byte

            //*--- Start Serial Port COM ---//
            if (SerialPort.IsOpen == true)
            {
                string str = "Tx: ";
                message_richTextBox.Invoke(this.myDelegate, str);

                SerialPort.Write(cmd_data, 0, 7);
                //also log the send out string
                //Show Hex
                message_richTextBox.Invoke(this.myDelegate, new Object[] { BitConverter.ToString(cmd_data).Replace("-", " ") + "\n" });
                //Show ASCII
                //string send_str = System.Text.Encoding.Default.GetString(cmd_data);
                //message_richTextBox.Invoke(this.myDelegate, send_str);
            }
            else
            {
                PortStatus_TextBox.Text = "Invalid Port!";
            }
        }

        //------------------------------------------>
        //  Event Function : Auto Scroll Down For RichTextBox
        //------------------------------------------<
        private void message_richTextBox_TextChanged(object sender, EventArgs e)
        {
            message_richTextBox.SelectionStart = message_richTextBox.Text.Length;
            message_richTextBox.ScrollToCaret();
        }

        //------------------------------------------>
        //  Event Function : Display string into richTextBox1
        //------------------------------------------<
        public void AddDataMethod(String myString)
        {
            message_richTextBox.AppendText(myString);
            //BufferString.Equals(myString);
        }

        //===================================================>
        //		FUNCTIONS
        //===================================================<
        public UInt16 GenerateCRC(byte[] inputData, byte inputDataLength)
        {
            UInt16 remainder, msBit;
            byte i, j, mask;

            remainder = CRC_INITIALE_VALUE;
            for (i=0;i<inputDataLength;i++)
            {
                mask = 0x80;
                // Do for all bits in each byte
                for (j=0;j<8;j++)
                {
                    msBit = (UInt16)(remainder & 0x8000);
                    remainder = (UInt16)(remainder << 1);
                    if ((inputData[i] & mask) != 0)
                        remainder = (UInt16)(remainder | 0x0001);
                    mask = (byte)(mask >> 1);
                    if (msBit != 0)
                        remainder = (UInt16)(remainder ^ CRC_POLYNOMIAL);
                }
            }
            return(remainder);
        }

        //===================================================>
        //		EVENTS FUNCTIONS : Button Events
        //===================================================<
        //------------------------------------------>
        //  Function: Clear RichTextBox
        //------------------------------------------<
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            message_richTextBox.Text = string.Empty;
        }

        //------------------------------------------>
        //  Function: Refresh Ports
        //------------------------------------------<
        private void PortRefresh_Button_Click(object sender, EventArgs e)
        {
            FindPorts();
            message_richTextBox.Text = "";
            PortStatus_TextBox.Text = "";
            PortConnect_Button.Text = "Connect";
            ProgressBar.Value = 0;
            SerialPort.Close();
            ConnectFlag = false;
        }

        //------------------------------------------>
        //  Function: Connect to Port
        //------------------------------------------<
        private void PortConnect_Button_Click(object sender, EventArgs e)
        {
            if (ConnectFlag == true)    // If the port is aready connected and the button test is "Disconnect", pressing it will disconnect the Port;
            {
                message_richTextBox.Text = "";
                PortStatus_TextBox.Text = "";
                PortConnect_Button.Text = "Connect";
                ProgressBar.Value = 0;
                SerialPort.Close();
                ConnectFlag = false;
            }
            else    // Only if the Port is not connected, it will try to connect to a port;
            {
                if (Ports_comboBox.Text == "")
                {
                    PortStatus_TextBox.Text = "        Invalid Port!";
                }
                else
                {
                    try
                    {
                        if (!SerialPort.IsOpen)
                        {
                            SerialPort = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One);
                            SerialPort.PortName = Ports_comboBox.Text;
                            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                            SerialPort.Open();
                            for (int i = 0; i < 100; i++)
                            {
                                ProgressBar.Value = i;
                                Thread.Sleep(2);
                            }
                            ProgressBar.Value = 100;
                            PortStatus_TextBox.Text = "       Port Connected";
                            PortConnect_Button.Text = "Disconnect";
                            ConnectFlag = true;
                            //SerialPort.ReadTimeout = 500;
                            //SerialPort.WriteTimeout = 500;
                            ////SerialPort.RtsEnable = false;
                            SerialPort.DtrEnable = true;
                            SerialPort.RtsEnable = true;
                            SerialPort.Handshake = System.IO.Ports.Handshake.None;
                            this.myDelegate = new AddDataDelegate(AddDataMethod);
                        }
                        else
                            PortStatus_TextBox.Text = "        Port busy!";
                    }
                    catch (UnauthorizedAccessException)
                    {
                        PortStatus_TextBox.Text = "UnauthorizedAccessException";
                    }
                }
            }

        }

        //------------------------------------------>
        //  Function: Target board id text change
        //------------------------------------------<
        private void textBox_target_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_target.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9') || ('A' <= ch && ch <= 'F') || ('a' <= ch && ch <= 'f'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_target.Text = sb.ToString();
                this.textBox_target.SelectionStart = this.textBox_target.Text.Length;
            }
        }

        //------------------------------------------>
        //  Function: Command id text change
        //------------------------------------------<
        private void command_id_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_command_id.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9') || ('A' <= ch && ch <= 'F') || ('a' <= ch && ch <= 'f'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_command_id.Text = sb.ToString();
                this.textBox_command_id.SelectionStart = this.textBox_command_id.Text.Length;
            }
        }

        private void textBox_cmd_data1_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_cmd_data1.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9') || ('A' <= ch && ch <= 'F') || ('a' <= ch && ch <= 'f'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_cmd_data1.Text = sb.ToString();
                this.textBox_cmd_data1.SelectionStart = this.textBox_cmd_data1.Text.Length;
            }
        }

        private void textBox_cmd_data2_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_cmd_data2.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9') || ('A' <= ch && ch <= 'F') || ('a' <= ch && ch <= 'f'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_cmd_data2.Text = sb.ToString();
                this.textBox_cmd_data2.SelectionStart = this.textBox_cmd_data2.Text.Length;
            }
        }

        //------------------------------------------>
        //  Function: Send command button clicked
        //------------------------------------------<
        private void command_send_button_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = Convert.ToByte(textBox_command_id.Text, 16);
            byte cmd_data_1 = Convert.ToByte(textBox_cmd_data1.Text, 16);
            byte cmd_data_2 = Convert.ToByte(textBox_cmd_data2.Text, 16);
            Send_Command(target_board, cmd_id, cmd_data_1, cmd_data_2);
        }

        private void textBox_A_FW_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_A_FW.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_A_FW.Text = sb.ToString();
                this.textBox_A_FW.SelectionStart = this.textBox_A_FW.Text.Length;
            }
        }

        private void button_A_FW_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_A_FW;
            UInt16 count = Convert.ToUInt16(textBox_A_FW.Text, 10);
            byte[] b = BitConverter.GetBytes(count);
            byte cmd_data_1 = b[0];//Lower Byte
            byte cmd_data_2 = b[1];//Higher Byte
            Send_Command(target_board, cmd_id, cmd_data_1, cmd_data_2);
        }

        private void textBox_A_BW_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_A_BW.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_A_BW.Text = sb.ToString();
                this.textBox_A_BW.SelectionStart = this.textBox_A_BW.Text.Length;
            }
        }

        private void button_A_BW_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_A_BW;
            UInt16 count = Convert.ToUInt16(textBox_A_BW.Text, 10);
            byte[] b = BitConverter.GetBytes(count);
            byte cmd_data_1 = b[0];//Lower Byte
            byte cmd_data_2 = b[1];//Higher Byte
            Send_Command(target_board, cmd_id, cmd_data_1, cmd_data_2);
        }

        private void button_A_STOP_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_A_STOP;
            Send_Command(target_board, cmd_id, 0, 0);
        }

        private void textBox_B_FW_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_B_FW.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_B_FW.Text = sb.ToString();
                this.textBox_B_FW.SelectionStart = this.textBox_B_FW.Text.Length;
            }
        }

        private void button_B_FW_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_B_FW;
            UInt16 count = Convert.ToUInt16(textBox_B_FW.Text, 10);
            byte[] b = BitConverter.GetBytes(count);
            byte cmd_data_1 = b[0];//Lower Byte
            byte cmd_data_2 = b[1];//Higher Byte
            Send_Command(target_board, cmd_id, cmd_data_1, cmd_data_2);
        }

        private void textBox_B_BW_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_B_BW.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_B_BW.Text = sb.ToString();
                this.textBox_B_BW.SelectionStart = this.textBox_B_BW.Text.Length;
            }
        }

        private void button_B_BW_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_B_BW;
            UInt16 count = Convert.ToUInt16(textBox_B_BW.Text, 10);
            byte[] b = BitConverter.GetBytes(count);
            byte cmd_data_1 = b[0];//Lower Byte
            byte cmd_data_2 = b[1];//Higher Byte
            Send_Command(target_board, cmd_id, cmd_data_1, cmd_data_2);
        }

        private void button_B_STOP_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_B_STOP;
            Send_Command(target_board, cmd_id, 0, 0);
        }

        Regex reg = new Regex(@"^-?\d*$");
        bool textChangedByKeyA, textChangedByKeyB;
        string lastTextA, lastTextB;

        private void textBox_A_MoveTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch(textBox_A_MoveTo.Text.Insert(textBox_A_MoveTo.SelectionStart, e.KeyChar.ToString()) + "1"))
            {
                e.Handled = true;
                return;
            }
            textChangedByKeyA = true;
        }

        private void textBox_A_MoveTo_TextChanged(object sender, EventArgs e)
        {
            if (!textChangedByKeyA)
            {
                if (!reg.IsMatch(textBox_A_MoveTo.Text))
                {
                    textBox_A_MoveTo.Text = lastTextA;
                    return;
                }
            }
            else textChangedByKeyA = false;
            lastTextA = textBox_A_MoveTo.Text;
        }

        private void button_A_MoveTo_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_A_MOVE_TO;
            Int16 count = Convert.ToInt16(textBox_A_MoveTo.Text, 10);
            byte[] b = BitConverter.GetBytes(count);
            byte cmd_data_1 = b[0];//Lower Byte
            byte cmd_data_2 = b[1];//Higher Byte
            Send_Command(target_board, cmd_id, cmd_data_1, cmd_data_2);
        }

        private void textBox_B_MoveTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch(textBox_B_MoveTo.Text.Insert(textBox_B_MoveTo.SelectionStart, e.KeyChar.ToString()) + "1"))
            {
                e.Handled = true;
                return;
            }
            textChangedByKeyB = true;
        }

        private void textBox_B_MoveTo_TextChanged(object sender, EventArgs e)
        {
            if (!textChangedByKeyB)
            {
                if (!reg.IsMatch(textBox_B_MoveTo.Text))
                {
                    textBox_B_MoveTo.Text = lastTextB;
                    return;
                }
            }
            else textChangedByKeyB = false;
            lastTextB = textBox_B_MoveTo.Text;
        }

        private void button_B_MoveTo_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_B_MOVE_TO;
            Int16 count = Convert.ToInt16(textBox_B_MoveTo.Text, 10);
            byte[] b = BitConverter.GetBytes(count);
            byte cmd_data_1 = b[0];//Lower Byte
            byte cmd_data_2 = b[1];//Higher Byte
            Send_Command(target_board, cmd_id, cmd_data_1, cmd_data_2);
        }

        private void button_read_count_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_READ;
            Send_Command(target_board, cmd_id, 0, 0);
        }

        private void button_reset_pic_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_MOTOR_RESET_PIC;
            Send_Command(target_board, cmd_id, 0, 0);
        }

        private void textBox_pid_output_limix_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.textBox_pid_output_limix.Text)
            {
                if ((ch == '\b') || ('0' <= ch && ch <= '9'))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.textBox_pid_output_limix.Text = sb.ToString();
                this.textBox_pid_output_limix.SelectionStart = this.textBox_pid_output_limix.Text.Length;
            }
        }

        private void button_pid_limit_Click(object sender, EventArgs e)
        {
            byte target_board = Convert.ToByte(textBox_target.Text, 16);
            byte cmd_id = CMD_PID_OUTPUT_LIMIT;
            byte cmd_data_1 = Convert.ToByte(textBox_pid_output_limix.Text, 10);
            Send_Command(target_board, cmd_id, cmd_data_1, 0);
        }
    }
}
