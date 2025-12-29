using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2i.Model
{
    abstract class OkuyanInsan
    {
        public /* abstract */ void Oku()
        {
            Console.WriteLine("Ben okuyabilirim.");
        }

        public abstract void Konus();
    }
}
