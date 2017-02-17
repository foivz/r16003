using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServis
{
    class ObradiKlijenta
    {
        private TcpClient klijent;
        NetworkStream stream;
        byte[] writeBuffer;
        byte[] readBuffer;
        string primljenaPoruka;
        List<TcpClient> listaKlijenata;
        Thread dretvaZaCitanje;

        public ObradiKlijenta(TcpClient klijent, List<TcpClient> listaKlijenata)
        {
            this.klijent = klijent;
            this.listaKlijenata = listaKlijenata;
        }

        public void CitajSaStreama()
        {
            dretvaZaCitanje = new Thread(new ParameterizedThreadStart(DretvaZaCitanje));
            dretvaZaCitanje.Start(klijent);
        }

        private void DretvaZaCitanje(object client)
        {
            while (true)
            {
                try
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
                catch (Exception ex)
                {
                    listaKlijenata.Remove(klijent);
                    dretvaZaCitanje.Abort();
                    break;
                }
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
