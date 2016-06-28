using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPserver
{
    class Baza
    {
        //uzarevic treba rijesiti ovu klasu da imamo odmah metode za spajanje na bazu i izvrsavanje upita koji dolaze iz klase UpitZaBazu
        private string upit;

        public Baza(string upit)
        {
            this.upit = upit;
        }

        public void GeneriranjeOdgovora()
        {

        }
    }
}
