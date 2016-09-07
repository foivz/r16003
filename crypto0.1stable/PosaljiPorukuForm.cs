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
    public partial class PosaljiPorukuForm : Form
    {
        string posiljatelj;
        string primatelj;
        public PosaljiPorukuForm(string username)
        {
            InitializeComponent();
            posiljatelj = username;
        }

        public PosaljiPorukuForm(string username, string primatelj)
        {
            InitializeComponent();
            posiljatelj = username;
            this.primatelj = primatelj;
        }

        private void btnSlanjePoruke_Click(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            try
            {
                poruka = Encoding.ASCII.GetBytes("C2C," + posiljatelj + "," + txtPrimatelj.Text + "," + EncryptionHelper.CaesarStringEncrypt(txtSlanjePoruke.Text, int.Parse(textBox1.Text)) + ",");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            tcpKlijent.PosaljiServeru(poruka);
            byte[] primitak = tcpKlijent.PrimiOdServera();
            if (primitak != null)
            {
                string odgovorOdServera = Encoding.ASCII.GetString(primitak);
                MessageBox.Show(odgovorOdServera);
            }
        }

        private void PosaljiPorukuForm_Load(object sender, EventArgs e)
        {
            if (primatelj != null) txtPrimatelj.Text = primatelj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPrimatelj.Text != null)
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string poslati = txtPrimatelj.Text + "," + openFileDialog1.FileName;
                    Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Loopback, 11000); //ovdje staviti trenutni IP servera!
                    client.Connect(ipEndpoint);
                    using (StreamWriter sw = File.AppendText(openFileDialog1.FileName))
                    {
                        sw.WriteLine("\n" + poslati);
                    }
                    client.SendFile(openFileDialog1.FileName);
                    client.Close();
                }
                else
                {
                    txtPrimatelj.Text = "Niste unijeli primatelja";
                }
            }
        }
    }
}
