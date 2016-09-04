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
    public partial class RegistracijskaForma : Form
    {
        public RegistracijskaForma()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != null && txtSifra.Text != null && txtMail.Text != null && dtDatum.Value != null)
            {
                TcpKlijent tcpKlijent = new TcpKlijent();
                byte[] poruka = new byte[1024];
                poruka = Encoding.ASCII.GetBytes("REGISTER," + txtUser.Text + "," + txtSifra.Text + "," + txtMail.Text + "," + dtDatum.Value.Date.ToString("yyyyMMdd") + ",");
                tcpKlijent.PosaljiServeru(poruka);
                byte[] primitak = tcpKlijent.PrimiOdServera();
                if (primitak != null)
                {
                    string odgovorOdServera = Encoding.ASCII.GetString(primitak);
                    MessageBox.Show(odgovorOdServera);
                }
                tcpKlijent.ZatvoriSocket();
            }
            else Console.WriteLine("Nisu uneseni svi podaci, pokušajte ponovi!");
        }
    }
}
