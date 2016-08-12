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

        private void OsvjeziListu()
        {
            TcpKlijent tcpKlijent = new TcpKlijent();
            byte[] poruka = new byte[1024];
            poruka = Encoding.ASCII.GetBytes("[OTKZAK]," + ",");
            tcpKlijent.PosaljiServeru(poruka);
            string porukaOdServera = Encoding.UTF8.GetString(tcpKlijent.PrimiOdServera());
            List<string> korisnici = porukaOdServera.Split(';').ToList();
            for (int i = 0; i < korisnici.Count; i++)
            {
                string[] korisnik = new string[3];
                korisnik = korisnici[i].Split(',');
                var listViewItem = new ListViewItem(korisnik);
                listaKorisnika.Items.Add(listViewItem);
            }
            listaKorisnika.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void OtkZakForm_Load(object sender, EventArgs e)
        {
            //this.listaKorisnika.CheckBoxes = true;
            OsvjeziListu();
        }
    }
}
