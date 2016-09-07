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
    public partial class twoFactorAuthentificationForm : Form
    {
        //Timer t = new Timer();
        string kljuc;
        string poruka;
        string username;
        public twoFactorAuthentificationForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void twoFactorAuthentificationForm_Load(object sender, EventArgs e)
        {
            lblProvjera.Text = "Provjeravam 2fa ključ";
            kljuc = System.IO.File.ReadAllText(@"F:\twoFactor.txt");
            poruka = "PROVJERIKLJUC," + username;
            TcpKlijent klijent = new TcpKlijent();
            byte[] bytePoruka = Encoding.ASCII.GetBytes(poruka);
            klijent.PosaljiServeru(bytePoruka);
            string odgovorODServera = Encoding.ASCII.GetString(klijent.PrimiOdServera());
            odgovorODServera = odgovorODServera.Remove(5);
            klijent.ZatvoriSocket();
            if(kljuc == odgovorODServera)
            {
                MessageBox.Show("2fa kljuc je dobar, mozete nastaviti s radom!");
                this.Close();
            }
            else
            {
                MessageBox.Show("2fa kljuc nije tocan ili ga nema!");
                this.Close();
            }
        }
    }
}
