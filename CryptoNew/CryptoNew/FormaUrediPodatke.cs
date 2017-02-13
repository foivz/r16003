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
    /// Klasa koja predstavlja formu za uređivanje korisničkih podataka
    /// </summary>
    public partial class FormaUrediPodatke : Form
    {
        Korisnik prijavljeniKorisnik;

        /// <summary>
        /// Postavlja početne postavke kontroli na formi
        /// </summary>
        private void PostaviPocetnePostavke()
        {
            urediIme.Text = prijavljeniKorisnik.Ime;
            urediPrezime.Text = prijavljeniKorisnik.Prezime;
            urediEmail.Text = prijavljeniKorisnik.Email;
            urediBrojTelefona.Text = prijavljeniKorisnik.BrojTelefona.Substring(4);
        }

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        /// <param name="korisnik"></param>
        public FormaUrediPodatke(Korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
            PostaviPocetnePostavke();
        }

        /// <summary>
        /// Event handler koji šalje nove podatke prema serveru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbPosalji_Click(object sender, EventArgs e)
        {

        }
    }
}
