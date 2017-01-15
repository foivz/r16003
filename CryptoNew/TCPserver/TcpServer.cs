﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

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
            "LOGIN",
            "REGISTER",
            "C2C",
            "PRUPDATE",
            "DOHVATIKLIJENTE",
            "CITANJEPORUKE",
            "OTKZAK",
            "UPDOTKLJUCAJ",
            "2FA",
            "PROVJERIKLJUC"
        };

        public void PokreniListener()
        {
            listener = new TcpListener(IPAddress.Any, 9900);
            Thread dretvaZaListen = new Thread(new ParameterizedThreadStart(OsluskujPort));
            dretvaZaListen.Start(listener);
        }

        void OsluskujPort(object listen)
        {
            listener = (TcpListener)listen;
            listener.Start();
            while (true)
            {
                klijent = listener.AcceptTcpClient();
                Console.WriteLine("Spojen");
                ObradiKlijenta(klijent);
            }
        }

        void ObradiKlijenta(TcpClient klijent)
        {
            writeBuffer = new byte[1900];
            readBuffer = new byte[1900];
            List<string> klijentPodaci = new List<string>();
            string klijentPodaciString = "";
            stream = klijent.GetStream();
            if (stream.CanRead)
            {
                stream.ReadAsync(readBuffer, 0, readBuffer.Length);
                primljenaPoruka = Encoding.ASCII.GetString(readBuffer); //byte poruka
                Console.WriteLine("Primljena poruka:  " + primljenaPoruka);
                klijentPodaciString = ObradaPoruke(primljenaPoruka);
                stream.Flush();
            }
            if (stream.CanWrite)
            {
                if (klijentPodaci.Count > 0)
                {
                    writeBuffer = Encoding.ASCII.GetBytes(klijentPodaciString);
                    stream.Write(writeBuffer, 0, writeBuffer.Length);
                    stream.Flush();
                }
                else
                {
                    writeBuffer = Encoding.ASCII.GetBytes("Netocni podaci");
                    stream.Write(writeBuffer, 0, writeBuffer.Length);
                    stream.Flush();
                }
            }
        }

        public string ObradaPoruke(string poruka)
        {
            string result = "";
            if (tipoviPoruka.Contains(CryptoNew.JsonPretvarac.Parsiranje(poruka, "tipPoruke")))
            {
                return result;
            }
            result = "Greska na serveru";
            return result;
        }
    }
}
