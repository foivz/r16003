using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
                TcpListener listener = new TcpListener(IPAddress.Loopback, 12000);
               
                listener.Start();
            
                TcpClient client = listener.AcceptTcpClient();

               
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                
                string username = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine(username);
            //tu mogu slati datoteku preko clienta

            //pretraži user_file za username i vrati datoteku s tim imenom
                
            }
    }
}
