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
                string numericString = string.Empty;

                foreach (var c in lightResponse)
                {
                    
                    if ((c >= '0' && c <= '9') || (char.ToUpperInvariant(c) >= 'A' && char.ToUpperInvariant(c) <= 'F') || c == ' ')
                    {
                        numericString = string.Concat(numericString, c.ToString());
                    }
                    else
                    {
                        break;
                    }
                }

                if (lightResponse != "None")
                {
                    float lightResp = float.Parse(numericString);
                    lightResp = Convert.ToInt64(lightResp);

                    if (lightResp >= 100)
                        {
                            lightResponse = lightResponse.Remove(3);
                            
                        }
                        else if (lightResp < 10)
                        {
                            lightResponse = lightResponse.Remove(1);
                        }
                        else if (lightResp >= 10)
                        {
                            lightResponse = lightResponse.Remove(2);
                        }

                    LightText.Text = lightResponse;
                    LightLevel.Height =  500 - (int)lightResp * 5;
                          
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
                LightIntenstyStatus.Text = "Off";
                Console.WriteLine("Light Off");
                Connect("192.168.1.124", "LightOff");
                LightPicture.IconColor = Color.Black;

            }
            else if (lightControl == 1)
            {
                LightIntenstyStatus.Text = "Low";
                Console.WriteLine("Light Low");
                Connect("192.168.1.124", "LightLow");
                LightPicture.IconColor = Color.Aqua;
            }
            else if (lightControl == 2)
            {
                LightIntenstyStatus.Text = "Medium";
                Console.WriteLine("Light Medium");
                Connect("192.168.1.124", "LightMed");
                LightPicture.IconColor = Color.LimeGreen;
            }
            else if(LightControl == 3)
            {
                LightIntenstyStatus.Text = "High";
                Console.WriteLine("Light High");
                Connect("192.168.1.124", "LightHigh");
                LightPicture.IconColor = Color.Red;
            }            
            
            timer1.Start();
        }



        int LightControl = 0;
        /*  0 = Close       
         *  1 = Low    
         *  2 = Medium
         *  3 = High
         */

      
        private void UpLightIntensty_Click(object sender, EventArgs e)
        {
            if (LightControl < 3)
            {
                LightControl++;
                LightCnt(LightControl);
                
            }
            
        }

        private void DownLightIntensty_Click(object sender, EventArgs e)
        {
            if(LightControl > 0)
            {
                LightControl--;
                LightCnt(LightControl);
            }
            
        }

        private void OnLamp_Click(object sender, EventArgs e)
        {
            if(LightControl == 0)
            {
                LightControl = 2;
                LightCnt(LightControl);
            }
            else if(LightControl != 0)
            {
                LightControl = 0;
                LightCnt(LightControl);
            }
        }

        private void LightLevel_Click(object sender, EventArgs e)
        {

        }

        private void LightPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
