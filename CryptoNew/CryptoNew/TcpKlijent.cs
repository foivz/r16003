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
        Int32 port = 9900;
        NetworkStream stream;
        byte[] readBuffer;
        byte[] writeBuffer;

        public TcpKlijent()
        {
            try
            {
                klijent = new TcpClient();
                klijent.Connect(IPAddress.Loopback, port);
                readBuffer = new byte[1024];
                writeBuffer = new byte[1024];
            }
            catch (Exception)
            {
                MessageBox.Show("Ne mogu se spojiti na web servis, pokušajte ponovo!");
            }
        }

        public void PosaljiServeru(object objekt)
        {
            try
            {
                stream = klijent.GetStream();
                string jsonString = JsonPretvarac.Serijalizacija(objekt);
                writeBuffer = Encoding.ASCII.GetBytes(jsonString);
                stream.Write(writeBuffer, 0, writeBuffer.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi oko komunikacije sa web servisom, pokušajte ponovo");
            }
        }

        public object PrimiOdServera()
        {
            try
            {
                stream = klijent.GetStream();
                stream.Read(readBuffer, 0, readBuffer.Length);
                stream.Close();
                string jsonString = Encoding.ASCII.GetString(readBuffer);
                object trenutniObjekt = JsonPretvarac.Deserijalizacija(jsonString);
                return trenutniObjekt;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi oko komunikacije sa web servisom, pokušajte ponovo");
                return null;
            }
        }

        public void ZatvoriSocket()
        {
            klijent.Close();
        }
    }
}
