using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

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

        private void slanje_maila(string mejl, string lozinka)
        {
            try {
                MailMessage mail = new MailMessage();
                //SmtpClient SmtpServer = new SmtpClient("smtp.mail.yahoo.com");

                mail.From = new MailAddress("testiraj95@yahoo.com");
                mail.To.Add(new MailAddress("385976241@sms.t-mobile.hr"));
                mail.Subject = "2fa lozinka";
                mail.Body = "Ovo je vaša 2fa lozinka za pristup aplikaciji: " + lozinka;

                //SmtpServer.Port = 25;
                //SmtpServer.UseDefaultCredentials = false;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("testiraj95@yahoo.com", "checking1928");
                //SmtpServer.EnableSsl = true;

                //SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                this.Show();
            }
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

                        string lozinka = System.IO.Path.GetRandomFileName().Replace(".", "");
                        string mejl = listaPodataka[2];
                        //slanje_maila(mejl,lozinka);

                        ExtraLoginForm childForm = new ExtraLoginForm(lozinka);
                        childForm.ShowDialog();
                    }
                    tcpKlijent.ZatvoriSocket();
<<<<<<< HEAD
                    MessageBox.Show("Username i Password tocni, pregledavam tocnost 2FA kljuca");
=======
                    //MessageBox.Show("Username i Password tocni, pregledavam tocnost 2FA kljuca");
>>>>>>> ivan-crypto
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
