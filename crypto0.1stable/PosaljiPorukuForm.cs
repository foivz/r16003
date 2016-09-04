using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            poruka = Encoding.ASCII.GetBytes("C2C," + posiljatelj + "," + txtPrimatelj.Text + "," + txtSlanjePoruke.Text + ",");
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
    }
}
