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
        public PosaljiPorukuForm(string username)
        {
            InitializeComponent();
            posiljatelj = username;
        }

        private void btnSlanjePoruke_Click(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("C2C," + posiljatelj + "," + txtPrimatelj.Text + "," + txtSlanjePoruke.Text + ",");
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera());
        }
    }
}
