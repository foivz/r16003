using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNew
{
    public partial class Forma2FA : Form
    {
        Korisnik poslanoKorisnik;
        Korisnik primljenoKorisnik;

        Form1 glavnaForma;
        public Forma2FA(Korisnik korisnik, Form1 glavna)
        {
            InitializeComponent();
            poslanoKorisnik = korisnik;
            glavnaForma = glavna;
        }

        private void gumbPosalji_Click(object sender, EventArgs e)
        {
            poslanoKorisnik.Kljuc2FA = unosKod.Text;
            TcpKlijent klijent = new TcpKlijent();
            klijent.PosaljiServeru(poslanoKorisnik, "Potvrda2FA");
            primljenoKorisnik = (Korisnik)klijent.PrimiOdServera();
            if (primljenoKorisnik.Username == null)
            {
                MessageBox.Show("Niste unijeli ispravni 2FA Kod. Pokušajte ponovno!");
            }
            else
            {
                glavnaForma.NotifyMe(primljenoKorisnik);
            }
        }
    }
}
