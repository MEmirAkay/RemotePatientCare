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
using CefSharp;
using CefSharp.WinForms;

namespace RemotePatientCareInterface.Forms
{
    
    public partial class MotionForm : Form
    {
        

        public ChromiumWebBrowser chromeBrowser;
        public MotionForm()
        {
            
            InitializeComponent();
           
            
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


        private void InitilizeChromium()
        {
            
            chromeBrowser = new ChromiumWebBrowser("http://localhost:8090");

            this.panel1.Controls.Add(chromeBrowser);

            chromeBrowser.Dock = DockStyle.Fill;
            
        }

        private void GetCamera_Click(object sender, EventArgs e)
        {
            InitilizeChromium();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            string Speach = "SPC" +WillConvSpeach.Text;

            Connect("192.168.1.124",Speach);

        }
    }
}
