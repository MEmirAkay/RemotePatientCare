using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace RemotePatientCareInterface.Forms
{
    public partial class TempForm : Form
    {
        

        public TempForm()
        {
            InitializeComponent();
            
            
            timer1.Start();
        }

        int On_Off = 0;
        private void TempForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TempLevel_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {    
            
        }

        static string Connect(String server, String message)
        {
           
            Int32 port = 1234;
            TcpClient client = new TcpClient(server, port);

            Byte[] data = Encoding.ASCII.GetBytes(message);

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent: {0}", message);

            data = new Byte[1024];

            String responseData = String.Empty;

            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Received: {0}", responseData);

            string TempRes = responseData;


            stream.Close();
            client.Close();

            return TempRes;
           

        }

        private void SensorChanges()
        {
            string day1 = DateTime.Now.ToString("fff");
            day1 = day1.Remove(1);
            Console.WriteLine(day1);
            if (day1 == "1")
            {
                string tempResponse = Connect("192.168.1.124", "temp");

                if (tempResponse != "None")
                {
                    float tempResp = float.Parse(tempResponse);
                    int tempResp1 = (int)tempResp/10;

                    Console.WriteLine(tempResp);
                    Console.WriteLine(tempResp1);


                    TempratureText.Text = tempResponse;

                    TempLevel.Height = 500 - (tempResp1 * 10);



                }

                

            }
            
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           SensorChanges();
        }

        private void TempLevel_Click(object sender, EventArgs e)
        {

        }


        private void HeaterOnOff(int HeatDecide)
        {
            timer1.Stop();
            if (HeatDecide == 1)
            {
                Console.WriteLine("Starting to Heat");
                Connect("192.168.1.124", "heatON");

            }
            else if (HeatDecide == 2)
            {
                Console.WriteLine("Stopping to heat");
                Connect("192.168.1.124", "heatOFF");

            }
            timer1.Start();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (On_Off == 0)
            {
                HeaterOnOff(1);
                On_Off++;
                Console.WriteLine(On_Off);
            }
            else
            {
                HeaterOnOff(2);
                On_Off = 0;
                Console.WriteLine(On_Off);
            }
        }

        //Fan
        private void FanCnt(int fanControl)
        {
            timer1.Stop();
            if (fanControl == 0)
            {                
                Console.WriteLine("Fan level LOW");
                Connect("192.168.1.124", "FanLow");
            }
            else if (fanControl == 1)
            {               
                Console.WriteLine("Fan level Medium");
                Connect("192.168.1.124", "FanMed");
            }
            else if (fanControl == 2)
            {             
                Console.WriteLine("Fan level High");
                Connect("192.168.1.124", "FanHigh");
            }
            else if (fanControl == 3)
            {
                Console.WriteLine("Fan Stopped");
                Connect("192.168.1.124", "FanOff");
            }
            timer1.Start();
        }

       

        private void FanOFF_Click(object sender, EventArgs e)
        {
            FanCnt(3);
        }

        private void FanHigh_Click(object sender, EventArgs e)
        {
            FanCnt(2);
        }

        private void FanMed_Click(object sender, EventArgs e)
        {
            FanCnt(1);
        }

        private void FanLow_Click(object sender, EventArgs e)
        {
            FanCnt(0);
        }
    }
}
