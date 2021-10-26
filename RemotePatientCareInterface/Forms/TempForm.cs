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
    }
}
