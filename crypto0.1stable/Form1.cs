﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto0._1stable
{
    public partial class frmCrypto : Form
    {
        Korisnik kPodaci;
        private string pristup = "Guest";
        public frmCrypto()
        {
            kPodaci = new Korisnik();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F1")
            {
                MessageBox.Show(File.ReadAllText("F1help.txt"));
            }
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Udi u login formu
            var loginForm = new LoginForm();
            loginForm.pocetnaForma = this;
            loginForm.Show();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Form registracijaForm = new RegistracijskaForma();
            registracijaForm.Show();
        }

        private void btnFreeCrypto_Click(object sender, EventArgs e)
        {
            var EncryptOrDecrypt = new EncryptOrDecrypt();
            EncryptOrDecrypt.Show();

        }

        private void btnC2C_Click(object sender, EventArgs e)
        {
            var C2CForm = new ClientToClientForm(kPodaci.username);
            C2CForm.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            var chatForm = new ChatForm(kPodaci.username);
            chatForm.Show();
        }

        private void frmCrypto_Load(object sender, EventArgs e)
        {
            lblPristup.Text = pristup;
        }

        private void updateProfil_Click(object sender, EventArgs e)
        {
            var updateForm = new ProfilUpdateForm(kPodaci.username,kPodaci.password,kPodaci.email);
            updateForm.Show();
        }

        public void promijeniPristup(int razinaAkt, string username, string password, string email)
        {
            if (razinaAkt == 1)
            {
                this.pristup = "Admin";
                btnAdmin.Enabled = true;
            }
            else if (razinaAkt == 2)
            {
                this.pristup = "Moderator";
            }
            else
            {
                this.pristup = "Korisnik";
            }
            this.lblPristup.Text = this.pristup;
            updateProfil.Enabled = true;
            btnLogin.Enabled = false;
            btnRegistracija.Enabled = false;
            btnC2C.Enabled = true;
            btnChat.Enabled = true;

            kPodaci.username = username;
            kPodaci.password = password;
            kPodaci.email = email;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminskiPanel = new AdminPanelForm();
            adminskiPanel.Show();
        }

        private void frmCrypto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
        }
    }
}
