using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Threading;
using System.Net;
using static Control_Station.Form1;
using System.Timers;
using System.Reflection.Emit;
using System.Xml;

namespace Control_Station
{

    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        UdpClient client = new UdpClient();
        //IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.137.70"), 5005); // Raspberry Pi'nin IP'si ve port numarası
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.137.160"), 2222);
        private bool listening = false;


        public Form1()
        {

            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Interval = 250;
            timer.Start();

            this.KeyPreview = true;  // Form'un tuş olaylarını işleyebilmesi için gerekli
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

            
        }
        private void TimerOnTick(object sender, EventArgs ea)
        {
            // BU KISMI DİREKT BUTON İÇİNE DE KOYABİLİRSİN.

            listening = true;

            // Thread'de dinleme işlemini başlat
            Thread listenThread = new Thread(ListenForData);
            listenThread.Start();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1 .Visible = true;  
            try
            {
                string message = "UPDATE";

                SendJsonCommand(modeSelection, message, "NOMOVE", 0, 0, 0);

               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "UPDATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ///****** BURADAKİ KOD DENENCEK ******////


            btnStop.Click += new EventHandler(btnStop_Click);

            radiobtnManuel.Checked = true;
            listBox1.SelectedIndex = 2;
            listBox2.SelectedIndex = 0;
            listBox3.SelectedIndex = 2;

            lblObstacle.Text = "";
        }






        string modeSelection;

        private void btnForward_Click(object sender, EventArgs e)
        {
            
            try
            {
                string message = "FORWARD";
                label2.Text = message;
                SendJsonCommand(modeSelection,"UPDATE", message, speedValue, 8, 0);
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "FORWARD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            
            try
            {
                string message = "BACKWARD";
                label2.Text = message;
                SendJsonCommand(modeSelection, "UPDATE", message, speedValue, 8, 0);
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "BACKWARD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
           
            try
            {
                string message = "STOP";
                label2.Text = message;
                SendJsonCommand(modeSelection, "UPDATE", message, 0, 0, 0);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "STOP ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                string message = "LEFT";
                label2.Text = message;
                SendJsonCommand(modeSelection, "UPDATE", message, speedValue, 0, 100);
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "LEFT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            
            try
            {
                string message = "RIGHT";
                label2.Text = message;
                SendJsonCommand(modeSelection, "UPDATE", message, speedValue, 0, 100);

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "RIGHT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            lblObstacle.Text = "";
           
            try
            {
                int listbox3_value = Convert.ToInt32(listBox3.SelectedItem.ToString());
                if (listbox3_value < 0)
                {
                    string message = "LEFT";
                    label2.Text = message;
                    SendJsonCommand(modeSelection, "UPDATE", message, 40, target_distance, Math.Abs(target_angle));
                    if (target_distance > 0)
                    {
                        string secondmessage = "FORWARD";
                        label2.Text = secondmessage;
                        SendJsonCommand(modeSelection, "UPDATE", secondmessage, speedValue, target_distance, 0);
                    }
                    else
                    {
                        string thirdmessage = "STOP";
                        label2.Text = thirdmessage;
                        SendJsonCommand(modeSelection, "UPDATE", thirdmessage, speedValue, target_distance, 0);
                    }
                }
                else if (listbox3_value > 0)
                {
                    string message = "RIGHT";
                    label2.Text = message;
                    SendJsonCommand(modeSelection, "UPDATE", message, 40, target_distance, Math.Abs(target_angle));
                }
                else if (listbox3_value == 0)
                {
                    string message = "FORWARD";
                    label2.Text = message;
                    SendJsonCommand(modeSelection, "UPDATE", message, speedValue, target_distance, Math.Abs(target_angle));

                }
                else
                {
                    string message = "STOP";
                    label2.Text = message;
                    SendJsonCommand(modeSelection, "UPDATE", message, speedValue, target_distance, Math.Abs(target_angle));
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AUTO ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void f1(string sensorAdi)
        {
            lblObstacle.Invoke((MethodInvoker)(() => lblObstacle.Text = sensorAdi));
        }
        void f2(string value_1)
        {
           // lblTemperature.Invoke((MethodInvoker)(() => lblTemperature.Text = value_1));

        }
        void f3(string value_2)
        {
           // lblHumidity.Invoke((MethodInvoker)(() => lblHumidity.Text = value_2));

        }
        void f4(string value_3)
        {
            //label4.Invoke((MethodInvoker)(() => label4.Text = value_3));

        }
        void f5(string value_4)
        {
            label10.Invoke((MethodInvoker)(() => label10.Text = value_4));

        }
        void f6(string value_5)
        {
            //label15.Invoke((MethodInvoker)(() => label15.Text = value_5));

        }
        void f7(string obstacle)
        {
            lblObstacle.Invoke((MethodInvoker)(() => lblObstacle.Text = obstacle));

        }
        private void ListenForData()
        {
            try
            {
                

                byte[] receive = client.Receive(ref ip);

                string jsonData = Encoding.UTF8.GetString(receive);
           


                //byte[] receiveBytes = client.Receive(ref ip);
                //string receiveString = Encoding.ASCII.GetString(receiveBytes);

                //Invoke(new Action(() => f7(receiveString.ToString())));


                SensorData sensorData = JsonConvert.DeserializeObject<SensorData>(jsonData);
                
                Invoke(new Action(() => f5(sensorData.cpuTemperature.ToString())));
                //if (sensorData.amb_Temperature != 0)
                //{
                //    Invoke(new Action(() => f2(sensorData.amb_Temperature.ToString())));
                //}
                //if (sensorData.amb_Humidity != 0)
                //{
                //    Invoke(new Action(() => f3(sensorData.amb_Humidity.ToString())));
                //}
                
                

                // Invoke(new Action(() => f1(sensorData.obsMessage.ToString())));
                if (sensorData.obsMessage == "An obstacle has been detected")
                
                {

                    Invoke(new Action(() => f1("An obstacle has been detected, the halt mechanism activated! Waiting for a new command..")));
                   
                }
                
                //Invoke(new Action(() => f1(sensorData.encoder.ToString())));
                
                //Invoke(new Action(() => f4(sensorData.ultrasonic3.ToString())));
                //Invoke(new Action(() => f5(sensorData.cpuTemperature.ToString())));
                //Invoke(new Action(() => f6(sensorData.randomValue.ToString())));





                Array.Clear(receive, 0, receive.Length);
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           button1.PerformClick();
        }


       
        private void SendJsonCommand(string modedataInfo,string updatedataInfo, string movementdataInfo, int speedDataInfo, int distanceDataInfo, int turnsDataInfo)
        {
            RoverCommand command = new RoverCommand
            {
                Mode_Data = modedataInfo,
                Update_Data = updatedataInfo,
                Movement_Data = movementdataInfo,
                Speed_Data = speedDataInfo,
                Distance_Data = distanceDataInfo,
                Turns_Data = turnsDataInfo
            };

            string json = JsonConvert.SerializeObject(command);
            byte[] data = Encoding.UTF8.GetBytes(json);
            client.Send(data, data.Length, ip);
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //axWindowsMediaPlayer1.URL = "http://192.168.137.160:2222";
        //    axWindowsMediaPlayer1.URL = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4";
        //    axWindowsMediaPlayer1.Ctlcontrols.play();
            
        //}


 

        private void radiobtnManuel_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnManuel.Checked == true)
            {
                modeSelection = "MANUEL";
                label1.Text = modeSelection;
                btnGO.Visible = false;
                btnGO.Enabled = false;
                btnForward.Visible = true;
                btnForward.Enabled = true;
                btnBackward.Visible = true;
                btnBackward.Enabled = true;
                btnStop.Visible = true;
                btnStop.Enabled = true;
                btnLeft.Visible = true;
                btnLeft.Enabled = true;
                btnRight.Visible = true;
                btnRight.Enabled = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label13.Visible = false;
                label16.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                lblObstacle.Visible = false;

            }
            else if (radiobtnAuto.Checked == true)
            {
                modeSelection = "AUTO";
                label1.Text = modeSelection;
                btnGO.Visible = true;
                btnGO.Enabled = true;
                btnForward.Visible = false;
                btnForward.Enabled = false;
                btnBackward.Visible = false;
                btnBackward.Enabled = false;
                btnStop.Visible = false;
                btnStop.Enabled = false;
                btnLeft.Visible = false;
                btnLeft.Enabled = false;
                btnRight.Visible = false;
                btnRight.Enabled = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label13.Visible = true;
                label16.Visible = true;
                listBox2.Visible = true;
                listBox3.Visible = true;
                lblObstacle.Visible = true;
            }
        }

        int speedValue;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    speedValue = 30;
                    label15.Text = listBox1.SelectedItem.ToString();
                    break;
                case 1:
                    speedValue = 40;
                    label15.Text = listBox1.SelectedItem.ToString();
                    break;
                case 2:
                    speedValue = 50;
                    label15.Text = listBox1.SelectedItem.ToString();
                    break;
                case 3:
                    speedValue = 60;
                    label15.Text = listBox1.SelectedItem.ToString();
                    break;
                case 4:
                    speedValue = 70;
                    label15.Text = listBox1.SelectedItem.ToString();
                    break;
                default:
                    speedValue = 50;
                    label15.Text = listBox1.SelectedItem.ToString();
                    break;
            }
        }

        int target_distance;
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    target_distance = Convert.ToInt32(listBox2.SelectedItem);
                    target_distance = 0;
                    label3.Text = listBox2.SelectedItem.ToString();
                    break;
                case 1:
                    target_distance = Convert.ToInt32(listBox2.SelectedItem);
                    target_distance = 2;
                    label3.Text = listBox2.SelectedItem.ToString();
                    break;
                case 2:
                    target_distance = Convert.ToInt32(listBox2.SelectedItem);
                    target_distance = 4;
                    label3.Text = listBox2.SelectedItem.ToString();
                    break;
                case 3:
                    target_distance = Convert.ToInt32(listBox2.SelectedItem);
                    target_distance = 7;
                    label3.Text = listBox2.SelectedItem.ToString();
                    break;
                case 4:
                    target_distance = Convert.ToInt32(listBox2.SelectedItem);
                    target_distance = 9;
                    label3.Text = listBox2.SelectedItem.ToString();
                    break;
                default:
                    target_distance = Convert.ToInt32(listBox2.SelectedItem);
                    target_distance = 0;
                    label3.Text = listBox2.SelectedItem.ToString();
                    break;
            }
        }
        int target_angle;
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox3.SelectedIndex)
            {
                case 0:
                    target_angle = Convert.ToInt32(listBox3.SelectedItem);
                    label4.Text = listBox3.SelectedItem.ToString();
                    break;
                case 1:
                    target_angle = Convert.ToInt32(listBox3.SelectedItem);
                    label4.Text = listBox3.SelectedItem.ToString();
                    break;
                case 2:
                    target_angle = Convert.ToInt32(listBox3.SelectedItem);
                    label4.Text = listBox3.SelectedItem.ToString();
                    break;
                case 3:
                    target_angle = Convert.ToInt32(listBox3.SelectedItem);
                    label4.Text = listBox3.SelectedItem.ToString();
                    break;
                case 4:
                    target_angle = Convert.ToInt32(listBox3.SelectedItem);
                    label4.Text = listBox3.SelectedItem.ToString();
                    break;
                default:
                    target_angle = Convert.ToInt32(listBox3.SelectedItem);
                    label4.Text = listBox3.SelectedItem.ToString();
                    break;
            }
        }
   

        //###################################################################################################################################
        //###################################################################################################################################
        //##################                                    KEYBOARD CONTROL                                        #####################
        //###################################################################################################################################
        //###################################################################################################################################

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (modeSelection == "MANUEL")
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        string W = "FORWARD";
                        label2.Text = W;
                        SendJsonCommand(modeSelection, "UPDATE", W, speedValue, 1, 0);
                        break;
                    case Keys.S:
                        string S = "BACKWARD";
                        label2.Text = S;
                        SendJsonCommand(modeSelection, "UPDATE", S, speedValue, 1, 0);
                        break;
                    case Keys.A:
                        string A = "LEFT";
                        label2.Text = A;
                        SendJsonCommand(modeSelection, "UPDATE", A, speedValue, 0, 100);
                        break;
                    case Keys.D:
                        string D = "RIGHT";
                        label2.Text = D;
                        SendJsonCommand(modeSelection, "UPDATE", D, speedValue, 0, 100);
                        break;
                }
            }
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.S:
                case Keys.A:
                case Keys.D:
                    string stop = "STOP";
                    label2.Text = stop;
                    SendJsonCommand(modeSelection, "UPDATE", stop, 0, 0, 0);
                    break;
            }
        }

        private void radiobtnAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
    //public class SensorData
    //{
    //    public int encoder { get; set; }
    //    public int ultrasonic1 { get; set; }
    //    public int ultrasonic2 { get; set; }
    //    public int ultrasonic3 { get; set; }
    //    public int cpuTemperature { get; set; }
    //    public int randomValue {  get; set; } 
    //}

    public class SensorData
    {
        public int cpuTemperature { get; set; }
        public string obsMessage { get; set; }
    }
    public class RoverCommand
    {
        public string Mode_Data { get; set; }
        public string Update_Data { get; set; }
        public string Movement_Data { get; set; }
        public int Speed_Data { get; set; }
        public int Distance_Data { get; set; }
        public int Turns_Data { get; set; }
    }
}
