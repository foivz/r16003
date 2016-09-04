using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chatservis
{
    class PrihvatiKlijenta
    {
        TcpListener listener;
        TcpClient klijent;
        List<TcpClient> listaKlijenata = new List<TcpClient>();
        byte[] readBuffer;
        byte[] writeBuffer;
        string[] poruke;
        string poruka;

        public void PokreniListener()
        {
            listener = new TcpListener(IPAddress.Any, 6123);
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
                NetworkStream streamZaPodatke = klijent.GetStream();
                readBuffer = new byte[1024];
                streamZaPodatke.Read(readBuffer, 0, readBuffer.Length);
                streamZaPodatke.Flush();
                poruka = Encoding.ASCII.GetString(readBuffer);
                if (!listaKlijenata.Contains(klijent)) listaKlijenata.Add(klijent);
                writeBuffer = Encoding.ASCII.GetBytes(poruka);
                foreach (TcpClient item in listaKlijenata)
                {
                    streamZaPodatke = item.GetStream();
                    streamZaPodatke.Write(writeBuffer, 0, writeBuffer.Length);
                    streamZaPodatke.Flush();
                }
                ObradiKlijenta obrada = new ObradiKlijenta(klijent, listaKlijenata);
                obrada.CitajSaStreama();
            }
        }
    }
}
