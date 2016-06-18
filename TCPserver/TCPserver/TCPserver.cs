using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace TCPserver
{
    class TCPserver
    {
        TcpListener listener;
        TcpClient klijent;
        NetworkStream stream;
        string testPoruka = "Test poruka poslana";
        byte[] writeBuffer;
        byte[] readBuffer;
        string primljenaPoruka;

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
            writeBuffer = new byte[1024];
            readBuffer = new byte[1024];
            stream = klijent.GetStream();
            if (stream.CanRead)
            { 
                stream.ReadAsync(readBuffer, 0, readBuffer.Length);
                primljenaPoruka = Encoding.ASCII.GetString(readBuffer);
                Console.WriteLine(primljenaPoruka);
                //Enkriptiraj poruku()
                ObradaPoruke obrada = new ObradaPoruke(readBuffer);
                stream.Flush();
            }
            if (stream.CanWrite)
            {
                writeBuffer = Encoding.ASCII.GetBytes(testPoruka);
                stream.Write(writeBuffer, 0, writeBuffer.Length);
                stream.Flush();
            }
        }
    }
}
