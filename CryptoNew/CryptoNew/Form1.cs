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
    /// Glavna forma aplikacije koja predstavlja glavni prozor aplikacije
    /// </summary>
    public partial class Form1 : Form
    {
        Form forma;
        Korisnik testKorisnik;
        Button trenutni;

        /// <summary>
        /// Custom Event koji koji na određeni pritisak na tipkovnici bira akciju za refresh trenutnoga prozora
        /// ili za logout ili za izklazak iz aplikacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
        {
            if (e.KeyCode == Keys.F5)
            {
                trenutni.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                gumbLogout.PerformClick();
            }
            if (e.KeyCode == Keys.F9)
            {
                this.Dispose();
            }
        }

        /// <summary>
        /// Metoda koja dealocira prozor, tj. formu unutar glavnoga panela aplikacije
        /// </summary>
        private void DealocirajGlavniPanel()
        {
            foreach (Control control in glavniPanel.Controls)
            {
                control.Dispose();
            }
            glavniPanel.Controls.Clear();
        }

        /// <summary>
        /// Metoda koja se koristi u ovoj formi i u drugim formama kako bi se prilagodio glavni prozor i panel korisniku koji
        /// je ili prijavljen ili nije prijavljen (guest način rada)
        /// </summary>
        /// <param name="korisnik"></param>
        public void NotifyMe(Korisnik korisnik)
        {
            testKorisnik = korisnik;
            DealocirajGlavniPanel();

            if (testKorisnik.Username != null)
            {
                gumbLogout.Enabled = true;
                gumbSlanje.Enabled = true;
                gumbPregledPoruka.Enabled = true;
                gumbRazmjenaDatoteka.Enabled = true;
                statusBarUsername.Text = testKorisnik.Username;
                statusBarTipKorisnika.Text = testKorisnik.TipKorisnika;
                FormaPrijavljen novo = new FormaPrijavljen(testKorisnik);
                Dizajner.prilagodiFormuPanelu(novo, glavniPanel);
                forma = novo;
            }
            else
            {
                gumbLogout.Enabled = false;
                gumbSlanje.Enabled = false;
                gumbPregledPoruka.Enabled = false;
                gumbRazmjenaDatoteka.Enabled = false;
                Prijava novo1 = new Prijava(this);
                Dizajner.prilagodiFormuPanelu(novo1, glavniPanel);
                forma = novo1;
            }

            if (testKorisnik.TipKorisnika == "Admin")
            {
                gumbAdmin.Visible = true;
            }
        }

        /// <summary>
        /// Metoda koja se poziva iz forme Prijava kako bi se aktivirala forma za registraciju
        /// </summary>
        public void NotifyRegistracija()
        {
            DealocirajGlavniPanel();
            Registracija registracijskaForma = new Registracija(this);
            Dizajner.prilagodiFormuPanelu(registracijskaForma, glavniPanel);
            forma = registracijskaForma;
            trenutni = gumbGlavni;
        }

        /// <summary>
        /// Konstruktor glavne forme koji namješta početne postavke glavnoga prozora i glavnoga panela 
        /// </summary>
        /// <param name="test"></param>
        public Form1(bool test)
        {
            InitializeComponent();
            gumbLogout.Enabled = false;
            trenutni = gumbGlavni;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.RosyBrown;
                }
            }

            label1.BackColor = Color.RosyBrown;

            Prijava formaPrijave = new Prijava(this);
            Dizajner.prilagodiFormuPanelu(formaPrijave, glavniPanel);
            forma = formaPrijave;

            testKorisnik = new Korisnik();
            testKorisnik.Username = null;
            testKorisnik.Password = null;
        }

        /// <summary>
        /// Event metoda koja se aktivira prilikom klika na gumb Logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbLogout_Click(object sender, EventArgs e)
        {
            gumbAdmin.Visible = false;
            trenutni = gumbGlavni;
            statusBarUsername.Text = "Gost";
            statusBarTipKorisnika.Text = "Gost";
            testKorisnik = new Korisnik();
            NotifyMe(testKorisnik);
        }

        /// <summary>
        /// Kada se poveća ili smanji glavni prozor aplikacije, sukladno tome prilagođava se veličina glavnoga panela i forme
        /// koja je trenutno aktivna u tom panelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            Dizajner.prilagodiVelicinu(forma, glavniPanel);
        }

        /// <summary>
        /// Event metoda koja se aktivira prilikom klika na Glavni gumb aplikacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbGlavni_Click(object sender, EventArgs e)
        {
            trenutni = gumbGlavni;
            NotifyMe(testKorisnik);
        }

        /// <summary>
        /// Postavlja se custom event handler prilikom pritiska na određeni gumb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
        }

        private void glavniPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Event metoda koja se aktivira prilikom klika na gumb za lokalnu enkripciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbLokalno_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            LokalnaEnkripcija formaLokalno = new LokalnaEnkripcija();
            Dizajner.prilagodiFormuPanelu(formaLokalno, glavniPanel);
            forma = formaLokalno;
            trenutni = gumbLokalno;
        }

        /// <summary>
        /// Event metoda koja se aktivira prilikom klika na gumb za slanje poruke nekom od korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbSlanje_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            SlanjePoruka formaSlanje = new SlanjePoruka(this,testKorisnik);
            Dizajner.prilagodiFormuPanelu(formaSlanje, glavniPanel);
            forma = formaSlanje;
            trenutni = gumbSlanje;
        }

        /// <summary>
        /// Event metoda koja se aktivira prilikom klika na gumb za pregled poruka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbPregledPoruka_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            FormaPregled formaPregledPoruka = new FormaPregled(this, testKorisnik);
            Dizajner.prilagodiFormuPanelu(formaPregledPoruka, glavniPanel);
            forma = formaPregledPoruka;
            trenutni = gumbPregledPoruka;
        }

        /// <summary>
        /// Timer koji se okida svaku sekundu te postavlja vrijeme na status traci koja se nalazi odmah ispod glavnoga prozora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerVrijeme_Tick(object sender, EventArgs e)
        {
            statusTimer.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Event metoda koja se aktivira prilikom klika na gumb za razmjenu datoteka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbRazmjenaDatoteka_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            FormaRazmjenaDatoteka formaRazmjenaDatoteka = new FormaRazmjenaDatoteka(this, testKorisnik);
            Dizajner.prilagodiFormuPanelu(formaRazmjenaDatoteka, glavniPanel);
            forma = formaRazmjenaDatoteka;
            trenutni = gumbRazmjenaDatoteka;
        }

        /// <summary>
        /// Event handler koji se aktivira prilikom klika na gumb koji otvara admin panel formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbAdmin_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            FormaAdminPanel formaAdminPanel = new FormaAdminPanel();
            Dizajner.prilagodiFormuPanelu(formaAdminPanel, glavniPanel);
            forma = formaAdminPanel;
            trenutni = gumbAdmin;
        }
    }
}