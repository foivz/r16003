using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPserver
{
    class Baza
    {
        //uzarevic treba rijesiti ovu klasu da imamo odmah metode za spajanje na bazu i izvrsavanje upita koji dolaze iz klase UpitZaBazu

        private string upit;

        public Baza(string upit)
        {
            this.upit = upit;
        }

        //funkcija za generiranje odgovora (provjerava korisnika u bazi)
        public int GeneriranjeOdgovora(string upit)
        {
            int odgovor = 0;
            SqlConnection connection = new SqlConnection("Server = tcp:crypto.database.windows.net,1433; Data Source = crypto.database.windows.net; Initial Catalog = CryptoBaza; Persist Security Info = False; User ID = ivauzarev; Password =crypto2101!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            using (connection)
            {
                SqlCommand command = new SqlCommand(upit, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Podaci o uspjesnoj prijavi: ");
                        Console.WriteLine("{0}\t{1}", reader.GetString(0),
                            reader.GetString(1));
                        odgovor = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Neuspjesna prijava");
                    odgovor = 0;
                }
                reader.Close();
                connection.Close();
                return odgovor;
            }
        }

        public void azuriraj(string upit)
        {
            SqlConnection connection = new SqlConnection("Server = tcp:crypto.database.windows.net,1433; Data Source = crypto.database.windows.net; Initial Catalog = CryptoBaza; Persist Security Info = False; User ID = ivauzarev; Password =crypto2101!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            connection.Open();

            SqlCommand commandUpdate = new SqlCommand(upit);
            try
            {
                commandUpdate.ExecuteNonQuery();
                Console.WriteLine("Updated");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Updated");
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
