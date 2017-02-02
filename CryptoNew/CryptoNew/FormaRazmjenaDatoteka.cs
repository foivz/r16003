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
    public partial class FormaRazmjenaDatoteka : Form
    {
        Form1 glavnaForma;
        Korisnik prijavljeniKorisnik;
        ListaKorisnika listaKorisnika;
        TcpKlijent klijent;
        string fileName;

        private void IspisLoga(int status)
        {
            string vrijeme = DateTime.Now.ToString();
            if (status == 1)
            {
                prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka Poslana!" + Environment.NewLine;
            }
            else
            {
                prikazLog.Text += $"- Vrijeme: {vrijeme} - Neuspješno slanje!" + Environment.NewLine;
            }
        }

        private void DohvatiKorisnike()
        {
            listaKorisnika = new ListaKorisnika();
            klijent = new TcpKlijent();
            klijent.PosaljiServeru(listaKorisnika, "DohvatiKorisnike");
            listaKorisnika = (ListaKorisnika)klijent.PrimiOdServera();
            odabirKorisnik.DataSource = listaKorisnika.IzdvojiKorisnickaImena();
        }

        public FormaRazmjenaDatoteka(Form1 glavna, Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = glavna;
            prijavljeniKorisnik = korisnik;

            DohvatiKorisnike();
        }

        private void gumbTrazi_Click(object sender, EventArgs e)
        {
            OpenFileDialog traziDatoteku = new OpenFileDialog();
            if (traziDatoteku.ShowDialog() == DialogResult.OK)
            {
                fileName = traziDatoteku.FileName;
                unosDatoteka.Text = fileName;
                gumbPosalji.Enabled = true;
            }
        }

        private void gumbPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                DropboxManager novo = new DropboxManager();
                novo.Upload(fileName, prijavljeniKorisnik.Username, odabirKorisnik.SelectedItem.ToString());
                IspisLoga(1);
            }
            catch
            {
                IspisLoga(0);
            }
        }
    }
}
