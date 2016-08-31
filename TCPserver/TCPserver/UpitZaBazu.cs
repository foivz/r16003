using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace TCPserver
{
    class UpitZaBazu
    {
        private string identitetPoruke;
        private string[] elementiPoruke;
        private string upit;
        SqlDataReader reader;
        

        public UpitZaBazu(string item, string[] elementi)
        {
            identitetPoruke = item;
            elementiPoruke = elementi;
        }

        public List<string> dohvatiElementeIzPoruke()

        {
            List<string> result = new List<string>();
            if (identitetPoruke == "LOGIN")
            {
                result = StvoriLoginUpit();
                return result;
            }

            else if (identitetPoruke == "REGISTER")
            {
                result = StvoriRegisterUpit();
                return result;
            }
            else if(identitetPoruke == "PRUPDATE")
            {
                result = UpdateKorisnickihPodatakaUpit();
                return result;
            }
            else if(identitetPoruke == "C2C")
            {
                result = SLanjeTekstualnePorukeCLientuUpit();
                return result;
            }
            else if(identitetPoruke == "DOHVATIKLIJENTE")
            {
                result = DohvatiKlijenteUpit();
                return result;
            }
            else if(identitetPoruke == "CITANJEPORUKE")
            {
                result = DohvatiNeprocitanePorukeUpit();
                return result;
            }
            return result;
        }

        private List<string> StvoriLoginUpit()
        {
            List<string> podaciKorisnik = new List<string>();
            upit = "Select * from Korisnici where username = '" + elementiPoruke[1] + "' and password = '" + elementiPoruke[2] + "'";
            Baza.OtvaranjeKonekcijeSBazom();
            reader = Baza.IzvrsavanjeUpita(upit);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("Podaci o uspjesnoj prijavi: ");
                    Console.WriteLine("{0}\t{1}", reader.GetString(0),
                        reader.GetString(1));
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        podaciKorisnik.Add(reader[i].ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("Neuspjesna prijava");
            }

            Baza.ZatvaranjeKonekcijeSBazom();
            reader.Close();
            return podaciKorisnik;
        }

        private List<string> StvoriRegisterUpit()
        {
            bool uspjesno = true;
            List<string> podaciKorisnik = new List<string>();
            upit = "Insert into Korisnici (username, password, email, datumROdjenja, razinaPristupa, aktivnost) values ('"+ elementiPoruke[1] + "','" + elementiPoruke[2] + "','" + elementiPoruke[3] + "','" + elementiPoruke[4] + "','" + 3.ToString() + "','" + "True" + "')";
            Baza.OtvaranjeKonekcijeSBazom();
            try
            {
                Baza.IzvrsavanjeUpita(upit);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Već postoji taj username u bazi");
                uspjesno = false;
            }
            if (uspjesno == true) podaciKorisnik.Add("Registracija uspjesno izvrsena!");
            else podaciKorisnik.Add("Korisnik sa tim usernameom već postoji, pokušajte ponovo!");
            Baza.ZatvaranjeKonekcijeSBazom();
            return podaciKorisnik;
        }

        private List<string> UpdateKorisnickihPodatakaUpit()
        {
            List<string> podaciKorisnik = new List<string>();
            upit = "update Korisnici set password='" + elementiPoruke[2] + "', email='" + elementiPoruke[3] + "', datumRodjenja='" + elementiPoruke[4] + "' where username='" + elementiPoruke[1] + "'";
            Baza.OtvaranjeKonekcijeSBazom();
            Baza.IzvrsavanjeUpita(upit);
            Baza.ZatvaranjeKonekcijeSBazom();
            podaciKorisnik.Add("Uspjesno ste promijenili korisnicke podatke!");
            return podaciKorisnik;
        }

        private List<string> SLanjeTekstualnePorukeCLientuUpit()
        {
            List<string> podaciKorisnik = new List<string>();
            upit = "insert into Poruke (posiljatelj, primatelj, tekst) values ('"+ elementiPoruke[1] + "','" + elementiPoruke[2] + "','" + elementiPoruke[3] + "')";
            Baza.OtvaranjeKonekcijeSBazom();
            Baza.IzvrsavanjeUpita(upit);
            Baza.ZatvaranjeKonekcijeSBazom();
            podaciKorisnik.Add("Poruka uspjesno poslana!");
            return podaciKorisnik;
        }

        private List<string> DohvatiKlijenteUpit()
        {
            List<string> podaciKorisnik = new List<string>();
            upit = "select username from Korisnici";
            Baza.OtvaranjeKonekcijeSBazom();
            reader = Baza.IzvrsavanjeUpita(upit);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for(int i = 0; i<reader.FieldCount; i++)
                    {
                        podaciKorisnik.Add(reader[i].ToString());
                    }
                }
            }
            Baza.ZatvaranjeKonekcijeSBazom();
            reader.Close();
            return podaciKorisnik;
        }

        private List<string> DohvatiNeprocitanePorukeUpit()
        {
            List<string> podaciKorisnik = new List<string>();
            upit = "select tekst from Poruke where posiljatelj = '" + elementiPoruke[1] + "' and primatelj = '" + elementiPoruke[2] + "' and procitano = 'False'";
            Baza.OtvaranjeKonekcijeSBazom();
            reader = Baza.IzvrsavanjeUpita(upit);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        podaciKorisnik.Add(reader[i].ToString());
                    }
                }
            }
            else podaciKorisnik.Add("Nema neprocitanih poruka!");
            Baza.ZatvaranjeKonekcijeSBazom();
            reader.Close();
            OznaciPorukeProcitanima(elementiPoruke);
            return podaciKorisnik;
        }

        private void OznaciPorukeProcitanima(string[] elemntiPoruke)
        {
            string upit = "update Poruke set procitano = 'True' where posiljatelj = '" + elementiPoruke[1] + "' and primatelj = '" + elementiPoruke[2] + "' and procitano = 'False'";
            Baza.OtvaranjeKonekcijeSBazom();
            Baza.IzvrsavanjeUpita(upit);
            Baza.ZatvaranjeKonekcijeSBazom();
        }
    }
}
