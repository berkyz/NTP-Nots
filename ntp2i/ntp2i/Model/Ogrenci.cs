using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2i.Model
{
    sealed class Ogrenci : OkuyanInsan
    {
        public override void Konus()
        {
            Console.WriteLine("Merhaba, ben bir öğrenciyim.");
        }
    }
}
