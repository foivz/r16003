using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CryptoNew
{

    public class UspjehRegistracije
    {
        public string Tip { get; set; }
        public int PotvrdaKorisnika { get; set; }

        public UspjehRegistracije()
        {
            Tip = "UspjehRegistracije";
        }
    }

    public class Potvrda2FA
    {
        public string Tip { get; set; }
        public int Potvrdi { get; set; }
    }

    public class Korisnik
    {
        public string Tip { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string DatumRodjenja { get; set; }
        public string Kljuc2FA { get; set; }
        public string JavniKljuc { get; set; }
        public int Status { get; set; }
        public string TipKorisnika { get; set; }

        public Korisnik()
        {
            Tip = "Korisnik";
            Kljuc2FA = "null";
            JavniKljuc = "null";
        }

        /// <summary>
        /// Pomoćna funkcija za funkciju RegistrirajKorisnika() koja zapisuje sve potrebne ključeve u bazu podataka(Javni,Privatni,2FA)
        /// </summary>
        /// <param name="connection"></param>
        private void ZapisiKljuceveUBazu(SqlConnection connection)
        {
            var command = new SqlCommand();
            Enkripcija enkripcija = new RsaEnkripcija();
            enkripcija.AssignRsaKeys();
            JavniKljuc = enkripcija.DohvatiJavniKljuc();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Korisnik SET JavniKljuc = @JavniKljuc WHERE Username=@Username";
            command.Parameters.AddWithValue("@JavniKljuc", JavniKljuc);
            command.Parameters.AddWithValue("@Username", Username);
            command.ExecuteNonQuery();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PrivatniKljucevi(Username,PrivatniKljuc) VALUES (@Username,@PrivatniKljuc)";
            command.Parameters.AddWithValue("@PrivatniKljuc", enkripcija.DohvatiPrivatniKljuc());
            command.Parameters.AddWithValue("@Username", Username);
            command.ExecuteNonQuery();

            if (Kljuc2FA == "DA")
            {
                Verficiranje2FA verificiranje = new Verficiranje2FA();
                Kljuc2FA = verificiranje.GenerirajKljuc2FA();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Korisnik SET Kljuc2FA = @Kljuc2FA WHERE Username=@Username";
                command.Parameters.AddWithValue("@Kljuc2FA", Kljuc2FA);
                command.Parameters.AddWithValue("@Username", Username);
                command.ExecuteNonQuery();
            }

            DropboxManager dropbox = new DropboxManager();
            dropbox.CreateANewFolder(Username);
        }

        /// <summary>
        /// Pomoćna funkcija za funkciju PrijavaKorisnika() koja unosi 2FA ključ u bazu podataka
        /// </summary>
        /// <param name="connection"></param>
        private void UnesiUBazuKljuc2FA(SqlConnection connection)
        {
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Korisnik SET Kljuc2FA = @Kljuc2FA WHERE Username=@Username";
            command.Parameters.AddWithValue("@Kljuc2FA", Kljuc2FA);
            command.Parameters.AddWithValue("@Username", Username);
            command.ExecuteNonQuery();
            Kljuc2FA = null;
        }

        /// <summary>
        /// Funkcija registrira korisnika u bazu podataka i vraća JSON(string) o uspješnosti  registracije
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public string RegistrirajKorisnika(SqlConnection connection)
        {
            string rezultat;
            int tip_korisnika = 1;
            UspjehRegistracije uspjeh = new UspjehRegistracije();
            uspjeh.PotvrdaKorisnika = 1;
            if (TipKorisnika == "Korisnik")
            {
                tip_korisnika = 2;
            }

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT into Korisnik (Username, Password, Ime, Prezime, Email, BrojTelefona, DatumRodjenja, Status, TipKorisnika) VALUES(@Username, @Password, @Ime, @Prezime, @Email, @BrojTelefona, @DatumRodjenja, @Status, @tip_korisnika)";
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Ime", Ime);
            command.Parameters.AddWithValue("@Prezime", Prezime);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@BrojTelefona", BrojTelefona);
            command.Parameters.AddWithValue("@DatumRodjenja", DatumRodjenja);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@tip_korisnika", tip_korisnika);
            try
            {
                command.ExecuteNonQuery();
                ZapisiKljuceveUBazu(connection);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                uspjeh.PotvrdaKorisnika = 0;
            }
            rezultat = JsonPretvarac.Serijalizacija(uspjeh);
            return rezultat;
        }

        /// <summary>
        /// Metoda koja prijavljuje korisnika u bazu podataka te vraća odgovarajuće podatke korisnika.
        /// Ukoliko korisnik prilikom registracije nije odabrao 2FA autentifikaciju vraćaju se njegovi podaci iz baze podataka.
        /// Ukoliko je korisnik prilikom registracije odabrao 2FA autentifikaciju vraća se Username,Password i obavijest o 2FA autentifikaciji u obliku korisničkoga JSON-a
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public string PrijavaKorisnika(SqlConnection connection)
        {
            string rezultat="";

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Korisnik.*,TipoviKorisnika.Naziv FROM Korisnik,TipoviKorisnika WHERE Username=@Username AND Password=@Password AND TipKorisnika=Id";
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Username", Username);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    Username = null;
                    Password = null;
                }
                else if (reader.Read())
                {
                    if (Convert.ToInt32(reader["Status"]) == 0) {
                        Username = null;
                        Password = null;
                    }
                    else
                    {
                        Username = reader["Username"].ToString();
                        Ime = reader["Ime"].ToString();
                        Prezime = reader["Prezime"].ToString();
                        Email = reader["Email"].ToString();
                        BrojTelefona = reader["BrojTelefona"].ToString();
                        DatumRodjenja = reader["DatumRodjenja"].ToString();
                        //JavniKljuc = reader["JavniKljuc"].ToString();
                        Kljuc2FA = reader["Kljuc2FA"].ToString();
                        Status = Convert.ToInt32(reader["Status"]);
                        TipKorisnika = reader["Naziv"].ToString();
                    }
                }
            }
            if (Kljuc2FA != "" && Kljuc2FA != "null")
            {
                Korisnik novi = new Korisnik();
                Verficiranje2FA verificiraj = new Verficiranje2FA();
                Kljuc2FA = verificiraj.GenerirajKljuc2FA();
                UnesiUBazuKljuc2FA(connection);
                verificiraj.PosaljiPorukuNaMobilni(BrojTelefona);
                novi.Username = Username;
                novi.Password = Password;
                novi.Kljuc2FA = "DA";
                rezultat = JsonPretvarac.Serijalizacija(novi);
                return rezultat;
            }

            rezultat = JsonPretvarac.Serijalizacija(this);
            return rezultat;
        }

        /// <summary>
        /// Metoda koja na temelju poslanih korisničkih podataka i 2FA ključa vraća praznoga korisnika(2FA ključ na bazi podataka se ne podudara)
        /// ili ako objekt sadrži ispravan 2FA ključ vraća odgovarajuće podatke koje koristi klijentska aplikacija.
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public string PotvrdaKljuca2FA(SqlConnection connection)
        {
            string rezultat = "";
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Korisnik.*,TipoviKorisnika.Naziv FROM Korisnik,TipoviKorisnika WHERE Username=@Username AND Password=@Password AND TipKorisnika=Id AND Kljuc2FA = @Kljuc2FA";
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Kljuc2FA", Kljuc2FA);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    Username = null;
                    Password = null;
                    Kljuc2FA = null;
                }
                else if (reader.Read())
                {
                    if (Convert.ToInt32(reader["Status"]) == 0)
                    {
                        Username = null;
                        Password = null;
                        Kljuc2FA = null;
                    }
                    else
                    {
                        Username = reader["Username"].ToString();
                        Ime = reader["Ime"].ToString();
                        Prezime = reader["Prezime"].ToString();
                        Email = reader["Email"].ToString();
                        BrojTelefona = reader["BrojTelefona"].ToString();
                        DatumRodjenja = reader["DatumRodjenja"].ToString();
                        Kljuc2FA = null;
                        Status = Convert.ToInt32(reader["Status"]);
                        TipKorisnika = reader["Naziv"].ToString();
                    }
                }
            }
            rezultat = JsonPretvarac.Serijalizacija(this);
            return rezultat;
        }
    }
}
