namespace Motor_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.PortRefresh_Button = new System.Windows.Forms.Button();
            this.Ports_comboBox = new System.Windows.Forms.ComboBox();
            this.PortConnect_Button = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PortStatus_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox_Ports = new System.Windows.Forms.GroupBox();
            this.textBox_command_id = new System.Windows.Forms.TextBox();
            this.command_send_button = new System.Windows.Forms.Button();
            this.groupBox_Message = new System.Windows.Forms.GroupBox();
            this.message_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.groupBox_Commands = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_cmd_data4 = new System.Windows.Forms.Label();
            this.label_cmd_data2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cmd_data3 = new System.Windows.Forms.Label();
            this.label_cmd_data1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_cmd_id = new System.Windows.Forms.Label();
            this.textBox_cmd_data4 = new System.Windows.Forms.TextBox();
            this.textBox_cmd_data2 = new System.Windows.Forms.TextBox();
            this.textBox_cmd_data3 = new System.Windows.Forms.TextBox();
            this.textBox_cmd_data1 = new System.Windows.Forms.TextBox();
            this.groupBox_TargetBoardID = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_target = new System.Windows.Forms.TextBox();
            this.groupBox_controls = new System.Windows.Forms.GroupBox();
            this.textBox_B_BW = new System.Windows.Forms.TextBox();
            this.textBox_B_FW = new System.Windows.Forms.TextBox();
            this.button_B_STOP = new System.Windows.Forms.Button();
            this.button_B_BW = new System.Windows.Forms.Button();
            this.button_B_FW = new System.Windows.Forms.Button();
            this.textBox_A_BW = new System.Windows.Forms.TextBox();
            this.textBox_A_FW = new System.Windows.Forms.TextBox();
            this.button_A_STOP = new System.Windows.Forms.Button();
            this.button_A_BW = new System.Windows.Forms.Button();
            this.button_A_FW = new System.Windows.Forms.Button();
            this.textBox_pid_output_limix = new System.Windows.Forms.TextBox();
            this.button_pid_limit = new System.Windows.Forms.Button();
            this.textBox_B_MoveTo = new System.Windows.Forms.TextBox();
            this.textBox_A_MoveTo = new System.Windows.Forms.TextBox();
            this.button_B_MoveTo = new System.Windows.Forms.Button();
            this.button_A_MoveTo = new System.Windows.Forms.Button();
            this.button_reset_pic = new System.Windows.Forms.Button();
            this.button_read_count = new System.Windows.Forms.Button();
            this.groupBox_moveto = new System.Windows.Forms.GroupBox();
            this.button_AB_MoveTo = new System.Windows.Forms.Button();
            this.groupBox_others = new System.Windows.Forms.GroupBox();
            this.groupBox_Ports.SuspendLayout();
            this.groupBox_Message.SuspendLayout();
            this.groupBox_Commands.SuspendLayout();
            this.groupBox_TargetBoardID.SuspendLayout();
            this.groupBox_controls.SuspendLayout();
            this.groupBox_moveto.SuspendLayout();
            this.groupBox_others.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.BaudRate = 19200;
            // 
            // PortRefresh_Button
            // 
            this.PortRefresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortRefresh_Button.Location = new System.Drawing.Point(7, 60);
            this.PortRefresh_Button.Margin = new System.Windows.Forms.Padding(4);
            this.PortRefresh_Button.Name = "PortRefresh_Button";
            this.PortRefresh_Button.Size = new System.Drawing.Size(116, 28);
            this.PortRefresh_Button.TabIndex = 0;
            this.PortRefresh_Button.Text = "Refresh";
            this.PortRefresh_Button.UseVisualStyleBackColor = true;
            this.PortRefresh_Button.Click += new System.EventHandler(this.PortRefresh_Button_Click);
            // 
            // Ports_comboBox
            // 
            this.Ports_comboBox.FormattingEnabled = true;
            this.Ports_comboBox.Location = new System.Drawing.Point(7, 26);
            this.Ports_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Ports_comboBox.Name = "Ports_comboBox";
            this.Ports_comboBox.Size = new System.Drawing.Size(240, 24);
            this.Ports_comboBox.TabIndex = 1;
            // 
            // PortConnect_Button
            // 
            this.PortConnect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortConnect_Button.Location = new System.Drawing.Point(131, 60);
            this.PortConnect_Button.Margin = new System.Windows.Forms.Padding(4);
            this.PortConnect_Button.Name = "PortConnect_Button";
            this.PortConnect_Button.Size = new System.Drawing.Size(117, 28);
            this.PortConnect_Button.TabIndex = 2;
            this.PortConnect_Button.Text = "Connect";
            this.PortConnect_Button.UseVisualStyleBackColor = true;
            this.PortConnect_Button.Click += new System.EventHandler(this.PortConnect_Button_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(256, 26);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(200, 28);
            this.ProgressBar.TabIndex = 3;
            // 
            // PortStatus_TextBox
            // 
            this.PortStatus_TextBox.Location = new System.Drawing.Point(256, 62);
            this.PortStatus_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortStatus_TextBox.Name = "PortStatus_TextBox";
            this.PortStatus_TextBox.ReadOnly = true;
            this.PortStatus_TextBox.Size = new System.Drawing.Size(199, 22);
            this.PortStatus_TextBox.TabIndex = 4;
            this.PortStatus_TextBox.TabStop = false;
            // 
            // groupBox_Ports
            // 
            this.groupBox_Ports.Controls.Add(this.ProgressBar);
            this.groupBox_Ports.Controls.Add(this.PortStatus_TextBox);
            this.groupBox_Ports.Controls.Add(this.PortRefresh_Button);
            this.groupBox_Ports.Controls.Add(this.PortConnect_Button);
            this.groupBox_Ports.Controls.Add(this.Ports_comboBox);
            this.groupBox_Ports.Location = new System.Drawing.Point(15, 14);
            this.groupBox_Ports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Ports.Name = "groupBox_Ports";
            this.groupBox_Ports.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Ports.Size = new System.Drawing.Size(467, 98);
            this.groupBox_Ports.TabIndex = 5;
            this.groupBox_Ports.TabStop = false;
            this.groupBox_Ports.Text = "Ports";
            // 
            // textBox_command_id
            // 
            this.textBox_command_id.Location = new System.Drawing.Point(103, 38);
            this.textBox_command_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_command_id.MaxLength = 2;
            this.textBox_command_id.Name = "textBox_command_id";
            this.textBox_command_id.Size = new System.Drawing.Size(28, 22);
            this.textBox_command_id.TabIndex = 6;
            this.textBox_command_id.TextChanged += new System.EventHandler(this.command_id_TextChanged);
            // 
            // command_send_button
            // 
            this.command_send_button.Location = new System.Drawing.Point(339, 32);
            this.command_send_button.Margin = new System.Windows.Forms.Padding(4);
            this.command_send_button.Name = "command_send_button";
            this.command_send_button.Size = new System.Drawing.Size(116, 28);
            this.command_send_button.TabIndex = 7;
            this.command_send_button.Text = "Send";
            this.command_send_button.UseVisualStyleBackColor = true;
            this.command_send_button.Click += new System.EventHandler(this.command_send_button_Click);
            // 
            // groupBox_Message
            // 
            this.groupBox_Message.Controls.Add(this.message_richTextBox);
            this.groupBox_Message.Controls.Add(this.Clear_Button);
            this.groupBox_Message.Location = new System.Drawing.Point(488, 118);
            this.groupBox_Message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Message.Name = "groupBox_Message";
            this.groupBox_Message.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Message.Size = new System.Drawing.Size(467, 487);
            this.groupBox_Message.TabIndex = 60;
            this.groupBox_Message.TabStop = false;
            this.groupBox_Message.Text = "Message";
            // 
            // message_richTextBox
            // 
            this.message_richTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_richTextBox.Location = new System.Drawing.Point(7, 21);
            this.message_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.message_richTextBox.Name = "message_richTextBox";
            this.message_richTextBox.ReadOnly = true;
            this.message_richTextBox.Size = new System.Drawing.Size(453, 415);
            this.message_richTextBox.TabIndex = 61;
            this.message_richTextBox.TabStop = false;
            this.message_richTextBox.Text = "";
            this.message_richTextBox.TextChanged += new System.EventHandler(this.message_richTextBox_TextChanged);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.Location = new System.Drawing.Point(7, 445);
            this.Clear_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(100, 28);
            this.Clear_Button.TabIndex = 62;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // groupBox_Commands
            // 
            this.groupBox_Commands.Controls.Add(this.label6);
            this.groupBox_Commands.Controls.Add(this.label4);
            this.groupBox_Commands.Controls.Add(this.label_cmd_data4);
            this.groupBox_Commands.Controls.Add(this.label_cmd_data2);
            this.groupBox_Commands.Controls.Add(this.label5);
            this.groupBox_Commands.Controls.Add(this.label3);
            this.groupBox_Commands.Controls.Add(this.label_cmd_data3);
            this.groupBox_Commands.Controls.Add(this.label_cmd_data1);
            this.groupBox_Commands.Controls.Add(this.label2);
            this.groupBox_Commands.Controls.Add(this.label_cmd_id);
            this.groupBox_Commands.Controls.Add(this.textBox_cmd_data4);
            this.groupBox_Commands.Controls.Add(this.textBox_cmd_data2);
            this.groupBox_Commands.Controls.Add(this.textBox_cmd_data3);
            this.groupBox_Commands.Controls.Add(this.textBox_cmd_data1);
            this.groupBox_Commands.Controls.Add(this.textBox_command_id);
            this.groupBox_Commands.Controls.Add(this.command_send_button);
            this.groupBox_Commands.Location = new System.Drawing.Point(15, 193);
            this.groupBox_Commands.Name = "groupBox_Commands";
            this.groupBox_Commands.Size = new System.Drawing.Size(467, 146);
            this.groupBox_Commands.TabIndex = 61;
            this.groupBox_Commands.TabStop = false;
            this.groupBox_Commands.Text = "Send Commands";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "(HEX)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "(HEX)";
            // 
            // label_cmd_data4
            // 
            this.label_cmd_data4.AutoSize = true;
            this.label_cmd_data4.Location = new System.Drawing.Point(203, 117);
            this.label_cmd_data4.Name = "label_cmd_data4";
            this.label_cmd_data4.Size = new System.Drawing.Size(61, 17);
            this.label_cmd_data4.TabIndex = 8;
            this.label_cmd_data4.Text = "DATA 4:";
            // 
            // label_cmd_data2
            // 
            this.label_cmd_data2.AutoSize = true;
            this.label_cmd_data2.Location = new System.Drawing.Point(4, 117);
            this.label_cmd_data2.Name = "label_cmd_data2";
            this.label_cmd_data2.Size = new System.Drawing.Size(61, 17);
            this.label_cmd_data2.TabIndex = 8;
            this.label_cmd_data2.Text = "DATA 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "(HEX)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "(HEX)";
            // 
            // label_cmd_data3
            // 
            this.label_cmd_data3.AutoSize = true;
            this.label_cmd_data3.Location = new System.Drawing.Point(203, 80);
            this.label_cmd_data3.Name = "label_cmd_data3";
            this.label_cmd_data3.Size = new System.Drawing.Size(61, 17);
            this.label_cmd_data3.TabIndex = 8;
            this.label_cmd_data3.Text = "DATA 3:";
            // 
            // label_cmd_data1
            // 
            this.label_cmd_data1.AutoSize = true;
            this.label_cmd_data1.Location = new System.Drawing.Point(4, 80);
            this.label_cmd_data1.Name = "label_cmd_data1";
            this.label_cmd_data1.Size = new System.Drawing.Size(61, 17);
            this.label_cmd_data1.TabIndex = 8;
            this.label_cmd_data1.Text = "DATA 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "(HEX)";
            // 
            // label_cmd_id
            // 
            this.label_cmd_id.AutoSize = true;
            this.label_cmd_id.Location = new System.Drawing.Point(4, 43);
            this.label_cmd_id.Name = "label_cmd_id";
            this.label_cmd_id.Size = new System.Drawing.Size(92, 17);
            this.label_cmd_id.TabIndex = 8;
            this.label_cmd_id.Text = "Command ID:";
            // 
            // textBox_cmd_data4
            // 
            this.textBox_cmd_data4.Location = new System.Drawing.Point(293, 112);
            this.textBox_cmd_data4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cmd_data4.MaxLength = 2;
            this.textBox_cmd_data4.Name = "textBox_cmd_data4";
            this.textBox_cmd_data4.Size = new System.Drawing.Size(28, 22);
            this.textBox_cmd_data4.TabIndex = 6;
            this.textBox_cmd_data4.TextChanged += new System.EventHandler(this.textBox_cmd_data4_TextChanged);
            // 
            // textBox_cmd_data2
            // 
            this.textBox_cmd_data2.Location = new System.Drawing.Point(103, 112);
            this.textBox_cmd_data2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cmd_data2.MaxLength = 2;
            this.textBox_cmd_data2.Name = "textBox_cmd_data2";
            this.textBox_cmd_data2.Size = new System.Drawing.Size(28, 22);
            this.textBox_cmd_data2.TabIndex = 6;
            this.textBox_cmd_data2.TextChanged += new System.EventHandler(this.textBox_cmd_data2_TextChanged);
            // 
            // textBox_cmd_data3
            // 
            this.textBox_cmd_data3.Location = new System.Drawing.Point(293, 75);
            this.textBox_cmd_data3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cmd_data3.MaxLength = 2;
            this.textBox_cmd_data3.Name = "textBox_cmd_data3";
            this.textBox_cmd_data3.Size = new System.Drawing.Size(28, 22);
            this.textBox_cmd_data3.TabIndex = 6;
            this.textBox_cmd_data3.TextChanged += new System.EventHandler(this.textBox_cmd_data3_TextChanged);
            // 
            // textBox_cmd_data1
            // 
            this.textBox_cmd_data1.Location = new System.Drawing.Point(103, 75);
            this.textBox_cmd_data1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cmd_data1.MaxLength = 2;
            this.textBox_cmd_data1.Name = "textBox_cmd_data1";
            this.textBox_cmd_data1.Size = new System.Drawing.Size(28, 22);
            this.textBox_cmd_data1.TabIndex = 6;
            this.textBox_cmd_data1.TextChanged += new System.EventHandler(this.textBox_cmd_data1_TextChanged);
            // 
            // groupBox_TargetBoardID
            // 
            this.groupBox_TargetBoardID.Controls.Add(this.label1);
            this.groupBox_TargetBoardID.Controls.Add(this.textBox_target);
            this.groupBox_TargetBoardID.Location = new System.Drawing.Point(15, 118);
            this.groupBox_TargetBoardID.Name = "groupBox_TargetBoardID";
            this.groupBox_TargetBoardID.Size = new System.Drawing.Size(467, 69);
            this.groupBox_TargetBoardID.TabIndex = 62;
            this.groupBox_TargetBoardID.TabStop = false;
            this.groupBox_TargetBoardID.Text = "Target Board ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "(HEX)";
            // 
            // textBox_target
            // 
            this.textBox_target.Location = new System.Drawing.Point(7, 31);
            this.textBox_target.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_target.MaxLength = 2;
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(25, 22);
            this.textBox_target.TabIndex = 6;
            this.textBox_target.TextChanged += new System.EventHandler(this.textBox_target_TextChanged);
            // 
            // groupBox_controls
            // 
            this.groupBox_controls.Controls.Add(this.textBox_B_BW);
            this.groupBox_controls.Controls.Add(this.textBox_B_FW);
            this.groupBox_controls.Controls.Add(this.button_B_STOP);
            this.groupBox_controls.Controls.Add(this.button_B_BW);
            this.groupBox_controls.Controls.Add(this.button_B_FW);
            this.groupBox_controls.Controls.Add(this.textBox_A_BW);
            this.groupBox_controls.Controls.Add(this.textBox_A_FW);
            this.groupBox_controls.Controls.Add(this.button_A_STOP);
            this.groupBox_controls.Controls.Add(this.button_A_BW);
            this.groupBox_controls.Controls.Add(this.button_A_FW);
            this.groupBox_controls.Location = new System.Drawing.Point(15, 346);
            this.groupBox_controls.Name = "groupBox_controls";
            this.groupBox_controls.Size = new System.Drawing.Size(467, 142);
            this.groupBox_controls.TabIndex = 63;
            this.groupBox_controls.TabStop = false;
            this.groupBox_controls.Text = "Controls";
            // 
            // textBox_B_BW
            // 
            this.textBox_B_BW.Location = new System.Drawing.Point(355, 69);
            this.textBox_B_BW.MaxLength = 6;
            this.textBox_B_BW.Name = "textBox_B_BW";
            this.textBox_B_BW.Size = new System.Drawing.Size(100, 22);
            this.textBox_B_BW.TabIndex = 3;
            this.textBox_B_BW.TextChanged += new System.EventHandler(this.textBox_B_BW_TextChanged);
            // 
            // textBox_B_FW
            // 
            this.textBox_B_FW.Location = new System.Drawing.Point(355, 35);
            this.textBox_B_FW.MaxLength = 6;
            this.textBox_B_FW.Name = "textBox_B_FW";
            this.textBox_B_FW.Size = new System.Drawing.Size(100, 22);
            this.textBox_B_FW.TabIndex = 3;
            this.textBox_B_FW.TextChanged += new System.EventHandler(this.textBox_B_FW_TextChanged);
            // 
            // button_B_STOP
            // 
            this.button_B_STOP.Location = new System.Drawing.Point(237, 100);
            this.button_B_STOP.Name = "button_B_STOP";
            this.button_B_STOP.Size = new System.Drawing.Size(115, 28);
            this.button_B_STOP.TabIndex = 2;
            this.button_B_STOP.Text = "B STOP";
            this.button_B_STOP.UseVisualStyleBackColor = true;
            this.button_B_STOP.Click += new System.EventHandler(this.button_B_STOP_Click);
            // 
            // button_B_BW
            // 
            this.button_B_BW.Location = new System.Drawing.Point(237, 66);
            this.button_B_BW.Name = "button_B_BW";
            this.button_B_BW.Size = new System.Drawing.Size(115, 28);
            this.button_B_BW.TabIndex = 2;
            this.button_B_BW.Text = "B BW";
            this.button_B_BW.UseVisualStyleBackColor = true;
            this.button_B_BW.Click += new System.EventHandler(this.button_B_BW_Click);
            // 
            // button_B_FW
            // 
            this.button_B_FW.Location = new System.Drawing.Point(237, 32);
            this.button_B_FW.Name = "button_B_FW";
            this.button_B_FW.Size = new System.Drawing.Size(115, 28);
            this.button_B_FW.TabIndex = 2;
            this.button_B_FW.Text = "B FW";
            this.button_B_FW.UseVisualStyleBackColor = true;
            this.button_B_FW.Click += new System.EventHandler(this.button_B_FW_Click);
            // 
            // textBox_A_BW
            // 
            this.textBox_A_BW.Location = new System.Drawing.Point(126, 69);
            this.textBox_A_BW.MaxLength = 6;
            this.textBox_A_BW.Name = "textBox_A_BW";
            this.textBox_A_BW.Size = new System.Drawing.Size(100, 22);
            this.textBox_A_BW.TabIndex = 1;
            this.textBox_A_BW.TextChanged += new System.EventHandler(this.textBox_A_BW_TextChanged);
            // 
            // textBox_A_FW
            // 
            this.textBox_A_FW.Location = new System.Drawing.Point(126, 35);
            this.textBox_A_FW.MaxLength = 6;
            this.textBox_A_FW.Name = "textBox_A_FW";
            this.textBox_A_FW.Size = new System.Drawing.Size(100, 22);
            this.textBox_A_FW.TabIndex = 1;
            this.textBox_A_FW.TextChanged += new System.EventHandler(this.textBox_A_FW_TextChanged);
            // 
            // button_A_STOP
            // 
            this.button_A_STOP.Location = new System.Drawing.Point(7, 100);
            this.button_A_STOP.Name = "button_A_STOP";
            this.button_A_STOP.Size = new System.Drawing.Size(116, 28);
            this.button_A_STOP.TabIndex = 0;
            this.button_A_STOP.Text = "A STOP";
            this.button_A_STOP.UseVisualStyleBackColor = true;
            this.button_A_STOP.Click += new System.EventHandler(this.button_A_STOP_Click);
            // 
            // button_A_BW
            // 
            this.button_A_BW.Location = new System.Drawing.Point(6, 66);
            this.button_A_BW.Name = "button_A_BW";
            this.button_A_BW.Size = new System.Drawing.Size(116, 28);
            this.button_A_BW.TabIndex = 0;
            this.button_A_BW.Text = "A BW";
            this.button_A_BW.UseVisualStyleBackColor = true;
            this.button_A_BW.Click += new System.EventHandler(this.button_A_BW_Click);
            // 
            // button_A_FW
            // 
            this.button_A_FW.Location = new System.Drawing.Point(7, 32);
            this.button_A_FW.Name = "button_A_FW";
            this.button_A_FW.Size = new System.Drawing.Size(116, 28);
            this.button_A_FW.TabIndex = 0;
            this.button_A_FW.Text = "A FW";
            this.button_A_FW.UseVisualStyleBackColor = true;
            this.button_A_FW.Click += new System.EventHandler(this.button_A_FW_Click);
            // 
            // textBox_pid_output_limix
            // 
            this.textBox_pid_output_limix.Location = new System.Drawing.Point(126, 29);
            this.textBox_pid_output_limix.MaxLength = 2;
            this.textBox_pid_output_limix.Name = "textBox_pid_output_limix";
            this.textBox_pid_output_limix.Size = new System.Drawing.Size(100, 22);
            this.textBox_pid_output_limix.TabIndex = 8;
            this.textBox_pid_output_limix.TextChanged += new System.EventHandler(this.textBox_pid_output_limix_TextChanged);
            // 
            // button_pid_limit
            // 
            this.button_pid_limit.Location = new System.Drawing.Point(7, 26);
            this.button_pid_limit.Name = "button_pid_limit";
            this.button_pid_limit.Size = new System.Drawing.Size(116, 28);
            this.button_pid_limit.TabIndex = 7;
            this.button_pid_limit.Text = "PID LIMIT";
            this.button_pid_limit.UseVisualStyleBackColor = true;
            this.button_pid_limit.Click += new System.EventHandler(this.button_pid_limit_Click);
            // 
            // textBox_B_MoveTo
            // 
            this.textBox_B_MoveTo.Location = new System.Drawing.Point(356, 32);
            this.textBox_B_MoveTo.MaxLength = 6;
            this.textBox_B_MoveTo.Name = "textBox_B_MoveTo";
            this.textBox_B_MoveTo.Size = new System.Drawing.Size(100, 22);
            this.textBox_B_MoveTo.TabIndex = 6;
            this.textBox_B_MoveTo.TextChanged += new System.EventHandler(this.textBox_B_MoveTo_TextChanged);
            // 
            // textBox_A_MoveTo
            // 
            this.textBox_A_MoveTo.Location = new System.Drawing.Point(127, 33);
            this.textBox_A_MoveTo.MaxLength = 6;
            this.textBox_A_MoveTo.Name = "textBox_A_MoveTo";
            this.textBox_A_MoveTo.Size = new System.Drawing.Size(100, 22);
            this.textBox_A_MoveTo.TabIndex = 6;
            this.textBox_A_MoveTo.TextChanged += new System.EventHandler(this.textBox_A_MoveTo_TextChanged);
            // 
            // button_B_MoveTo
            // 
            this.button_B_MoveTo.Location = new System.Drawing.Point(238, 30);
            this.button_B_MoveTo.Name = "button_B_MoveTo";
            this.button_B_MoveTo.Size = new System.Drawing.Size(115, 28);
            this.button_B_MoveTo.TabIndex = 5;
            this.button_B_MoveTo.Text = "B MOVE TO";
            this.button_B_MoveTo.UseVisualStyleBackColor = true;
            this.button_B_MoveTo.Click += new System.EventHandler(this.button_B_MoveTo_Click);
            // 
            // button_A_MoveTo
            // 
            this.button_A_MoveTo.Location = new System.Drawing.Point(8, 30);
            this.button_A_MoveTo.Name = "button_A_MoveTo";
            this.button_A_MoveTo.Size = new System.Drawing.Size(115, 28);
            this.button_A_MoveTo.TabIndex = 5;
            this.button_A_MoveTo.Text = "A MOVE TO";
            this.button_A_MoveTo.UseVisualStyleBackColor = true;
            this.button_A_MoveTo.Click += new System.EventHandler(this.button_A_MoveTo_Click);
            // 
            // button_reset_pic
            // 
            this.button_reset_pic.Location = new System.Drawing.Point(126, 59);
            this.button_reset_pic.Name = "button_reset_pic";
            this.button_reset_pic.Size = new System.Drawing.Size(116, 28);
            this.button_reset_pic.TabIndex = 4;
            this.button_reset_pic.Text = "RESET PIC";
            this.button_reset_pic.UseVisualStyleBackColor = true;
            this.button_reset_pic.Click += new System.EventHandler(this.button_reset_pic_Click);
            // 
            // button_read_count
            // 
            this.button_read_count.Location = new System.Drawing.Point(7, 60);
            this.button_read_count.Name = "button_read_count";
            this.button_read_count.Size = new System.Drawing.Size(116, 28);
            this.button_read_count.TabIndex = 4;
            this.button_read_count.Text = "READ COUNT";
            this.button_read_count.UseVisualStyleBackColor = true;
            this.button_read_count.Click += new System.EventHandler(this.button_read_count_Click);
            // 
            // groupBox_moveto
            // 
            this.groupBox_moveto.Controls.Add(this.textBox_B_MoveTo);
            this.groupBox_moveto.Controls.Add(this.textBox_A_MoveTo);
            this.groupBox_moveto.Controls.Add(this.button_B_MoveTo);
            this.groupBox_moveto.Controls.Add(this.button_AB_MoveTo);
            this.groupBox_moveto.Controls.Add(this.button_A_MoveTo);
            this.groupBox_moveto.Location = new System.Drawing.Point(15, 494);
            this.groupBox_moveto.Name = "groupBox_moveto";
            this.groupBox_moveto.Size = new System.Drawing.Size(467, 111);
            this.groupBox_moveto.TabIndex = 64;
            this.groupBox_moveto.TabStop = false;
            this.groupBox_moveto.Text = "Move To";
            // 
            // button_AB_MoveTo
            // 
            this.button_AB_MoveTo.Location = new System.Drawing.Point(7, 69);
            this.button_AB_MoveTo.Name = "button_AB_MoveTo";
            this.button_AB_MoveTo.Size = new System.Drawing.Size(448, 28);
            this.button_AB_MoveTo.TabIndex = 5;
            this.button_AB_MoveTo.Text = "A AND B MOVE TO";
            this.button_AB_MoveTo.UseVisualStyleBackColor = true;
            this.button_AB_MoveTo.Click += new System.EventHandler(this.button_AB_MoveTo_Click);
            // 
            // groupBox_others
            // 
            this.groupBox_others.Controls.Add(this.button_reset_pic);
            this.groupBox_others.Controls.Add(this.textBox_pid_output_limix);
            this.groupBox_others.Controls.Add(this.button_read_count);
            this.groupBox_others.Controls.Add(this.button_pid_limit);
            this.groupBox_others.Location = new System.Drawing.Point(488, 14);
            this.groupBox_others.Name = "groupBox_others";
            this.groupBox_others.Size = new System.Drawing.Size(466, 98);
            this.groupBox_others.TabIndex = 65;
            this.groupBox_others.TabStop = false;
            this.groupBox_others.Text = "Others";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 617);
            this.Controls.Add(this.groupBox_others);
            this.Controls.Add(this.groupBox_moveto);
            this.Controls.Add(this.groupBox_controls);
            this.Controls.Add(this.groupBox_TargetBoardID);
            this.Controls.Add(this.groupBox_Commands);
            this.Controls.Add(this.groupBox_Message);
            this.Controls.Add(this.groupBox_Ports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Motor GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Ports.ResumeLayout(false);
            this.groupBox_Ports.PerformLayout();
            this.groupBox_Message.ResumeLayout(false);
            this.groupBox_Commands.ResumeLayout(false);
            this.groupBox_Commands.PerformLayout();
            this.groupBox_TargetBoardID.ResumeLayout(false);
            this.groupBox_TargetBoardID.PerformLayout();
            this.groupBox_controls.ResumeLayout(false);
            this.groupBox_controls.PerformLayout();
            this.groupBox_moveto.ResumeLayout(false);
            this.groupBox_moveto.PerformLayout();
            this.groupBox_others.ResumeLayout(false);
            this.groupBox_others.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button PortRefresh_Button;
        private System.Windows.Forms.ComboBox Ports_comboBox;
        private System.Windows.Forms.Button PortConnect_Button;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox PortStatus_TextBox;
        private System.Windows.Forms.GroupBox groupBox_Ports;
        private System.Windows.Forms.TextBox textBox_command_id;
        private System.Windows.Forms.Button command_send_button;
        private System.Windows.Forms.GroupBox groupBox_Message;
        private System.Windows.Forms.RichTextBox message_richTextBox;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.GroupBox groupBox_Commands;
        private System.Windows.Forms.Label label_cmd_data2;
        private System.Windows.Forms.Label label_cmd_data1;
        private System.Windows.Forms.Label label_cmd_id;
        private System.Windows.Forms.TextBox textBox_cmd_data1;
        private System.Windows.Forms.TextBox textBox_cmd_data2;
        private System.Windows.Forms.GroupBox groupBox_TargetBoardID;
        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_controls;
        private System.Windows.Forms.Button button_A_STOP;
        private System.Windows.Forms.Button button_A_BW;
        private System.Windows.Forms.Button button_A_FW;
        private System.Windows.Forms.TextBox textBox_B_BW;
        private System.Windows.Forms.TextBox textBox_B_FW;
        private System.Windows.Forms.Button button_B_STOP;
        private System.Windows.Forms.Button button_B_BW;
        private System.Windows.Forms.Button button_B_FW;
        private System.Windows.Forms.TextBox textBox_A_BW;
        private System.Windows.Forms.TextBox textBox_A_FW;
        private System.Windows.Forms.Button button_reset_pic;
        private System.Windows.Forms.Button button_read_count;
        private System.Windows.Forms.TextBox textBox_B_MoveTo;
        private System.Windows.Forms.TextBox textBox_A_MoveTo;
        private System.Windows.Forms.Button button_B_MoveTo;
        private System.Windows.Forms.Button button_A_MoveTo;
        private System.Windows.Forms.TextBox textBox_pid_output_limix;
        private System.Windows.Forms.Button button_pid_limit;
        private System.Windows.Forms.GroupBox groupBox_moveto;
        private System.Windows.Forms.GroupBox groupBox_others;
        private System.Windows.Forms.Button button_AB_MoveTo;
        private System.Windows.Forms.Label label_cmd_data4;
        private System.Windows.Forms.Label label_cmd_data3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cmd_data4;
        private System.Windows.Forms.TextBox textBox_cmd_data3;        
    }
}

