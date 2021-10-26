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
    public partial class SerumForm : Form
    {
        public SerumForm()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void SensorChanges2()
        {
            string day2 = DateTime.Now.ToString("fff");
            day2 = day2.Remove(1);
            Console.WriteLine(day2);
            if (day2 == "1")
            {
                string serResponse = Connect("192.168.1.124", "serum");

                if (serResponse != "asdasd")
                {
                    serResponse = serResponse.Remove(2);
                    float serResp = float.Parse(serResponse);
                    int serResp1 = (int)serResp;

                    Console.WriteLine(serResp);
                    Console.WriteLine(serResp1);
                    Console.WriteLine("-----------");
                    
                    serResp1 = serResp1 * 25;
                    Console.WriteLine(serResp1);
                    SerumLevel.Height = serResp1;



                }



            }



        }

        private void SerumLoadFull_Click(object sender, EventArgs e)
        {
            //SerumLevel.Height = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SensorChanges2();
        }

    }
}
