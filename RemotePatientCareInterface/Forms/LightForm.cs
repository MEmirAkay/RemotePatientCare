using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemotePatientCareInterface.Forms
{
    public partial class LightForm : Form
    {
        public LightForm()
        {
            InitializeComponent();
            timer1.Start();
            
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
                string lightResponse = Connect("192.168.1.124", "light");

                if (lightResponse != "None")
                {
                    float lightResp = float.Parse(lightResponse);
                    int lightResp1 = (int)lightResp / 10;

                    Console.WriteLine(lightResp);
                    Console.WriteLine(lightResp1);

                    LightText.Text = lightResponse;

                    LightLevel.Height = 500 - (lightResp1 * 10);

                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SensorChanges();
        }

        private void LightCnt(int lightControl)
        {
            timer1.Stop();
            if (lightControl == 0)
            {
                LightIntenstyStatus.Text = "Low";
                Console.WriteLine("Light level 0");
                Connect("192.168.1.124", "LightLvL_0");

            }
            else if (lightControl == 1)
            {
                LightIntenstyStatus.Text = "Medium";
                Console.WriteLine("Light level 1");
                Connect("192.168.1.124", "LightLvL_1");

            }
            else if (lightControl == 2)
            {
                LightIntenstyStatus.Text = "High";
                Console.WriteLine("Light level 2");
                Connect("192.168.1.124", "LightLvL_2");


            }
            else if (lightControl == 3)
            {
                LightIntenstyStatus.Text = "Max";
                Console.WriteLine("Light level 3");
                Connect("192.168.1.124", "LightLvL_3");


            }
            timer1.Start();
        }



        int LightControl = 0;
        /*  0 = Low       / 3,3 V
         *  1 = Medium    / 5   V
         *  2 = High      / 8,3 V
         *  3 = Max       / 10  V
         */

        private void UpLightIntensty_Click(object sender, EventArgs e)
        {
            LightControl++;
            LightCnt(LightControl);
        }

        private void DownLightIntensty_Click(object sender, EventArgs e)
        {
            LightControl--;
            LightCnt(LightControl);
        }
    }
}
