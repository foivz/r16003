using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace CryptoNew
{
    class TcpKlijent
    {
        TcpClient klijent;
        Int32 port = 9950;
        NetworkStream stream;
        byte[] readBuffer;
        byte[] writeBuffer;

        public TcpKlijent()
        {
            try
            {
                klijent = new TcpClient();
                klijent.Connect(IPAddress.Loopback, port);
                //readBuffer = new byte[5000];
                //writeBuffer = new byte[5000];
            }
            catch (Exception)
            {
                MessageBox.Show("Ne mogu se spojiti na web servis, pokušajte ponovo!");
            }
        }

        public void PosaljiServeru(object objekt, string tipPoruke = "null")
        {
            try
            {
                stream = klijent.GetStream();
                string jsonString = JsonPretvarac.Serijalizacija(objekt,tipPoruke);
                int length = Encoding.ASCII.GetBytes(jsonString).Length;
                writeBuffer = new byte[length];
                writeBuffer = Encoding.ASCII.GetBytes(jsonString);
                stream.Write(writeBuffer, 0, writeBuffer.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi oko komunikacije sa web servisom, pokušajte ponovo");
            }
            stream.Flush();
        }

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
                    myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(readBuffer, 0, numberOfBytesRead));
                } while (stream.DataAvailable);
                //stream.Read(readBuffer, 0, readBuffer.Length);
                stream.Close();
                string jsonString = myCompleteMessage.ToString();
                trenutni = JsonPretvarac.Deserijalizacija(jsonString);
                stream.Flush();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi oko komunikacije sa web servisom, pokušajte ponovo");
            }
            return trenutni;
        }

        public void ZatvoriSocket()
        {
            klijent.Close();
        }
    }
}
