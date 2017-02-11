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
    /// Forma koja predstavlja admin panel za admina aplikacije
    /// </summary>
    public partial class FormaAdminPanel : Form
    {
        TcpKlijent klijent;
        ListaKorisnika listaKorisnika;

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public FormaAdminPanel()
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            FormirajDataGridove();
            DohvatiKorisnike();
        }

        /// <summary>
        /// Metoda koja dohvaća korisnike i prikazuje ih u tablicki korisnika te admin može mijenjati status računa pojedinog korisnika
        /// </summary>
        private void DohvatiKorisnike()
        {
            klijent = new TcpKlijent();
            listaKorisnika = new ListaKorisnika();
            klijent.PosaljiServeru(listaKorisnika, "DohvatiKorisnike");
            listaKorisnika = (ListaKorisnika)klijent.PrimiOdServera();


            tablicaKorisnici.Rows.Clear();
            tablicaKorisnici.Refresh();
            for (int i = 0; i < listaKorisnika.Korisnici.Count; i++)
            {
                Korisnik korisnik = listaKorisnika.Korisnici[i];
                int rowIndex = tablicaKorisnici.Rows.Add(korisnik.Username,korisnik.Ime,korisnik.Prezime,korisnik.DohvatiStatus());
            }

        }

        /// <summary>
        /// Metoda koja prihvaća username i status korisnika kojem se želi promijeniti status u otključani ili zaključani račun.
        /// Šalje odgovarajuće podatke prema serveru te će se na serveru izvršiti sama promjena statusa.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="status"></param>
        private void PromijeniStatus(string username, string status)
        {
            Korisnik korisnik = new Korisnik();
            klijent = new TcpKlijent();
            korisnik.Username = username;
            if (status == "Otključan")
            {
                korisnik.Status = 0;
            }
            else
            {
                korisnik.Status = 1;
            }
            klijent.PosaljiServeru(korisnik, "OtkljucajZakljucaj");
            korisnik = (Korisnik)klijent.PrimiOdServera();

            DohvatiKorisnike();
        }

        /// <summary>
        /// Metoda koja formira početno stanje tablice korisnika, tj stupce koji će biti prikazani u tablici
        /// </summary>
        private void FormirajDataGridove()
        {
            tablicaKorisnici.AllowUserToAddRows = false;
            tablicaKorisnici.ReadOnly = true;
            tablicaKorisnici.Columns.Add("Username", "Username");
            tablicaKorisnici.Columns.Add("Ime", "Ime");
            tablicaKorisnici.Columns.Add("Prezime", "Prezime");
            tablicaKorisnici.Columns.Add("Status", "Status");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            tablicaKorisnici.Columns.Add(btn);
            btn.HeaderText = "Otključaj/Zaključaj";
            btn.Text = "Promijeni";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            tablicaKorisnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            tablicaKorisnici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        /// <summary>
        /// Event handler koji se aktivira prilikom klika na gumb promijeni unutar tablice Korisnika (tj. datagridview)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tablicaKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string username;
            string status;
            if (e.ColumnIndex == 4)
            {
                try
                {
                    username = tablicaKorisnici.Rows[e.RowIndex].Cells["Username"].Value as string;
                    status = tablicaKorisnici.Rows[e.RowIndex].Cells["Status"].Value as string;
                    PromijeniStatus(username, status);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
