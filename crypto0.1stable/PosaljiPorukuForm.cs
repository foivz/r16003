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
        public PosaljiPorukuForm()
        {
            InitializeComponent();
        }

        private void btnSlanjePoruke_Click(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("");
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera());
        }
    }
}
