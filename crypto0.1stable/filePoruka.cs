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
    public partial class FilePoruka : Form
    {
        private string username;

        public FilePoruka()
        {
            InitializeComponent();

        }

        public FilePoruka(string username)
        {
            this.username = username;
            TcpClient client1 = new TcpClient("127.0.0.1", 31829);
            NetworkStream nwStream = client1.GetStream();
            byte[] bytesToSend = Encoding.ASCII.GetBytes(username);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            client1.Close();
        }

        private void filePoruka_Load(object sender, EventArgs e)
        {


        }
    }
}

