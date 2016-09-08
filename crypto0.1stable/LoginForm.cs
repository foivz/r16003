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
    public partial class LoginForm : Form
    {
        List<string> listaPodataka = new List<string>();
        public frmCrypto pocetnaForma { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnPotvrdi_Click_1(object sender, EventArgs e)
        {
            try {
                //Povezivanje sa serverom pomocu TCP-a, server obavlja provjeru
                if (txtUser.Text.Length > 3 && txtPass.Text.Length > 3)
                {
                    TcpKlijent tcpKlijent = new TcpKlijent();
                    byte[] poruka = new byte[1024];
                    poruka = Encoding.ASCII.GetBytes("LOGIN," + txtUser.Text + "," + txtPass.Text + ",");
                    tcpKlijent.PosaljiServeru(poruka);
                    byte[] primitak = tcpKlijent.PrimiOdServera();
                    if (primitak != null)
                    {
                        string porukaOdServera = Encoding.ASCII.GetString(primitak);
                        //MessageBox.Show("Uspješno ste se logirali!");
                        listaPodataka = porukaOdServera.Split(';').ToList();
                        pocetnaForma.promijeniPristup(Int32.Parse(listaPodataka[4]), listaPodataka[0], listaPodataka[1], listaPodataka[2]);
                    }
                    tcpKlijent.ZatvoriSocket();
                    MessageBox.Show("Username i Password tocni, pregledavam tocnost 2FA kljuca");
                    this.Close();
                }
                else MessageBox.Show("Username i password moraju imati vise od 3 charactera");
            }
            catch
            {
                MessageBox.Show("Neuspješna prijava (pogrešan unos ili blokiran račun)");
            }
        }
    }
}
