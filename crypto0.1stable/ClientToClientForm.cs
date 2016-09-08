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
    public partial class ClientToClientForm : Form
    {
        string username;
        public ClientToClientForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form citajC2CPoruke = new CitanjePorukeForm(username);
            citajC2CPoruke.Show();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            Form saljiC2CPoruku = new PosaljiPorukuForm(username);
            saljiC2CPoruku.Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            Form filePoruka = new FilePoruka(username);
                var listener = new TcpListener(IPAddress.Loopback, 40123);
                listener.Start();
                
                var client = listener.AcceptTcpClient();
                var stream = client.GetStream();
                using (var output = File.Create(@"E:\datoteka" +".txt"))
                {
                    var buffer = new byte[1024];
                    int bytesRead = 0;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                    output.Close();
                    listener.Stop();
                }
                }
            }
        }

