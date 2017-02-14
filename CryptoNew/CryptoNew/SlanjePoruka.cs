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
    /// Klasa koja predstavlja formu za slanje poruke
    /// </summary>
    public partial class SlanjePoruka : Form
    {
        Form1 glavnaForma;
        Korisnik prijavljeniKorisnik;
        TcpKlijent klijent;
        ListaKorisnika novaLista;

        /// <summary>
        /// Konstruktor forme SlanjePoruka - prilikom inicijalizacije forme dohvaća se lista korisnika aplikacije
        /// </summary>
        /// <param name="glavna"></param>
        /// <param name="korisnik"></param>
        public SlanjePoruka(Form1 glavna, Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = glavna;
            prijavljeniKorisnik = korisnik;

            klijent = new TcpKlijent();
            novaLista = new ListaKorisnika();
            klijent.PosaljiServeru(novaLista, "DohvatiKorisnike");
            novaLista = (ListaKorisnika)klijent.PrimiOdServera();
            odabirUsername.DataSource = novaLista.IzdvojiKorisnickaImena();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler koji se aktivira prilikom klika na gumb Enkriptiraj i Pošalji. Poruci se pridružuje primatelj, pošiljatelj
        /// te datum slanja zajedno sa sadrzajem. Sa pomoću javnoga ključa formira se enkripcijski paket poruke te se takva poruka šalje
        /// prema serveru. Čeka se odgovor servera koji predstavlja Uspjeh Slanja Poruke - je li poruka poslana ili nije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbPosalji_Click(object sender, EventArgs e)
        {
            string sadrzaj;
            string javniKljuc;
            klijent = new TcpKlijent();
            Poruka novaPoruka = new Poruka();
            UspjehSlanjaPoruke uspjeh;

            novaPoruka.Posiljatelj = prijavljeniKorisnik.Username;
            novaPoruka.Primatelj = odabirUsername.Text;
            novaPoruka.DatumSlanja = DateTime.Now;
            sadrzaj = unosSadrzaj.Text;
            javniKljuc = novaLista.Korisnici.Where(i => i.Username == novaPoruka.Primatelj).Select(p => p.JavniKljuc).First();
            novaPoruka.FormirajEnkripcijskiPaket(sadrzaj, javniKljuc);

            klijent.PosaljiServeru(novaPoruka, "PosaljiPoruku");
            uspjeh = (UspjehSlanjaPoruke)klijent.PrimiOdServera();
            if (uspjeh.PorukaPoslana == "DA")
            {
                prikazLog.Text += "Vrijeme: " + DateTime.Now.ToString() + " - Poruka poslana" + Environment.NewLine;
            }
            else
            {
                prikazLog.Text += "Vrijeme: " + DateTime.Now.ToString() + " - Poruka nije poslana" + Environment.NewLine;
            }
        }
    }
}
