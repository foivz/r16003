using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja predstavlja formu za razmjenu datoteka
    /// </summary>
    public partial class FormaRazmjenaDatoteka : Form
    {
        Form1 glavnaForma;
        Korisnik prijavljeniKorisnik;
        ListaKorisnika listaKorisnika;
        TcpKlijent klijent;
        string fileName;
        string fileNameSkini;
        int statusLoga;
        int statusPreuzimanja;

        /// <summary>
        /// Metoda za dodavanje gumba za preuzimanje i brisanje datoteka
        /// </summary>
        private void DodajGumbe()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            prikazDatoteke.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Preuzmi";
            btn.Name = "gumbSkini";
            btn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            prikazDatoteke.Columns.Add(btn2);
            btn2.HeaderText = "";
            btn2.Text = "Izbriši";
            btn2.Name = "gumbIzbrisi";
            btn2.UseColumnTextForButtonValue = true;
        }

        public String IzbrisiRedLoga(String myStr)
        {
            String result = "";
            if (myStr.Length > 2)
            {
                String temporary = myStr.Substring(0,myStr.Length - 2);

                int lastNewLine = temporary.LastIndexOf("\r\n");

                if (lastNewLine != -1)
                {
                    result = myStr.Substring(0, lastNewLine + 2);
                }
            }
            return (result);
        }

        /// <summary>
        /// Metoda koja ispisuje odgovarajuću poruku kada se datoteka šalje na dropbox server
        /// </summary>
        /// <param name="status"></param>
        private void IspisLoga(int status)
        {
            string lastLine = "";
            string lastword = "";
            if (prikazLog.Lines.Length > 0)
            {
                lastLine = prikazLog.Lines[prikazLog.Lines.Length-2];
                lastword = lastLine.Split(' ').Last();
            }
            string vrijeme = DateTime.Now.ToString();
            if (status == 1)
            {
                prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka Poslana!" + Environment.NewLine;
            }
            else if (status == 2)
            {
                prikazLog.Text += $"- Vrijeme: {vrijeme} - Neuspješno slanje!" + Environment.NewLine;
            }
            else if (status == 3)
            {
                prikazLog.Text = $"- Vrijeme: {vrijeme} - Početak slanja!" + Environment.NewLine;
            }
            else
            {
                if (lastword == "šalje...")
                {
                    prikazLog.Text = IzbrisiRedLoga(prikazLog.Text);
                    prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka se šalje."  + Environment.NewLine;
                }
                else if(lastword == "šalje..")
                {
                    prikazLog.Text = IzbrisiRedLoga(prikazLog.Text);
                    prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka se šalje..." + Environment.NewLine;
                }
                else if (lastword == "šalje.")
                {
                    prikazLog.Text = IzbrisiRedLoga(prikazLog.Text);
                    prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka se šalje.." + Environment.NewLine;
                }
                else
                {
                    prikazLog.Text += $"- Vrijeme: {vrijeme} - Datoteka se šalje..." +Environment.NewLine;
                }
            }
        }

        /// <summary>
        /// Metoda koja ispisuje odgovarajuću poruku kada se datoteka preuzima ili briše sa dropbox servera
        /// </summary>
        /// <param name="status"></param>
        private void IspisLogaZaPregled(int status)
        {
            string lastLine = "";
            string lastword = "";
            if (logPregledDatoteka.Lines.Length > 0)
            {
                lastLine = logPregledDatoteka.Lines[logPregledDatoteka.Lines.Length - 2];
                lastword = lastLine.Split(' ').Last();
            }
            string vrijeme = DateTime.Now.ToString();

            if (status == 1)
            {
                if (lastword == "skida...")
                {
                    logPregledDatoteka.Text = IzbrisiRedLoga(logPregledDatoteka.Text);
                    logPregledDatoteka.Text += $"- Vrijeme: {vrijeme} - Datoteka se skida." + Environment.NewLine;
                }
                else if (lastword == "skida..")
                {
                    logPregledDatoteka.Text = IzbrisiRedLoga(logPregledDatoteka.Text);
                    logPregledDatoteka.Text += $"- Vrijeme: {vrijeme} - Datoteka se skida..." + Environment.NewLine;
                }
                else if (lastword == "skida.")
                {
                    logPregledDatoteka.Text = IzbrisiRedLoga(logPregledDatoteka.Text);
                    logPregledDatoteka.Text += $"- Vrijeme: {vrijeme} - Datoteka se skida.." + Environment.NewLine;
                }
                else
                {
                    logPregledDatoteka.Text += $"- Vrijeme: {vrijeme} - Datoteka se skida..." + Environment.NewLine;
                }
            }

            else if (status == 2)
            {
                logPregledDatoteka.Text += $"- Vrijeme: {vrijeme} - Datoteka je skinuta!" + Environment.NewLine;
            }

            else if (status == 3)
            {
                logPregledDatoteka.Text += $"- Vrijeme: {vrijeme} - Datoteka je obrisana!" + Environment.NewLine;
            }
            else if (status == 4)
            {
                logPregledDatoteka.Text = $"- Vrijeme: {vrijeme} - Početak preuzimanja!" + Environment.NewLine;
            }

            else
            {
                logPregledDatoteka.Text += $"- Vrijeme: {vrijeme} - Neuspješno skidanje!" + Environment.NewLine;
            }
        }

        /// <summary>
        /// Otvaranje Windows dijaloga za spremanje datoteke
        /// </summary>
        /// <param name="file"></param>
        private void OtvoriSaveFileDialog(byte[] file)
        {
            string saveFilePath = "";
            SaveFileDialog spremiDatoteku = new SaveFileDialog();
            spremiDatoteku.FileName = fileNameSkini;
            spremiDatoteku.DefaultExt = Path.GetExtension(fileNameSkini);
            spremiDatoteku.Filter = "All files (*.*)|*.*";
            spremiDatoteku.AddExtension = true;
            spremiDatoteku.OverwritePrompt = true;
            DialogResult spremiDatotekuPovrat = spremiDatoteku.ShowDialog();
            if (spremiDatotekuPovrat == DialogResult.OK)
            {
                saveFilePath = spremiDatoteku.FileName;
                File.WriteAllBytes(saveFilePath, file);
                IspisLogaZaPregled(2);
            }
            else
            {
                IspisLogaZaPregled(0);
            }
        }

        /// <summary>
        /// Metoda koja dohvaća korisnike aplikacije kako bi im se mogla poslati datoteka
        /// </summary>
        private void DohvatiKorisnike()
        {
            listaKorisnika = new ListaKorisnika();
            klijent = new TcpKlijent();
            klijent.PosaljiServeru(listaKorisnika, "DohvatiKorisnike");
            listaKorisnika = (ListaKorisnika)klijent.PrimiOdServera();
            odabirKorisnik.DataSource = listaKorisnika.IzdvojiKorisnickaImena();
            odabirKorisnik.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        /// <summary>
        /// Osvježava prikaz, tj. datagridview za primljenje datoteke
        /// </summary>
        /// <param name="listaDatoteka"></param>
        private void TablicaDatoteka(List<Datoteka> listaDatoteka)
        {
            prikazDatoteke.DataSource = null;
            prikazDatoteke.Rows.Clear();
            prikazDatoteke.Refresh();
            prikazDatoteke.DataSource = listaDatoteka;
            prikazDatoteke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //prikazDatoteke.Columns[prikazDatoteke.Columns.Count-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Konstruktor forme FormaRazmjenaDatoteka
        /// </summary>
        /// <param name="glavna"></param>
        /// <param name="korisnik"></param>
        public FormaRazmjenaDatoteka(Form1 glavna, Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = glavna;
            prijavljeniKorisnik = korisnik;
            DodajGumbe();
            DohvatiKorisnike();
        }

        /// <summary>
        /// Event handler koji prilikom klika na gumb "Trazi" otvara dialog za pronalaz datoteke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event handler koji prilikom klika na gumb "Posalji" salje datoteku na dropbox server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void gumbPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                IspisLoga(3);
                statusLoga = 0;
                timerLog.Start();

                DropboxManager novo = new DropboxManager();
                string javniKljuc = listaKorisnika.Korisnici.Where(i => i.Username == odabirKorisnik.SelectedItem.ToString()).Select(p => p.JavniKljuc).First();
                int result = await novo.Upload(fileName, prijavljeniKorisnik.Username, odabirKorisnik.SelectedItem.ToString(),javniKljuc);
                if (result == 1)
                {
                    IspisLoga(1);
                }
            }
            catch
            {
                IspisLoga(2);
            }
            timerLog.Stop();
        }

        /// <summary>
        /// Event handler koji se aktivira kada se promijeni tab na formi, tj aktivira se tab za pregled datoteka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void tabKontrola_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabKontrola.SelectedIndex == 1)
            {
                DropboxManager novo = new DropboxManager();
                List<Datoteka> listaDatoteka = await novo.ListRootFolder(prijavljeniKorisnik.Username, listaKorisnika.Korisnici);
                listaDatoteka = listaDatoteka.OrderByDescending(x => x.Datum).ToList();
                TablicaDatoteka(listaDatoteka);
            }
        }

        /// <summary>
        /// Event handler koji se aktivira prilikom klika na gumb za skidanje ili brisanje datoteke sa dropbox servera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void prikazDatoteke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int delete = 0;

            //index klika za preuzimanje datoteke
            if (e.ColumnIndex == 0)
            {
                try
                {
                    DropboxManager novo = new DropboxManager();
                    string posiljatelj = prikazDatoteke.Rows[e.RowIndex].Cells["Posiljatelj"].Value as string;
                    fileNameSkini = prikazDatoteke.Rows[e.RowIndex].Cells["ImeDatoteke"].Value as string;

                    IspisLogaZaPregled(4);

                    statusPreuzimanja = 1;
                    timerPreuzmi.Start();
                    byte[] file = await novo.Download(prijavljeniKorisnik.Username, posiljatelj, fileNameSkini);

                    OtvoriSaveFileDialog(file);
                }
                catch
                {

                }

                timerPreuzmi.Stop();
            }

            //index klika za brisanje datoteke
            if (e.ColumnIndex == 1)
            {
                try
                {
                    DropboxManager novo = new DropboxManager();
                    string posiljatelj = prikazDatoteke.Rows[e.RowIndex].Cells["Posiljatelj"].Value as string;
                    fileNameSkini = prikazDatoteke.Rows[e.RowIndex].Cells["ImeDatoteke"].Value as string;
                    delete = await novo.DeleteFile(prijavljeniKorisnik.Username, posiljatelj, fileNameSkini);
                    IspisLogaZaPregled(3);

                    if (delete == 1)
                    {
                        List<Datoteka> listaDatoteka = await novo.ListRootFolder(prijavljeniKorisnik.Username, listaKorisnika.Korisnici);
                        listaDatoteka = listaDatoteka.OrderByDescending(x => x.Datum).ToList();
                        TablicaDatoteka(listaDatoteka);
                    }
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// Nepotreban event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odabirKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unosDatoteka.Text = null;
            //gumbPosalji.Enabled = false;
        }

        private void timerLog_Tick(object sender, EventArgs e)
        {
            IspisLoga(statusLoga);
        }

        private void timerPreuzmi_Tick(object sender, EventArgs e)
        {
            IspisLogaZaPregled(statusPreuzimanja);
        }
    }
}
