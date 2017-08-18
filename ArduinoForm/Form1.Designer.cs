namespace ArduinoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWWW = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBZ = new System.Windows.Forms.CheckBox();
            this.CBY = new System.Windows.Forms.CheckBox();
            this.CBX = new System.Windows.Forms.CheckBox();
            this.btnL5 = new System.Windows.Forms.Button();
            this.btnH5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtC5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtP5 = new System.Windows.Forms.TextBox();
            this.cbCMDAuto = new System.Windows.Forms.CheckBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtT3v = new System.Windows.Forms.TextBox();
            this.btnL4 = new System.Windows.Forms.Button();
            this.btnH4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtC4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.btnL3 = new System.Windows.Forms.Button();
            this.btnH3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.btnL2 = new System.Windows.Forms.Button();
            this.btnH2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.btnL1 = new System.Windows.Forms.Button();
            this.btnH1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPin1 = new System.Windows.Forms.TextBox();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnT1 = new System.Windows.Forms.Button();
            this.btnF1 = new System.Windows.Forms.Button();
            this.txtBoxF1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZ1 = new System.Windows.Forms.Button();
            this.txtBoxZ1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "COM4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWWW);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(29, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1475, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口设置";
            // 
            // btnWWW
            // 
            this.btnWWW.Location = new System.Drawing.Point(781, 49);
            this.btnWWW.Margin = new System.Windows.Forms.Padding(4);
            this.btnWWW.Name = "btnWWW";
            this.btnWWW.Size = new System.Drawing.Size(204, 46);
            this.btnWWW.TabIndex = 7;
            this.btnWWW.Text = "开启网络";
            this.btnWWW.UseVisualStyleBackColor = true;
            this.btnWWW.Click += new System.EventHandler(this.btnWWW_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1339, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1029, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "起步速度：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1168, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "360";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "尚未打开端口";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBZ);
            this.groupBox2.Controls.Add(this.CBY);
            this.groupBox2.Controls.Add(this.CBX);
            this.groupBox2.Controls.Add(this.btnL5);
            this.groupBox2.Controls.Add(this.btnH5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtC5);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtP5);
            this.groupBox2.Controls.Add(this.cbCMDAuto);
            this.groupBox2.Controls.Add(this.richTextBox3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtT3v);
            this.groupBox2.Controls.Add(this.btnL4);
            this.groupBox2.Controls.Add(this.btnH4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtC4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtP4);
            this.groupBox2.Controls.Add(this.btnL3);
            this.groupBox2.Controls.Add(this.btnH3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtC3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtP3);
            this.groupBox2.Controls.Add(this.btnL2);
            this.groupBox2.Controls.Add(this.btnH2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtC2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtP2);
            this.groupBox2.Controls.Add(this.btnL1);
            this.groupBox2.Controls.Add(this.btnH1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtC1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPin1);
            this.groupBox2.Controls.Add(this.cbAuto);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.btnT1);
            this.groupBox2.Controls.Add(this.btnF1);
            this.groupBox2.Controls.Add(this.txtBoxF1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnZ1);
            this.groupBox2.Controls.Add(this.txtBoxZ1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(29, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1475, 1074);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // CBZ
            // 
            this.CBZ.AutoSize = true;
            this.CBZ.Checked = true;
            this.CBZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBZ.Location = new System.Drawing.Point(316, 122);
            this.CBZ.Margin = new System.Windows.Forms.Padding(4);
            this.CBZ.Name = "CBZ";
            this.CBZ.Size = new System.Drawing.Size(90, 29);
            this.CBZ.TabIndex = 48;
            this.CBZ.Text = "Z-P2";
            this.CBZ.UseVisualStyleBackColor = true;
            this.CBZ.CheckedChanged += new System.EventHandler(this.CBZ_CheckedChanged);
            // 
            // CBY
            // 
            this.CBY.AutoSize = true;
            this.CBY.Location = new System.Drawing.Point(193, 122);
            this.CBY.Margin = new System.Windows.Forms.Padding(4);
            this.CBY.Name = "CBY";
            this.CBY.Size = new System.Drawing.Size(104, 29);
            this.CBY.TabIndex = 47;
            this.CBY.Text = "Y-P10";
            this.CBY.UseVisualStyleBackColor = true;
            this.CBY.CheckedChanged += new System.EventHandler(this.CBY_CheckedChanged);
            // 
            // CBX
            // 
            this.CBX.AutoSize = true;
            this.CBX.Location = new System.Drawing.Point(69, 122);
            this.CBX.Margin = new System.Windows.Forms.Padding(4);
            this.CBX.Name = "CBX";
            this.CBX.Size = new System.Drawing.Size(91, 29);
            this.CBX.TabIndex = 46;
            this.CBX.Text = "X-P8";
            this.CBX.UseVisualStyleBackColor = true;
            this.CBX.CheckedChanged += new System.EventHandler(this.CBX_CheckedChanged);
            // 
            // btnL5
            // 
            this.btnL5.Location = new System.Drawing.Point(1223, 796);
            this.btnL5.Margin = new System.Windows.Forms.Padding(4);
            this.btnL5.Name = "btnL5";
            this.btnL5.Size = new System.Drawing.Size(205, 49);
            this.btnL5.TabIndex = 45;
            this.btnL5.Text = "低";
            this.btnL5.UseVisualStyleBackColor = true;
            this.btnL5.Click += new System.EventHandler(this.btnL5_Click);
            // 
            // btnH5
            // 
            this.btnH5.Location = new System.Drawing.Point(984, 796);
            this.btnH5.Margin = new System.Windows.Forms.Padding(4);
            this.btnH5.Name = "btnH5";
            this.btnH5.Size = new System.Drawing.Size(205, 49);
            this.btnH5.TabIndex = 44;
            this.btnH5.Text = "高";
            this.btnH5.UseVisualStyleBackColor = true;
            this.btnH5.Click += new System.EventHandler(this.btnH5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1219, 730);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 43;
            this.label15.Text = "次数：";
            // 
            // txtC5
            // 
            this.txtC5.Location = new System.Drawing.Point(1304, 725);
            this.txtC5.Margin = new System.Windows.Forms.Padding(4);
            this.txtC5.Name = "txtC5";
            this.txtC5.Size = new System.Drawing.Size(123, 31);
            this.txtC5.TabIndex = 42;
            this.txtC5.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(980, 729);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 25);
            this.label16.TabIndex = 41;
            this.label16.Text = "针脚：";
            // 
            // txtP5
            // 
            this.txtP5.Location = new System.Drawing.Point(1065, 724);
            this.txtP5.Margin = new System.Windows.Forms.Padding(4);
            this.txtP5.Name = "txtP5";
            this.txtP5.Size = new System.Drawing.Size(123, 31);
            this.txtP5.TabIndex = 40;
            this.txtP5.Text = "13";
            // 
            // cbCMDAuto
            // 
            this.cbCMDAuto.AutoSize = true;
            this.cbCMDAuto.Location = new System.Drawing.Point(63, 441);
            this.cbCMDAuto.Margin = new System.Windows.Forms.Padding(4);
            this.cbCMDAuto.Name = "cbCMDAuto";
            this.cbCMDAuto.Size = new System.Drawing.Size(88, 29);
            this.cbCMDAuto.TabIndex = 39;
            this.cbCMDAuto.Text = "Auto";
            this.cbCMDAuto.UseVisualStyleBackColor = true;
            this.cbCMDAuto.CheckedChanged += new System.EventHandler(this.cbCMDAuto_CheckedChanged_1);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(39, 493);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(397, 551);
            this.richTextBox3.TabIndex = 38;
            this.richTextBox3.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Time(s)：";
            // 
            // txtT3v
            // 
            this.txtT3v.Location = new System.Drawing.Point(316, 57);
            this.txtT3v.Margin = new System.Windows.Forms.Padding(4);
            this.txtT3v.Name = "txtT3v";
            this.txtT3v.Size = new System.Drawing.Size(120, 31);
            this.txtT3v.TabIndex = 9;
            this.txtT3v.Text = "5";
            // 
            // btnL4
            // 
            this.btnL4.Location = new System.Drawing.Point(1223, 636);
            this.btnL4.Margin = new System.Windows.Forms.Padding(4);
            this.btnL4.Name = "btnL4";
            this.btnL4.Size = new System.Drawing.Size(205, 49);
            this.btnL4.TabIndex = 37;
            this.btnL4.Text = "低";
            this.btnL4.UseVisualStyleBackColor = true;
            this.btnL4.Click += new System.EventHandler(this.btnL4_Click);
            // 
            // btnH4
            // 
            this.btnH4.Location = new System.Drawing.Point(984, 636);
            this.btnH4.Margin = new System.Windows.Forms.Padding(4);
            this.btnH4.Name = "btnH4";
            this.btnH4.Size = new System.Drawing.Size(205, 49);
            this.btnH4.TabIndex = 36;
            this.btnH4.Text = "高";
            this.btnH4.UseVisualStyleBackColor = true;
            this.btnH4.Click += new System.EventHandler(this.btnH4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1219, 571);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "次数：";
            // 
            // txtC4
            // 
            this.txtC4.Location = new System.Drawing.Point(1304, 566);
            this.txtC4.Margin = new System.Windows.Forms.Padding(4);
            this.txtC4.Name = "txtC4";
            this.txtC4.Size = new System.Drawing.Size(123, 31);
            this.txtC4.TabIndex = 34;
            this.txtC4.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(980, 570);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "针脚：";
            // 
            // txtP4
            // 
            this.txtP4.Location = new System.Drawing.Point(1065, 564);
            this.txtP4.Margin = new System.Windows.Forms.Padding(4);
            this.txtP4.Name = "txtP4";
            this.txtP4.Size = new System.Drawing.Size(123, 31);
            this.txtP4.TabIndex = 32;
            this.txtP4.Text = "7";
            // 
            // btnL3
            // 
            this.btnL3.Location = new System.Drawing.Point(1223, 471);
            this.btnL3.Margin = new System.Windows.Forms.Padding(4);
            this.btnL3.Name = "btnL3";
            this.btnL3.Size = new System.Drawing.Size(205, 49);
            this.btnL3.TabIndex = 31;
            this.btnL3.Text = "低";
            this.btnL3.UseVisualStyleBackColor = true;
            this.btnL3.Click += new System.EventHandler(this.btnL3_Click);
            // 
            // btnH3
            // 
            this.btnH3.Location = new System.Drawing.Point(984, 471);
            this.btnH3.Margin = new System.Windows.Forms.Padding(4);
            this.btnH3.Name = "btnH3";
            this.btnH3.Size = new System.Drawing.Size(205, 49);
            this.btnH3.TabIndex = 30;
            this.btnH3.Text = "高";
            this.btnH3.UseVisualStyleBackColor = true;
            this.btnH3.Click += new System.EventHandler(this.btnH3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1219, 405);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "次数：";
            // 
            // txtC3
            // 
            this.txtC3.Location = new System.Drawing.Point(1304, 400);
            this.txtC3.Margin = new System.Windows.Forms.Padding(4);
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(123, 31);
            this.txtC3.TabIndex = 28;
            this.txtC3.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(980, 404);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "针脚：";
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(1065, 399);
            this.txtP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(123, 31);
            this.txtP3.TabIndex = 26;
            this.txtP3.Text = "6";
            // 
            // btnL2
            // 
            this.btnL2.Location = new System.Drawing.Point(1223, 305);
            this.btnL2.Margin = new System.Windows.Forms.Padding(4);
            this.btnL2.Name = "btnL2";
            this.btnL2.Size = new System.Drawing.Size(205, 49);
            this.btnL2.TabIndex = 25;
            this.btnL2.Text = "低";
            this.btnL2.UseVisualStyleBackColor = true;
            this.btnL2.Click += new System.EventHandler(this.btnL2_Click);
            // 
            // btnH2
            // 
            this.btnH2.Location = new System.Drawing.Point(984, 305);
            this.btnH2.Margin = new System.Windows.Forms.Padding(4);
            this.btnH2.Name = "btnH2";
            this.btnH2.Size = new System.Drawing.Size(205, 49);
            this.btnH2.TabIndex = 24;
            this.btnH2.Text = "高";
            this.btnH2.UseVisualStyleBackColor = true;
            this.btnH2.Click += new System.EventHandler(this.btnH2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1219, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "次数：";
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(1304, 234);
            this.txtC2.Margin = new System.Windows.Forms.Padding(4);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(123, 31);
            this.txtC2.TabIndex = 22;
            this.txtC2.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(980, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "针脚：";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(1065, 233);
            this.txtP2.Margin = new System.Windows.Forms.Padding(4);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(123, 31);
            this.txtP2.TabIndex = 20;
            this.txtP2.Text = "5";
            // 
            // btnL1
            // 
            this.btnL1.Location = new System.Drawing.Point(1223, 150);
            this.btnL1.Margin = new System.Windows.Forms.Padding(4);
            this.btnL1.Name = "btnL1";
            this.btnL1.Size = new System.Drawing.Size(205, 49);
            this.btnL1.TabIndex = 19;
            this.btnL1.Text = "低";
            this.btnL1.UseVisualStyleBackColor = true;
            this.btnL1.Click += new System.EventHandler(this.btnL1_Click);
            // 
            // btnH1
            // 
            this.btnH1.Location = new System.Drawing.Point(984, 150);
            this.btnH1.Margin = new System.Windows.Forms.Padding(4);
            this.btnH1.Name = "btnH1";
            this.btnH1.Size = new System.Drawing.Size(205, 49);
            this.btnH1.TabIndex = 18;
            this.btnH1.Text = "高";
            this.btnH1.UseVisualStyleBackColor = true;
            this.btnH1.Click += new System.EventHandler(this.btnH1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1219, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "次数：";
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(1304, 79);
            this.txtC1.Margin = new System.Windows.Forms.Padding(4);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(123, 31);
            this.txtC1.TabIndex = 16;
            this.txtC1.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(980, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "针脚：";
            // 
            // txtPin1
            // 
            this.txtPin1.Location = new System.Drawing.Point(1065, 78);
            this.txtPin1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPin1.Name = "txtPin1";
            this.txtPin1.Size = new System.Drawing.Size(123, 31);
            this.txtPin1.TabIndex = 14;
            this.txtPin1.Text = "4";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(69, 55);
            this.cbAuto.Margin = new System.Windows.Forms.Padding(4);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(88, 29);
            this.cbAuto.TabIndex = 13;
            this.cbAuto.Text = "Auto";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(507, 79);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(431, 965);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 330);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 62);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "0";
            // 
            // btnT1
            // 
            this.btnT1.Location = new System.Drawing.Point(199, 424);
            this.btnT1.Margin = new System.Windows.Forms.Padding(4);
            this.btnT1.Name = "btnT1";
            this.btnT1.Size = new System.Drawing.Size(239, 61);
            this.btnT1.TabIndex = 6;
            this.btnT1.Text = "执行命令";
            this.btnT1.UseVisualStyleBackColor = true;
            this.btnT1.Click += new System.EventHandler(this.btnT1_Click);
            // 
            // btnF1
            // 
            this.btnF1.Location = new System.Drawing.Point(305, 259);
            this.btnF1.Margin = new System.Windows.Forms.Padding(4);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(132, 49);
            this.btnF1.TabIndex = 5;
            this.btnF1.Text = "走";
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // txtBoxF1
            // 
            this.txtBoxF1.Location = new System.Drawing.Point(164, 267);
            this.txtBoxF1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxF1.Name = "txtBoxF1";
            this.txtBoxF1.Size = new System.Drawing.Size(132, 31);
            this.txtBoxF1.TabIndex = 4;
            this.txtBoxF1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "反方向：";
            // 
            // btnZ1
            // 
            this.btnZ1.Location = new System.Drawing.Point(305, 171);
            this.btnZ1.Margin = new System.Windows.Forms.Padding(4);
            this.btnZ1.Name = "btnZ1";
            this.btnZ1.Size = new System.Drawing.Size(132, 49);
            this.btnZ1.TabIndex = 2;
            this.btnZ1.Text = "走";
            this.btnZ1.UseVisualStyleBackColor = true;
            this.btnZ1.Click += new System.EventHandler(this.btnZ1_Click);
            // 
            // txtBoxZ1
            // 
            this.txtBoxZ1.Location = new System.Drawing.Point(164, 178);
            this.txtBoxZ1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxZ1.Name = "txtBoxZ1";
            this.txtBoxZ1.Size = new System.Drawing.Size(132, 31);
            this.txtBoxZ1.TabIndex = 1;
            this.txtBoxZ1.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "正方向：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 2000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 1386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ArduinoControl V1.0 By:Frank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxZ1;
        private System.Windows.Forms.Button btnZ1;
        private System.Windows.Forms.Button btnF1;
        private System.Windows.Forms.TextBox txtBoxF1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnT1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPin1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Button btnL1;
        private System.Windows.Forms.Button btnH1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnWWW;
        private System.Windows.Forms.Button btnL3;
        private System.Windows.Forms.Button btnH3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.Button btnL2;
        private System.Windows.Forms.Button btnH2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Button btnL4;
        private System.Windows.Forms.Button btnH4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtC4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtP4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtT3v;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.CheckBox cbCMDAuto;
        private System.Windows.Forms.Button btnL5;
        private System.Windows.Forms.Button btnH5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtC5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtP5;
        private System.Windows.Forms.CheckBox CBZ;
        private System.Windows.Forms.CheckBox CBY;
        private System.Windows.Forms.CheckBox CBX;
    }
}

