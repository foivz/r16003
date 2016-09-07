using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto0._1stable
{
    public partial class filePoruka : Form
    {
        private string username;

        public filePoruka()
        {
            InitializeComponent();
            
        }

        public filePoruka(string username)
        {
            this.username = username;
        }

        private void filePoruka_Load(object sender, EventArgs e)
        {
            TcpClient client1 = new TcpClient("127.0.0.1", 12000);
            NetworkStream nwStream = client1.GetStream();
            byte[] bytesToSend = Encoding.ASCII.GetBytes(username);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            client1.Close();


            
            Task t = Task.Run(() =>
           {
               var listener = new TcpListener(IPAddress.Loopback, 11000);
               listener.Start();
               while (true)
               {
                   var client = new TcpClient();
                   var stream = client.GetStream();
                   var output = File.Create(@"C:\datoteka.txt");
                   {
                       var buffer = new byte[1024];
                       int bytesRead;
                       while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                       {
                           output.Write(buffer, 0, bytesRead);
                       }
                       
                   }
               }
           });
        }
    }
}
