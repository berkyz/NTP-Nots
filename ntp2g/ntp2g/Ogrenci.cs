using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2g
{
    class Ogrenci : IOuter
    {
        private int yas;

        public int Yas
        {
            get { return yas; }
            set { if(value>0 && value <65) yas = value; }
        }

        public int CompareTo(object? obj)
        {
            Ogrenci other = obj as Ogrenci;
            if(other == null) return 1;
            if(other.Yas == this.Yas) return 0;
            return -1;
        }

        public void OuterMethod()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
