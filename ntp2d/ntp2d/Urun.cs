using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2d
{
    class Urun
    {
        static int Kod = 10000;
        public int UrunKodu { get; set; }
        public Urun()
        {
            Kod++;
            UrunKodu = Kod;
        }
    }
}
