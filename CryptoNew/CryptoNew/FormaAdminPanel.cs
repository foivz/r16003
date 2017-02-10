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
    public partial class FormaAdminPanel : Form
    {
        TcpKlijent klijent;
        ListaKorisnika listaKorisnika;

        public FormaAdminPanel()
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            FormirajDataGridove();
            DohvatiKorisnike();
        }

        private void DohvatiKorisnike()
        {
            klijent = new TcpKlijent();
            listaKorisnika = new ListaKorisnika();
            klijent.PosaljiServeru(listaKorisnika, "DohvatiKorisnike");
            listaKorisnika = (ListaKorisnika)klijent.PrimiOdServera();

            for (int i = 0; i < listaKorisnika.Korisnici.Count; i++)
            {
                Korisnik korisnik = listaKorisnika.Korisnici[i];
                int rowIndex = tablicaKorisnici.Rows.Add(korisnik.Username,korisnik.Ime,korisnik.Prezime,korisnik.DohvatiStatus());
            }

        }

        private void FormirajDataGridove()
        {
            tablicaKorisnici.AllowUserToAddRows = false;
            tablicaKorisnici.ReadOnly = true;
            tablicaKorisnici.Columns.Add("Username", "Username");
            tablicaKorisnici.Columns.Add("Ime", "Ime");
            tablicaKorisnici.Columns.Add("Prezime", "Prezime");
            tablicaKorisnici.Columns.Add("Status", "Status");
            tablicaKorisnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            tablicaKorisnici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
