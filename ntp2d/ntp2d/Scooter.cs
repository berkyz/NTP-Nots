using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2d
{
    class Scooter: IDisposable
    {
        public static int Count = 0;
        public Scooter()
        {
            Count++;
        }

        public void Dispose()
        {
            Count--;
        }
    }
}
