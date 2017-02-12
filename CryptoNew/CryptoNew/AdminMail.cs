using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNew
{
    class AdminMail
    {
        public string Tip { get; set; }
        public string Sadrzaj { get; set; }
        public int Status { get; set; }

        public AdminMail()
        {
            Tip = "AdminMail";
        }
    }
}
