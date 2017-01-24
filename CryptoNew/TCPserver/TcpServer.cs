using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TCPserver
{
    class TcpServer
    {
        TcpListener listener;
        TcpClient klijent;
        NetworkStream stream;
        //string testPoruka = "Test poruka poslana";
        //List<string> podaci;
        byte[] writeBuffer;
        byte[] readBuffer;
        string primljenaPoruka;

        private string[] tipoviPoruka = {
            "PRIJAVA",
            "REGISTRACIJA"
        };

        public void PokreniListener()
        {
            Console.WriteLine("SERVER POKRENUT!!!");
            /*
            CryptoNew.Enkripcija enkripcija = new CryptoNew.RsaEnkripcija();
            enkripcija.AssignRsaKeys();
            var original = enkripcija.EncryptData(Encoding.UTF8.GetBytes("sto je danas lijep i sunčan dan"));
            var DEKRIPTIRANO = enkripcija.DecryptData(original);
            Console.WriteLine(Encoding.UTF8.GetBytes(enkripcija.PrikazEnkriptiranihPodataka(original)).Length);
            Console.WriteLine(enkripcija.PrikazEnkriptiranihPodataka(original));
            Console.WriteLine();
            Console.WriteLine(DEKRIPTIRANO);
            */
            CryptoNew.Enkripcija enkripcija = new CryptoNew.AesEnkripcija();
            enkripcija.GenerirajKljucIV();
            var original = enkripcija.EncryptData("sto je danas lijep i sunčan dan");
            Console.WriteLine(enkripcija.PrikazEnkriptiranihPodataka(original));
            var dekriptirano = enkripcija.DecryptData(original);
            Console.WriteLine(dekriptirano);

            listener = new TcpListener(IPAddress.Any, 9950);
            Thread dretvaZaListen = new Thread(OsluskujPort);
            dretvaZaListen.Start(listener);
        }

        void OsluskujPort(object listen)
        {
            listener = (TcpListener)listen;
            listener.Start();
            while (true)
            {
                klijent = listener.AcceptTcpClient();
                //Console.WriteLine("Spojen");
                ObradiKlijenta(klijent);
            }
        }

        void ObradiKlijenta(TcpClient klijent)
        {
            writeBuffer = new byte[1024];
            readBuffer = new byte[1024];
            StringBuilder myCompleteMessage = new StringBuilder();
            int numberOfBytesRead = 0;
            string klijentPodaciString = "test";

            stream = klijent.GetStream();
            if (stream.CanRead)
            {
                do
                {
                    numberOfBytesRead = stream.Read(readBuffer, 0, readBuffer.Length);
                    stream.Flush();
                    myCompleteMessage.AppendFormat("{0}", Encoding.UTF8.GetString(readBuffer, 0, numberOfBytesRead));
                } while (stream.DataAvailable);
                primljenaPoruka = myCompleteMessage.ToString();
                IspisiPorukuPrihvata(primljenaPoruka);
                klijentPodaciString = ObradaPoruke(primljenaPoruka);
            }
            if (stream.CanWrite)
            {
                if (!klijentPodaciString.StartsWith("test"))
                {
                    IspisiPorukuSlanja(klijentPodaciString);
                    writeBuffer = Encoding.UTF8.GetBytes(klijentPodaciString);
                    stream.Write(writeBuffer, 0, writeBuffer.Length);
                    stream.Flush();
                }
                else
                {

                }
            }
        }

        public string ObradaPoruke(string json)
        {
            string result = "";
            if (tipoviPoruka.Contains(CryptoNew.JsonPretvarac.Parsiranje(json, "tipPoruke")))
            {
                result = BazaManager.IzvrsiUpitNaBazi(json);
                return result;
            }
            result = "Greska na serveru";
            return result;
        }

        private void IspisiPorukuSlanja(string poruka)
        {
            Console.WriteLine("SERVER SALJE...");
            Console.WriteLine(poruka);
            Console.WriteLine();
        }

        private void IspisiPorukuPrihvata(string poruka)
        {
            Console.WriteLine("SERVER PRIMA...");
            Console.WriteLine(poruka);
            Console.WriteLine();
        }
    }
}
