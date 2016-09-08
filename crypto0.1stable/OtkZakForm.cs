using System;
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
    public partial class OtkZakForm : Form
    {
        public OtkZakForm()
        {
            InitializeComponent();
        }

        private void SigurnoIsprazni()
        {
            this.listaKorisnika.Items.Clear();
            this.listaKorisnika.Update();
            this.listaKorisnika.Refresh();
        }

        private void OsvjeziListu()
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("[OTKZAK]," + ",");
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera()).Replace("\0", string.Empty);
            List<string> korisnici = porukaOdServera.Split(';').ToList();
            for (int i = 0; i < korisnici.Count; i++)
            {
                string[] korisnik = new string[3];
                korisnik = korisnici[i].Split(',');
                var listViewItem = new ListViewItem(korisnik);
                listaKorisnika.Items.Add(listViewItem);
            }
            listaKorisnika.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listaKorisnika.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void OtkZakForm_Load(object sender, EventArgs e)
        {
            //this.listaKorisnika.CheckBoxes = true;
            OsvjeziListu();
        }

        private void btnRadnja_Click(object sender, EventArgs e)
        {
            if (listaKorisnika.SelectedItems.Count == 0)
            {
                btnRadnja.Enabled = false;
                return;
            }

            ListViewItem item = listaKorisnika.SelectedItems[0];
            string korime = item.SubItems[0].Text;
            bool status = true;
            if (btnRadnja.Text == "Otkljucaj")
            {
                status = true;
            }
            else if (btnRadnja.Text == "Zakljucaj")
            {
                status = false;
            }

            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("[UPDOTKLJUCAJ]," + korime + "," + status.ToString());
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera()).Replace("\0", string.Empty);
            SigurnoIsprazni();
            OsvjeziListu();
        }

        private void listaKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaKorisnika.SelectedItems.Count == 0)
            {
                btnRadnja.Enabled = false;
                return;
            }

            ListViewItem item = listaKorisnika.SelectedItems[0];
            string tekst = item.SubItems[1].Text.Trim();
            if (tekst.Equals("Otkljucan"))
            {
                btnRadnja.Text = "Zakljucaj";
            }
            if (tekst.Equals("Zakljucan"))
            {
                btnRadnja.Text = "Otkljucaj";
            }
            btnRadnja.Enabled = true;
        }
    }
}
