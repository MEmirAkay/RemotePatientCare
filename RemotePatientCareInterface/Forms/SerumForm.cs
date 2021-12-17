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
        int distance = 0;

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
                    
                    Console.WriteLine("Değer :" + serResp1);
                    SerumLevel.Height = 500 - serResp1;
                    distance = serResp1;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SensorChanges2();
        }

        private void FillSerum(int percent)
        {
            timer2.Stop();
            Console.WriteLine("Starting to fill");
            Connect("192.168.1.124", "SerumFill");

            if (percent == 1)
            {
                while (distance > 1)
                {
                    SensorChanges2();
                }
                Connect("192.168.1.124", "SerumStop");
            }
            else if (percent == 2)
            {
                while (distance > 5)
                {
                    SensorChanges2();
                }
                Connect("192.168.1.124", "SerumStop");
            }
            else if (percent == 3)
            {
                while (distance > 9)
                {
                    SensorChanges2();        
                }
                Connect("192.168.1.124", "SerumStop");
            }
            timer2.Start();
        }

        private void PourSerum(int Pourpercent)
        {
            timer2.Stop();
            Console.WriteLine("Starting to Pour");
            Connect("192.168.1.124", "SerumPour");

            if (Pourpercent == 1)
            {
                while (distance < 2)
                {
                    SensorChanges2();
                }
                Connect("192.168.1.124", "SerumStop");

            }
            else if (Pourpercent == 2)
            {
                while (distance <= 5)
                {
                    SensorChanges2();
                }
                Connect("192.168.1.124", "SerumStop");

            }
            else if (Pourpercent == 3)
            {
                while (distance <= 9)
                {
                    SensorChanges2();
                }
                Connect("192.168.1.124", "SerumStop");
            }
            timer2.Start();
        }

        private void SerumLoadFull_Click(object sender, EventArgs e)
        {
            FillSerum(1);
        }

        

        private void SerumLoadQuarter_Click(object sender, EventArgs e)
        {
            FillSerum(3);
            
        }

        private void SerumLoadHalf_Click(object sender, EventArgs e)
        {
            FillSerum(2);
        }

        private void SerumLevel_Click(object sender, EventArgs e)
        {

        }

        private void SerumDrainQuarter_Click(object sender, EventArgs e)
        {
            PourSerum(1);
        }

        private void SerumDrainHalf_Click(object sender, EventArgs e)
        {
            PourSerum(2);
        }

        private void SerumDrainAll_Click(object sender, EventArgs e)
        {
            PourSerum(3);
        }
    }
}
