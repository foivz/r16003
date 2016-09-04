using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto0._1stable
{
    public partial class ChatForm : Form
    {
        TcpClient klijent;
        Int32 port = 6123;
        NetworkStream stream = default(NetworkStream);
        byte[] readBuffer;
        byte[] writeBuffer;
        string poruka;
        string primljenaPoruka;
        string username;
        public ChatForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            try
            {
                klijent = new TcpClient();
                klijent.Connect(IPAddress.Loopback, port);
                stream = klijent.GetStream();
                writeBuffer = new byte[1024];
                poruka = username + " je pristupio chatu!";
                writeBuffer = Encoding.ASCII.GetBytes(poruka);
                stream.Write(writeBuffer, 0, poruka.Length);
                stream.Flush();
                readBuffer = new byte[1024];
                stream.Read(readBuffer, 0, readBuffer.Length);
                stream.Flush();
                primljenaPoruka = Encoding.ASCII.GetString(readBuffer);
                msg();

                Thread dretvaZaPrimanje = new Thread(new ThreadStart(DretvaZaPrimanje));
                dretvaZaPrimanje.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ne mogu komunicirati sa chat servisom, pokusajte kasnije");
                this.Close();
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (txtUpis.Text != "")
            {
                stream = klijent.GetStream();
                poruka = username + " says: " + txtUpis.Text;
                writeBuffer = new byte[poruka.Length];
                writeBuffer = Encoding.ASCII.GetBytes(poruka);
                stream.Write(writeBuffer, 0, poruka.Length);
                stream.Flush();
            }
        }

        private void DretvaZaPrimanje()
        {
            while (true)
            {
                try
                {
                    stream = klijent.GetStream();
                    int buffSize = 0;
                    byte[] inStream = new byte[1024];
                    buffSize = klijent.ReceiveBufferSize;
                    stream.Read(inStream, 0, inStream.Length);
                    string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                    primljenaPoruka = "" + returndata;
                    msg();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Prekinuta komunikacija sa serverom, udite ponovo!");
                    break;
                }
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                txtIspis.Text = txtIspis.Text + Environment.NewLine + " >> " + primljenaPoruka;
        }
    }
}
