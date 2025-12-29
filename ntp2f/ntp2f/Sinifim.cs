using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2f
{
    class Sinifim : IComparable, IEquatable<Sinifim>, IDisposable
    {
        public int CompareTo(object? obj)
        {
            return 0;
        }

        public void Dispose()
        {
            Console.WriteLine("Kaynaklar serbest bırakıldı.");
        }

        public bool Equals(Sinifim? other)
        {
            return false;
        }
    }
}
