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
    public partial class FormaONama : Form
    {
        public FormaONama()
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
            labelaOpis.Text = @"Aplikacija riješava problem sakrivanja podataka u bazi i sigurne komunikacije između korisnika. 
Glavni zadatak aplikacije je da korisnik može poslati poruku sigurnim putem drugom korisniku aplikacije. 
Aplikacija predstavlja program sigurne komunikacije za korisnike neke kompanije. 
Osim poruka mogu se razmjenjivati i datoteke.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:"+ linkLabel1.Text);
        }
    }
}
