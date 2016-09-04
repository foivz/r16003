using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chatservis
{
    class ObradiKlijenta
    {
        private TcpClient klijent;
        NetworkStream stream;
        byte[] writeBuffer;
        byte[] readBuffer;
        string primljenaPoruka;
        List<TcpClient> listaKlijenata;

        public ObradiKlijenta(TcpClient klijent, List<TcpClient> listaKlijenata)
        {
            this.klijent = klijent;
            this.listaKlijenata = listaKlijenata;
        }

        public void CitajSaStreama()
        {
            Thread dretvaZaCitanje = new Thread(new ParameterizedThreadStart(DretvaZaCitanje));
            dretvaZaCitanje.Start(klijent);
        }

        private void DretvaZaCitanje(object client)
        {
            while (true)
            {
                Console.WriteLine("Spojen");
                primljenaPoruka = "";
                readBuffer = new byte[1024];
                TcpClient klijent = (TcpClient)client;
                stream = klijent.GetStream();
                stream.Read(readBuffer, 0, readBuffer.Length);
                stream.Flush();
                primljenaPoruka = Encoding.ASCII.GetString(readBuffer);
                ProslijediPoruku(primljenaPoruka);
            }
        }

        private void ProslijediPoruku(string poruka)
        {
            foreach (TcpClient item in listaKlijenata)
            {
                TcpClient socketZaSlanje = item;
                NetworkStream networkstream = socketZaSlanje.GetStream();
                //Console.WriteLine(primljenaPoruka);
                writeBuffer = new byte[1024];
                writeBuffer = readBuffer;
                networkstream.Write(readBuffer, 0, readBuffer.Length);
                networkstream.Flush();
            }
        }
    }
}
