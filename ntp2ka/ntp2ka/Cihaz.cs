using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2ka
{
    class Cihaz
    {
        public delegate string Temsilci ();
        Temsilci temsilci;
        public Cihaz()
        {
            temsilci = new Temsilci(Kapat);
        }

        private string Ac()
        {
            temsilci = Kapat;
            return "Cihaz çalışıyor.";
        }

        private string Kapat()
        {
            temsilci = Ac;
            return "Cihaz kapatıldı.";
        }

        public string Kontrol()
        {
            return temsilci();
        }
    }
}
