﻿using System;
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
    public partial class Prijava : Form
    {
        Form1 glavnaForma;
        public Prijava(Form1 forma)
        {
            InitializeComponent();
            unosPassword.PasswordChar = '*';
            Dizajner.FormaBezOkna(this);
            glavnaForma = forma;
        }

        public bool Validacija ()
        {
            bool rezultat = true; ;
            if (unosUsername.Text == "")
            {
                rezultat = false;
            }

            if (unosPassword.Text == "")
            {
                rezultat = false;
            }
            return rezultat;
        }

        public void napraviResize(Panel panel)
        {
            this.Width = panel.Width;
            this.Height = panel.Height;
        }

        private void gumbLogin_Click(object sender, EventArgs e)
        {
            if (Validacija() == false)
            {
               MessageBox.Show("Neispravan unos");
               return;
            }
            Korisnik test = new Korisnik();
            test.Username = unosUsername.Text;
            test.Password = unosPassword.Text;
            glavnaForma.NotifyMe(test);
        }

        public Prijava Reset()
        {
            return new Prijava(glavnaForma);
        }
    }
}
