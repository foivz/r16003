using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPFileServer
{
    class FileSender
    {
        public FileSender()
        {
            var listener = new TcpListener(IPAddress.Loopback, 11000);
            listener.Start();
            while (true)
            {
                using (var client = listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                using (var output = File.Create(@"D:\CryptoFileRepo\temp"))
                {
                    Console.WriteLine("Klijent se spojio, primam file...");
                    var buffer = new byte[1024];
                    int bytesRead = 0;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                    output.Close();
                }
                string[] arr = File.ReadAllLines(@"D:\CryptoFileRepo\temp");
                string delim = arr[arr.Length-1];
                string[] podaci = delim.Split(',');
                string korisnik = podaci[0];
                string filename = podaci[1];
                Console.WriteLine(podaci[0] + "\n" + podaci[1]);
                arr[arr.Length-1] = "";
                File.WriteAllLines(@"D:\CryptoFileRepo\" + filename.Remove(0,3), arr);
                File.Delete(@"D:\CryptoFileRepo\temp");
                File.AppendAllText(@"D:\CryptoFileRepo\user_file.txt",Environment.NewLine + korisnik + "," + filename.Remove(0,3));
            }
        }
    }
}
