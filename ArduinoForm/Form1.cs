using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int P12 = 0;
        int P12V = 0;
        string P12VV = "00";
        int IsP12 = 0;
        string sp1read = string.Empty;
        string sp2read = string.Empty;
        bool OK = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 660;

            this.richTextBox3.Text =
@"//X:0 100 //0=左 1=右
//Y:0 100 //0=上 1=下
//Z:0 100 //0=前 1=后
//D:4 1  //4=针脚 1=启动 0=关闭
//T:1000 //毫秒等待
//S:460  //电机起速
//P:10   //10=下降沿 01=上升沿
";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "关闭")
            {

                serialPort1.Close();
                //timer1.Stop();

                //if (serialPort2.IsOpen)
                //{
                //   // serialPort2.Close();
                //   // timer4.Stop();
                //}

                this.button1.Text = "打开";
            }
            else
            {
                if (String.IsNullOrEmpty(this.textBox1.Text.Trim(',')))
                {
                    MessageBox.Show("..........");
                    return;
                }
                string[] coms = this.textBox1.Text.Trim().Split(',');

                try
                {
                    this.serialPort1.PortName = coms[0];

                    serialPort1.Open();


                    if (coms.Length == 2)
                    {
                        this.serialPort2.PortName = coms[1];
                        serialPort2.Open();
                    }
                }
                catch (Exception ew) { MessageBox.Show(ew.Message); }




                if (serialPort1.IsOpen)
                {
                    string msg=string.Empty;
                    while (serialPort1.BytesToRead > 0)
                    {
                        try
                        {
                            Application.DoEvents();
                            char[] inChar = new char[1];
                            int c = serialPort1.Read(inChar, 0, 1);
                            msg +=Convert.ToInt32(inChar);
                            Thread.Sleep(1);
                        }
                        catch { }
                    }
                    richTextBox2.AppendText(msg+"\n");

                    this.button1.Text = "关闭";
                    //timer1.Start();
                    //timer1.Interval = 100;
                    //timer1.Enabled = true;
                }
                if (serialPort2.IsOpen)
                {
                    //timer4.Start();
                    //timer4.Interval = 100;
                    //timer4.Enabled = true;
                }
            }

            this.label2.Text = serialPort1.IsOpen.ToString();

        }//打开端口



        private void btnFA_Click(object sender, EventArgs e)
        {

        }


        bool IsReadError = false;
        string ReadMsg = string.Empty;

        private void btnZ1_Click(object sender, EventArgs e)
        {
            RunXYZ(0);
            zfv = 0;
        }
        private void btnF1_Click(object sender, EventArgs e)
        {
            RunXYZ(1);
            zfv = 1;
        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

           // sp1read = serialPort1.ReadExisting();
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            richTextBox2.AppendText("ErrorReceived");
        }

        private void ConLog(string msg)
        {
            this.richTextBox2.AppendText(msg + "\n");
         
            richTextBox2.ScrollToCaret();
            if (richTextBox2.Text.Length > 2000)
                richTextBox2.Text = string.Empty;
            if (richTextBox1.Text.Length > 5)
                richTextBox1.Text = "0";
        }

        private string ReceivedData()
        {
             //Thread.Sleep(99);
           
            try
            {
                if (!serialPort1.IsOpen)
                {
                    IsReadError = true;
                    ConLog("端口已关闭");
                    return "Error"; }
                string msg = string.Empty;
                char[] inChar = new char[1];
                bool f = false;
                bool isa = false;
                while (!f)
                {
                    if (serialPort1.BytesToRead > 0)
                    {
                        int c = serialPort1.Read(inChar, 0, 1);
                        char iChar = inChar[0];
                        if (iChar == '^')
                            isa = true;
                        if (isa)
                            msg += iChar;
                        if (iChar == '$')
                        {
                            f = true;
                            isa = false;
                        }
                    }
                    else
                    {
                        Application.DoEvents();
                        Thread.Sleep(9);
                    }

                }
                msg = msg.Trim('^').Trim('$');

                ConLog(msg);
                sp1read = string.Empty;

                if (msg == "P=01")
                {
                    P12 = 1;
                    P12VV = "01";
                    this.Text = "P=01";
                    P12V = 1;
                }
                if (msg == "P=10")
                {
                    P12 = 0;
                    P12VV = "10";
                    this.Text = "P=10";
                    P12V = 0;
                }


                if (msg == "OK")
                {
                    OK = true;
                }

                return msg;
            }
            catch(Exception ew) { ConLog(ew.Message); IsReadError = true; return "Error"; }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (serialPort1.BytesToRead > 0)
            //{

            //    sp1read = serialPort1.ReadExisting();
            //    if (sp1read != "") ReceivedData(sp1read);
            //}
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string arg = this.textBox2.Text.Trim();
                string cmdstr = string.Empty;

                if (arg.Split(' ').Length == 1)
                {
                    if (Convert.ToInt32(arg) > 60000)
                    { arg = "60000"; this.textBox2.Text = "60000"; }
                    cmdstr = string.Format("^S {0}&260###$", Convert.ToInt32(arg).ToString("00000"));
                }
                else if (arg.Split(' ').Length == 2)
                {
                    string arg1 = arg.Split(' ')[0];
                    string arg2 = arg.Split(' ')[1];
                    if (Convert.ToInt32(arg1) > 60000)
                    { arg1 = "60000"; }
                    if (Convert.ToInt32(arg2) > 999)
                    { arg2 = "260"; }
                    cmdstr = string.Format("^S {0}&{1}###$", Convert.ToInt32(arg1).ToString("00000"), Convert.ToInt32(arg2).ToString("000"));
                }
                else
                {
                    cmdstr = "^S 00500&260###$";
                }


                SPSend(cmdstr, "OK");

            }
            catch(Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnH1_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtPin1.Text.Trim());
                int c = Convert.ToInt32(txtC1.Text.Trim());
                CMDD(pin, 1, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnL1_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtPin1.Text.Trim());
                int c = Convert.ToInt32(txtC1.Text.Trim());
                CMDD(pin, 0, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string code = Frank.GetPageCode.getCode("http://139.196.6.17:8011/api.aspx", "utf-8");
                if (!string.IsNullOrEmpty(code))
                {

                    if (code.Split('|').Length != 3)
                        return;
                    int pin = Convert.ToInt32(code.Split('|')[0]);
                    int t = Convert.ToInt32(code.Split('|')[1]);
                    int c = Convert.ToInt32(code.Split('|')[2]);
                    if (t == 1)
                    {
                        string pinv = pin + "|1";

                        serialPort1.WriteLine("11 " + pinv);//高
                        Thread.Sleep(1000);
                        serialPort1.WriteLine("10 " + pinv);//低

                        //richTextBox2.AppendText("11 " + pin + "|1\n");
                        //richTextBox2.AppendText("10 " + pin + "|1\n");

                        if (pin == 3)//关门
                        {
                            Thread.Sleep(2000);
                            if (c <= 4)
                            {
                                string pinvv = (pin + c) + "|1";
                                //自动补货
                                serialPort1.WriteLine("11 " + pinvv);//开补货门
                                Thread.Sleep(1000);
                                serialPort1.WriteLine("10 " + pinvv);//关补货门


                                //richTextBox2.AppendText("11 " + (pin + c) + "|1\n"); 
                                //richTextBox2.AppendText("10 " + (pin + c) + "|1\n");

                            }

                        }


                    }
                    else
                        serialPort1.WriteLine("10 " + pin + "|1");
                }
            }
            catch { }
        }

        private void btnWWW_Click(object sender, EventArgs e)
        {
            MessageBox.Show("针对内部使用，有时间再改成公众版，联系Frank");
            return;
            //
            if (this.btnWWW.Text == "开启网络")
            {
                timer2.Start();
                this.btnWWW.Text = "关闭网络";
            }
            else
            {
                timer2.Stop();
                this.btnWWW.Text = "开启网络";
            }


        }

        //自动测试
        int zfv = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if (isRXYZ) return;
            zfv = zfv == 0 ? 1 : 0;
            RunXYZ(zfv);

        }


        bool isRXYZ = false;
        private void RunXYZ(int d)
        {
            if (isRXYZ) return;
            isRXYZ = true;
            try
            {
                string pin = "02";
                string dpin = "03";

                if (CBX.Checked)
                {
                    pin = "08";
                    dpin = "09";
                }
                if (CBY.Checked)
                {
                    pin = "10";
                    dpin = "11";
                }


                if (serialPort1.IsOpen)
                {
                    string z = d == 0 ? txtBoxZ1.Text.Trim() : txtBoxF1.Text.Trim();
                    if (string.IsNullOrEmpty(z))
                        z = "1";
                    int c = Convert.ToInt32(z);
                    if (c > 9999) c = 9999;
                    string s = c.ToString("0000");

                    string cmd = string.Format("^B {0}&{1}&{2}&{3}$", pin, s, dpin, d);

                    SPSend(cmd, "OK");

                    // zfv = zfv == 0 ? 1 : 0;
                    try
                    {
                        richTextBox1.Text = Convert.ToString(c + Convert.ToInt32(richTextBox1.Text.Trim()));

                    }
                    catch { richTextBox1.Text = c.ToString(); }
                }
            }
            catch (Exception EW) { ConLog(EW.Message); }
            finally { isRXYZ = false; }
        }


        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbAuto.Checked)
                {
                    timer3.Start();
                    timer3.Interval = Convert.ToInt32(this.txtT3v.Text.Trim()) * 1000;
                    timer3.Enabled = true;
                }
                else
                {
                    timer3.Stop();
                    timer3.Enabled = false;
                }
            }
            catch (Exception ew){ MessageBox.Show(ew.Message); }
        }

        private void btnH2_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP2.Text.Trim());
                int c = Convert.ToInt32(txtC2.Text.Trim());
                CMDD(pin, 1, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnL2_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP2.Text.Trim());
                int c = Convert.ToInt32(txtC2.Text.Trim());
                CMDD(pin, 0, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnH3_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP3.Text.Trim());
                int c = Convert.ToInt32(txtC3.Text.Trim());
                CMDD(pin, 1, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnL3_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP3.Text.Trim());
                int c = Convert.ToInt32(txtC3.Text.Trim());
                CMDD(pin, 0, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnH4_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP4.Text.Trim());
                int c = Convert.ToInt32(txtC4.Text.Trim());
                CMDD(pin, 1, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnL4_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP4.Text.Trim());
                int c = Convert.ToInt32(txtC4.Text.Trim());
                CMDD(pin, 0, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnH5_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP5.Text.Trim());
                int c = Convert.ToInt32(txtC5.Text.Trim());
                CMDD(pin, 1, c);
            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }
        }

        private void btnL5_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(txtP5.Text.Trim());
                int c = Convert.ToInt32(txtC5.Text.Trim());
                CMDD(pin, 0, c);
            }
            catch(Exception ew) { MessageBox.Show(ew.Message); }
        }

        private bool CMDD(int pin,int d,int c)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                   
                    if (c > 9999)
                        c = 9999;
                    string cmd = string.Format("^D {0}&{1}&{2}###$", pin.ToString("00"), d, c.ToString("0000"));
                   
                    SPSend(cmd, "OK");

                    return true;

                }
                catch (Exception ew) { return false; }
            }
            else
                return false;
        }


        // 
        private void btnT1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("串口未打开\n");
                return;
            }

            //if (serialPort2.IsOpen)
            //{
            //    //开启P12光电
            //    IsP12 = 1;
            //    serialPort2.WriteLine("12 1");
            //}
            //else
            //{
            //    // MessageBox.Show("光电串口未开启，不能使用P:\\d 命令");
            //}


            try
            {


                RunCMD();
               


            }
            catch (Exception ew) { MessageBox.Show(ew.Message); }





        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //sp2read = serialPort2.ReadExisting();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
             
        }



        private void P12Init()
        {
            P12V = 0;
            P12VV = "00";
        }

        bool IsRun = false;
        private void RunCMD()
        {
            if (IsRun) return;
            IsRun = true;

            #region RUNCMD
            P12Init();
            //光电防干扰，重新启用

            if (!string.IsNullOrEmpty(this.richTextBox3.Text.Trim()))
            {

                richTextBox2.Text = "";

                string[] cmdlist = richTextBox3.Text.Split('\n');
                bool cmdf = true;
                for (int i = 0; i < cmdlist.Length; i++)
                {
                    if (!cmdf) break;//中间命令错误，整个流程结束
                    string cmd = cmdlist[i];

                    if (cmd.Trim().Length < 3) continue;
                    if (cmd.StartsWith("//")) continue;

                    if (cmd.IndexOf("//") > 0)
                        cmd = cmd.Substring(0, cmd.IndexOf("//")).Trim();

                    string cmdt = cmd.Split(':')[0];
                    string args = cmd.Split(':')[1];

                    //richTextBox2.AppendText(cmd + "\n");
                    //richTextBox2.ScrollToCaret();
                     Application.DoEvents();
                    Thread.Sleep(500);
                    switch (cmdt.ToUpper())
                    {
                        case "X":
                            {
                                //int PIN = 8;
                                try {
                                    string d = args.Split(' ')[0];
                                    int c = Convert.ToInt32(args.Split(' ')[1]);
                                    if (c > 9999) c = 9999;
                                    string cmdstr = string.Format("^B 08&{0}&09&{1}$", c.ToString("0000"), d);

                                    SPSend(cmdstr, "OK");

                                    OK = false;
                                    Thread.Sleep(9); 
                                } catch (Exception ew){ cmdf = false; break; }
                                
                            }
                            break;
                        case "Y":
                            {
                                //int PIN = 10;
                                try
                                {
                                    string d = args.Split(' ')[0];
                                    int c = Convert.ToInt32(args.Split(' ')[1]);
                                    if (c > 9999) c = 9999;
                                    string cmdstr = string.Format("^B 10&{0}&11&{1}$", c.ToString("0000"), d);


                                    SPSend(cmdstr, "OK");


                                    OK = false;
                                    Thread.Sleep(9);
                                }
                                catch (Exception ew) { cmdf = false; break; }

                            }
                            break;
                        case "Z":
                            {
                                //pin=2 / 3
                                try
                                {
                                    string d = args.Split(' ')[0];
                                    int c = Convert.ToInt32(args.Split(' ')[1]);
                                    if (c > 9999) c = 9999;
                                    string cmdstr = string.Format("^B 02&{0}&03&{1}$", c.ToString("0000"), d);

                                    SPSend(cmdstr, "OK");


                                    OK = false;
                                    Thread.Sleep(9);
                                }
                                catch (Exception ew) { cmdf = false; break; }

                            }
                            break;
                        case "D":
                            {
                                try
                                {
                                    int pin = Convert.ToInt32(args.Split(' ')[0]);
                                    int c = Convert.ToInt32(args.Split(' ')[1]);
                                    string cmdstr = string.Format("^D {0}&{1}&0001###$", pin.ToString("00"), c);

                                    SPSend(cmdstr, "OK");


                                    OK = false;
                                    Thread.Sleep(9);
                                }
                                catch (Exception ew) { cmdf = false; break; }
                            }
                            break;
                        case "S":
                            {
                                try
                                {
                                    int maxspeed = 260;
                                    int minspeed = 460;
                                    //^S 00400&260###$
                                    if (args.Split(' ').Length == 2)
                                    {
                                        minspeed = Convert.ToInt32(args.Split(' ')[0]);
                                        maxspeed = Convert.ToInt32(args.Split(' ')[1]);
                                    }
                                    else
                                        minspeed = Convert.ToInt32(args);

                                    if (minspeed > 60000) minspeed = 60000;
                                    if (maxspeed > 999) maxspeed = 999;

                                    string cmdstr = string.Format("^S {0}&{1}###$", minspeed.ToString("00000"), maxspeed.ToString("000"));

                                    SPSend(cmdstr, "OK");


                                    OK = false;
                                    Thread.Sleep(9);
                                }
                                catch (Exception ew) { cmdf = false; break; }
                            }
                            break;
                        case "P":
                            {

                                if (string.IsNullOrEmpty(args))
                                    break;

                                if (args.Split(' ').Length == 2)
                                {
                                    
                                    SPSend(string.Empty, string.Format("P{0}={1}", args.Split(' ')[0], args.Split(' ')[1]));
                                }
                                else
                                    SPSend(string.Empty, ("PA1=" + args));


                                //ReadMsg = string.Empty;
                                //IsReadError = false; 
                                //while (!ReadMsg.Equals(("P=" + args)))
                                //{
                                //    if (IsReadError) break;
                                //    ReadMsg = ReceivedData();
                                //    Application.DoEvents();
                                //    Thread.Sleep(1);
                                //}

                            }
                            break;
                        case "T": { Application.DoEvents(); Thread.Sleep(Convert.ToInt32(args));   } break;
                        default: break;
                    }

                    OK = false;

                }

            }
            #endregion
            IsRun = false;

        }



        private void cbCMDAuto_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbCMDAuto.Checked)
            {
               
                timer5.Interval = 1000 * 5;
                timer5.Enabled = true; 
                timer5.Start();

            }
            else
            {
                timer5.Stop();
                timer5.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(999);
            Application.DoEvents();
            if (!IsRun)
                RunCMD();
        }

        private void CBZ_CheckedChanged(object sender, EventArgs e)
        {
            if (CBZ.Checked)
            {
                CBX.Checked = false;
                CBY.Checked = false;
                CBZ.Checked = true;
            } 
        }

        private void CBY_CheckedChanged(object sender, EventArgs e)
        {
            if (CBY.Checked)
            { 
                CBX.Checked = false;
                CBZ.Checked = false;
                CBY.Checked = true;
            }
             
        }

        private void CBX_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX.Checked)
            {
                CBZ.Checked = false;
                CBY.Checked = false;
                CBX.Checked = true;
            }
        }



        private bool SPSend(string cmd,string received)
        {
            if (!serialPort1.IsOpen) return false;

            if (!string.IsNullOrEmpty(cmd))
                serialPort1.Write(cmd);

            if (string.IsNullOrEmpty(received))
                return true;

            IsReadError = false;
            ReadMsg = string.Empty;
            while (!ReadMsg.Equals(received))
            {
                if (IsReadError) break;
                ReadMsg = ReceivedData();
                Application.DoEvents();
                Thread.Sleep(9);
            }
            if (IsReadError) return false;
            else return true;

        }



    }
}
