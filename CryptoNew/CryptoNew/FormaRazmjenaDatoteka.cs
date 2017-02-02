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

        private void DodajGumbe()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            prikazDatoteke.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Skini";
            btn.Name = "gumbSkini";
            btn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            prikazDatoteke.Columns.Add(btn2);
            btn2.HeaderText = "";
            btn2.Text = "Izbriši";
            btn2.Name = "gumbIzbrisi";
            btn2.UseColumnTextForButtonValue = true;
        }

        private void IspisLoga(int status)
        {
            string vrijeme = DateTime.Now.ToString();
            if (status == 1)
            {
                prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka Poslana!" + Environment.NewLine;
            }
            else if (status == 2)
            {
                prikazLog.Text += $"- Vrijeme: {vrijeme} - Neuspješno slanje!" + Environment.NewLine;
            }
            else
            {
                prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka se šalje!" + Environment.NewLine;
            }
        }

        private void DohvatiKorisnike()
        {
            listaKorisnika = new ListaKorisnika();
            klijent = new TcpKlijent();
            klijent.PosaljiServeru(listaKorisnika, "DohvatiKorisnike");
            listaKorisnika = (ListaKorisnika)klijent.PrimiOdServera();
            odabirKorisnik.DataSource = listaKorisnika.IzdvojiKorisnickaImena();
            odabirKorisnik.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public FormaRazmjenaDatoteka(Form1 glavna, Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = glavna;
            prijavljeniKorisnik = korisnik;
            DodajGumbe();
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

        private async void gumbPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                IspisLoga(0);
                DropboxManager novo = new DropboxManager();
                int result = await novo.Upload(fileName, prijavljeniKorisnik.Username, odabirKorisnik.SelectedItem.ToString());
                if (result == 1)
                {
                    IspisLoga(1);
                }
            }
            catch
            {
                IspisLoga(2);
            }
        }

        private async void tabKontrola_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabKontrola.SelectedIndex == 1)
            {
                DropboxManager novo = new DropboxManager();
                List<Datoteka> listaDatoteka = await novo.ListRootFolder(prijavljeniKorisnik.Username, listaKorisnika.Korisnici);
                prikazDatoteke.DataSource = listaDatoteka;
                prikazDatoteke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                //prikazDatoteke.Columns[prikazDatoteke.Columns.Count-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
