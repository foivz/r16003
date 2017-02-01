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
    public partial class FormaPregled : Form
    {
        Form1 glavnaForma;
        Korisnik prijavljeniKorisnik;
        ListaPoruka listaPoruka;
        TcpKlijent klijent;
        public FormaPregled(Form1 forma, Korisnik korisnik)
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            glavnaForma = forma;
            prijavljeniKorisnik = korisnik;
            FormirajDataGridove();

            klijent = new TcpKlijent();
            listaPoruka = new ListaPoruka();
            listaPoruka.Username = prijavljeniKorisnik.Username;
            klijent.PosaljiServeru(listaPoruka, "DohvatiPrimljenePoruke");
            listaPoruka = (ListaPoruka)klijent.PrimiOdServera();

            for (int i = 0; i < listaPoruka.Poruke.Count; i++)
            {
                Poruka poruka = listaPoruka.Poruke[i];
                EnkripcijskiPaket paket = listaPoruka.Poruke[i].Paket;
                dataGridViewPrimljeno.Rows.Add("",poruka,poruka.Posiljatelj, poruka.Primatelj, poruka.DatumSlanja.ToShortDateString(), paket.EnkriptiraniKljuc, paket.EnkriptiraniPodaci, Convert.ToBase64String(paket.Iv));
            }
        }

        private void FormirajDataGridove()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridViewPrimljeno.Columns.Add(btn);
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = Color.SkyBlue;
            btn.Text = "Pregledaj";
            btn.HeaderText = "Pregledaj";
            btn.UseColumnTextForButtonValue = true;
            dataGridViewPrimljeno.Columns.Add("Poruka", "Poruka");
            dataGridViewPrimljeno.Columns["Poruka"].Visible = false;
            dataGridViewPrimljeno.Columns.Add("Posiljatelj", "Posiljatelj");
            dataGridViewPrimljeno.Columns.Add("Primatelj", "Primatelj");
            dataGridViewPrimljeno.Columns["Primatelj"].Visible = false;
            dataGridViewPrimljeno.Columns.Add("DatumSlanja", "Datum Slanja");
            dataGridViewPrimljeno.Columns.Add("EnkriptiraniKljuc", "Enkriptirani Ključ");
            dataGridViewPrimljeno.Columns["EnkriptiraniKljuc"].Visible = false;
            dataGridViewPrimljeno.Columns.Add("EnkriptiraniPodaci", "Enkriptirani Podaci");
            dataGridViewPrimljeno.Columns["EnkriptiraniPodaci"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPrimljeno.Columns.Add("Iv", "Iv");
            dataGridViewPrimljeno.Columns["Iv"].Visible = false;
            dataGridViewPrimljeno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPrimljeno.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewPoslano.Columns.Add("Posiljatelj", "Posiljatelj");
            dataGridViewPoslano.Columns.Add("Primatelj", "Primatelj");
            dataGridViewPoslano.Columns["Posiljatelj"].Visible = false;
            dataGridViewPoslano.Columns.Add("DatumSlanja", "Datum Slanja");
            dataGridViewPoslano.Columns.Add("EnkriptiraniKljuc", "Enkriptirani Ključ");
            dataGridViewPoslano.Columns["EnkriptiraniKljuc"].Visible = false;
            dataGridViewPoslano.Columns.Add("EnkriptiraniPodaci", "Enkriptirani Podaci");
            dataGridViewPoslano.Columns["EnkriptiraniPodaci"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPoslano.Columns.Add("Iv", "Iv");
            dataGridViewPoslano.Columns["Iv"].Visible = false;
            dataGridViewPoslano.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dataGridViewPrimljeno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPrimljeno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Poruka poruka = dataGridViewPrimljeno.Rows[e.RowIndex].Cells["Poruka"].Value as Poruka;
                FormaDekriptiranaPoruka novaForma = new FormaDekriptiranaPoruka(poruka);
                novaForma.ShowDialog();
            }
        }
    }
}
