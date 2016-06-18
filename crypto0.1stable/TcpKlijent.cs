using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace crypto0._1stable
{
    class TcpKlijent
    {
        TcpClient klijent;
        Int32 port = 9900;
        NetworkStream stream;
        byte[] readBuffer;
        byte[] writeBuffer;

        public TcpKlijent()
        {
            klijent = new TcpClient();
            klijent.Connect(IPAddress.Loopback, port);
            readBuffer = new byte[1024];
            writeBuffer = new byte[1024];
        }

        public void PosaljiServeru(byte[] poruka)
        {
            stream = klijent.GetStream();
            writeBuffer = poruka;
            stream.Write(writeBuffer, 0, writeBuffer.Length);
            stream.Close();
        }

        public byte[] PrimiOdServera()
        {
            stream = klijent.GetStream();
            stream.Read(readBuffer, 0, readBuffer.Length);
            stream.Close();
            return readBuffer;
        }

        public void ZatvoriSocket()
        {
            klijent.Close();
        }
    }
}
