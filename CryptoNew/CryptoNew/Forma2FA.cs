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
    /// <summary>
    /// Forma za unos 2fa koda
    /// </summary>
    public partial class Forma2FA : Form
    {
        Korisnik poslanoKorisnik;
        Korisnik primljenoKorisnik;

        Form1 glavnaForma;
        /// <summary>
        /// Konstruktor forme za unos 2fa kljuca, prima 2 objekta, jedan radi dohvacanja imena korisnika koji je prethodno poslan
        /// na server te objekt glavne forme kako bi bio omogućen povratak na nju.
        /// </summary>
        /// <param name="korisnik"></param>
        /// <param name="glavna"></param>
        public Forma2FA(Korisnik korisnik, Form1 glavna)
        {
            InitializeComponent();
            poslanoKorisnik = korisnik;
            glavnaForma = glavna;
        }

        /// <summary>
        /// Event Handler koji se kativira klikom na gumb posalji, tj šalje se 2fa kod (koji je
        /// prethodno stigao na mobilni telefon) putem forme prema serveru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
