using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2g
{
    class Daire : IComparable
    {
        public double Cap { get; set; }
        internal int CompareTo(object? obj)
        {
            Daire? daire = obj as Daire;
            return (daire?.Cap == this.Cap) ? 0 : -1;
        }

        int IComparable.CompareTo(object? obj)
        {
            return CompareTo(obj);
        }
    }
}
