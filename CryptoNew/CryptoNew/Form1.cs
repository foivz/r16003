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
    public partial class Form1 : Form
    {
        Form forma;
        Korisnik testKorisnik;
        Button trenutni;

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

        private void DealocirajGlavniPanel()
        {
            foreach (Control control in glavniPanel.Controls)
            {
                control.Dispose();
            }
            glavniPanel.Controls.Clear();
        }

        public void NotifyMe(Korisnik korisnik)
        {
            testKorisnik.Username = korisnik.Username;
            testKorisnik.Password = korisnik.Password;
            DealocirajGlavniPanel();

            if (testKorisnik.Username != null)
            {
                gumbLogout.Enabled = true;
                FormaPrijavljen novo = new FormaPrijavljen(testKorisnik);
                Dizajner.prilagodiFormuPanelu(novo, glavniPanel);
                forma = novo;
            }
            else
            {
                gumbLogout.Enabled = false;
                Prijava novo1 = new Prijava(this);
                Dizajner.prilagodiFormuPanelu(novo1, glavniPanel);
                forma = novo1;
            }
        }

        public void NotifyRegistracija()
        {
            DealocirajGlavniPanel();
            Registracija registracijskaForma = new Registracija(this);
            Dizajner.prilagodiFormuPanelu(registracijskaForma, glavniPanel);
            forma = registracijskaForma;
            trenutni = gumbGlavni;
        }

        public Form1(bool test)
        {
            InitializeComponent();
            gumbLogout.Enabled = false;
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

        private void gumbLogout_Click(object sender, EventArgs e)
        {
            trenutni = gumbGlavni;
            testKorisnik.Username = null;
            testKorisnik.Password = null;
            NotifyMe(testKorisnik);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Dizajner.prilagodiVelicinu(forma, glavniPanel);
        }

        private void gumbGlavni_Click(object sender, EventArgs e)
        {
            trenutni = gumbGlavni;
            NotifyMe(testKorisnik);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
        }

        private void glavniPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}