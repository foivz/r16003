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
    public partial class CitanjePorukeForm : Form
    {
        string usernamePrimatelja;
        public CitanjePorukeForm(string username)
        {
            InitializeComponent();
            usernamePrimatelja = username;
        }

        private void CitanjePorukeForm_Load(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("DOHVATIKLIJENTE");
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera());
            foreach (var item in porukaOdServera.Split(';'))
            {
                cmbKlijenti.Items.Add(item);
            }
            
        }

        private void cmbKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("CITANJEPORUKE," + cmbKlijenti.Text + "," + usernamePrimatelja);
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera());
            dgwCitanjePoruke.Rows.Clear();
            foreach (var item in porukaOdServera.Split(';'))
            {
                dgwCitanjePoruke.Rows.Add(item);
            }
        }
    }
}
