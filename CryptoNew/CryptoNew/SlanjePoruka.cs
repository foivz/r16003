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
    public partial class SlanjePoruka : Form
    {
        Form1 glavnaForma;
        Korisnik prijavljeniKorisnik;
        TcpKlijent klijent;
        ListaKorisnika novaLista;
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
