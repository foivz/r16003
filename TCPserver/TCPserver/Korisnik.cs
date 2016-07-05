using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPserver
{
    class Korisnik
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DatumRodjenja { get; set; }
        public int RazinaPristupa { get; set; } //moze biti 1,2,3 (ovisno je li admin,moderator,korisnik)
        public bool Aktivnost { get; set; }
    }
}
