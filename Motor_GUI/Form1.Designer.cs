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
            this.label_cmd_id = new System.Windows.Forms.Label();
            this.label_cmd_data1 = new System.Windows.Forms.Label();
            this.label_cmd_data2 = new System.Windows.Forms.Label();
            this.textBox_cmd_data1 = new System.Windows.Forms.TextBox();
            this.textBox_cmd_data2 = new System.Windows.Forms.TextBox();
            this.groupBox_Ports.SuspendLayout();
            this.groupBox_Message.SuspendLayout();
            this.groupBox_Commands.SuspendLayout();
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
            this.textBox_command_id.Size = new System.Drawing.Size(61, 22);
            this.textBox_command_id.TabIndex = 6;
            this.textBox_command_id.TextChanged += new System.EventHandler(this.command_id_TextChanged);
            // 
            // command_send_button
            // 
            this.command_send_button.Location = new System.Drawing.Point(7, 81);
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
            this.groupBox_Message.Location = new System.Drawing.Point(490, 14);
            this.groupBox_Message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Message.Name = "groupBox_Message";
            this.groupBox_Message.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Message.Size = new System.Drawing.Size(467, 397);
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
            this.message_richTextBox.Size = new System.Drawing.Size(453, 331);
            this.message_richTextBox.TabIndex = 61;
            this.message_richTextBox.TabStop = false;
            this.message_richTextBox.Text = "";
            this.message_richTextBox.TextChanged += new System.EventHandler(this.message_richTextBox_TextChanged);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.Location = new System.Drawing.Point(7, 360);
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
            this.groupBox_Commands.Controls.Add(this.label_cmd_data2);
            this.groupBox_Commands.Controls.Add(this.label_cmd_data1);
            this.groupBox_Commands.Controls.Add(this.label_cmd_id);
            this.groupBox_Commands.Controls.Add(this.textBox_cmd_data2);
            this.groupBox_Commands.Controls.Add(this.textBox_cmd_data1);
            this.groupBox_Commands.Controls.Add(this.textBox_command_id);
            this.groupBox_Commands.Controls.Add(this.command_send_button);
            this.groupBox_Commands.Location = new System.Drawing.Point(15, 117);
            this.groupBox_Commands.Name = "groupBox_Commands";
            this.groupBox_Commands.Size = new System.Drawing.Size(467, 119);
            this.groupBox_Commands.TabIndex = 61;
            this.groupBox_Commands.TabStop = false;
            this.groupBox_Commands.Text = "Send Commands";
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
            // label_cmd_data1
            // 
            this.label_cmd_data1.AutoSize = true;
            this.label_cmd_data1.Location = new System.Drawing.Point(171, 43);
            this.label_cmd_data1.Name = "label_cmd_data1";
            this.label_cmd_data1.Size = new System.Drawing.Size(61, 17);
            this.label_cmd_data1.TabIndex = 8;
            this.label_cmd_data1.Text = "DATA 1:";
            // 
            // label_cmd_data2
            // 
            this.label_cmd_data2.AutoSize = true;
            this.label_cmd_data2.Location = new System.Drawing.Point(311, 43);
            this.label_cmd_data2.Name = "label_cmd_data2";
            this.label_cmd_data2.Size = new System.Drawing.Size(61, 17);
            this.label_cmd_data2.TabIndex = 8;
            this.label_cmd_data2.Text = "DATA 2:";
            // 
            // textBox_cmd_data1
            // 
            this.textBox_cmd_data1.Location = new System.Drawing.Point(239, 38);
            this.textBox_cmd_data1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cmd_data1.MaxLength = 2;
            this.textBox_cmd_data1.Name = "textBox_cmd_data1";
            this.textBox_cmd_data1.Size = new System.Drawing.Size(61, 22);
            this.textBox_cmd_data1.TabIndex = 6;
            this.textBox_cmd_data1.TextChanged += new System.EventHandler(this.textBox_cmd_data1_TextChanged);
            // 
            // textBox_cmd_data2
            // 
            this.textBox_cmd_data2.Location = new System.Drawing.Point(379, 38);
            this.textBox_cmd_data2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cmd_data2.MaxLength = 2;
            this.textBox_cmd_data2.Name = "textBox_cmd_data2";
            this.textBox_cmd_data2.Size = new System.Drawing.Size(61, 22);
            this.textBox_cmd_data2.TabIndex = 6;
            this.textBox_cmd_data2.TextChanged += new System.EventHandler(this.textBox_cmd_data2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 422);
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
    }
}

