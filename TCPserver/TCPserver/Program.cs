using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TCPserver
{
    class Program
    {
        static void Main(string[] args)
        {
            string poruka = "";
            TCPserver server = new TCPserver();
            server.PokreniListener();
        }
    }
}
