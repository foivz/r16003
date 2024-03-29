﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto0._1stable
{
    public partial class CitanjePorukeForm : Form
    {
        string usernamePrimatelja;
        public CitanjePorukeForm(string username)
        {
            InitializeComponent();
            usernamePrimatelja = username;
        }

        private void CitanjePorukeForm_Load(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("DOHVATIKLIJENTE");
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera());
            foreach (var item in porukaOdServera.Split(';'))
            {
                cmbKlijenti.Items.Add(item);
            }
            
        }

        private void cmbKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("CITANJEPORUKE," + cmbKlijenti.Text + "," + usernamePrimatelja);
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera());
            try
            {
                porukaOdServera = EncryptionHelper.CaesarStringDecrypt(porukaOdServera, int.Parse(textBox1.Text));
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            dgwCitanjePoruke.Rows.Clear();
            foreach (var item in porukaOdServera.Split(';'))
            {
                dgwCitanjePoruke.Rows.Add(item);
            }
        }

        private void btnOdgovori_Click(object sender, EventArgs e)
        {
            if (cmbKlijenti.Text.Length > 0)
            {
                Form posaljiPoruku = new PosaljiPorukuForm(usernamePrimatelja, cmbKlijenti.Text);
                posaljiPoruku.Show();
                this.Close();
            }
            else MessageBox.Show("Niste odabrali nijednog korisnika, poušajte ponovo!");
        }
    }
}
