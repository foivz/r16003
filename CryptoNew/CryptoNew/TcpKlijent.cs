﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace CryptoNew
{
    /// <summary>
    /// Klasa koja prefstavlja TCP klijenta - sadrži metode za slanje podataka prema serveru i primanje podataka sa servera
    /// </summary>
    class TcpKlijent
    {
        TcpClient klijent;
        Int32 port = 9950;
        NetworkStream stream;
        byte[] readBuffer;
        byte[] writeBuffer;

        /// <summary>
        /// Konstruktor klase TcpKlijent
        /// </summary>
        public TcpKlijent()
        {
            try
            {
                klijent = new TcpClient();
                klijent.Connect(IPAddress.Loopback, port);
            }
            catch (Exception)
            {
                //MessageBox.Show("Ne mogu se spojiti na web servis, pokušajte ponovo!");
            }
        }

        /// <summary>
        /// Metoda koja šalje serveru objekt - taj objekt serijalizira u json te ga zapisuje na stream sa kojega server
        /// može pročitati podatke.
        /// </summary>
        /// <param name="objekt"></param>
        /// <param name="tipPoruke"></param>
        public void PosaljiServeru(object objekt, string tipPoruke = "null")
        {
            try
            {
                stream = klijent.GetStream();
                string jsonString = JsonPretvarac.Serijalizacija(objekt,tipPoruke);
                int length = Encoding.UTF8.GetBytes(jsonString).Length;
                writeBuffer = new byte[length];
                writeBuffer = Encoding.UTF8.GetBytes(jsonString);
                stream.Write(writeBuffer, 0, writeBuffer.Length);
            }
            catch (Exception)
            {
                //MessageBox.Show("Problemi oko komunikacije sa web servisom, pokušajte ponovo kasnije");
                return;
            }
            stream.Flush();
        }

        /// <summary>
        /// Metoda koja prima json od servera u chunkovima te konsturira kompletnu poruku sve dok su podaci na streamu dohvatljivi.
        /// Deserijalizira json u odgovarajući podatkovni objekt.
        /// </summary>
        /// <returns></returns>
        public object PrimiOdServera()
        {
            readBuffer = new byte[1024];
            int numberOfBytesRead = 0;
            StringBuilder myCompleteMessage = new StringBuilder();
            object trenutni = null;
            try
            {
                stream = klijent.GetStream();
                do
                {
                    numberOfBytesRead = stream.Read(readBuffer, 0, readBuffer.Length);
                    stream.Flush();
                    myCompleteMessage.AppendFormat("{0}", Encoding.UTF8.GetString(readBuffer, 0, numberOfBytesRead));
                } while (stream.DataAvailable);
                stream.Close();
                string jsonString = myCompleteMessage.ToString();
                trenutni = JsonPretvarac.Deserijalizacija(jsonString);
                stream.Flush();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi oko komunikacije sa web servisom, pokušajte ponovo kasnije");
            }
            return trenutni;
        }

        /// <summary>
        /// Metoda koja zatvara otvoreni socket između klijenta i servera
        /// </summary>
        public void ZatvoriSocket()
        {
            klijent.Close();
        }
    }
}
