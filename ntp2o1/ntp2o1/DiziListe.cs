using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2o1
{
    class DiziListe:IEnumerable
    {
        private object[] dizi;
        private int capacity = 5;
        private int size;

        public DiziListe()
        {
            dizi = new object[capacity];
            size = 0;
        }

        public DiziListe(int c)
        {
            capacity = c;
            dizi = new object[c];
            size = 0;
        }

        public DiziListe(ICollection k)
        {
            int n = k.Count;
            size = n;
            dizi = new object[n];
            int i = 0;
            foreach (var oge in k)
                dizi[i++] = oge;
        }

        public void Ekle(object x)
        {
            if (size < capacity)
                dizi[size++] = x;
            else
            {
                capacity *= 2;
                size++;
                object[] dummy = new object[capacity];
                int i = 0;
                foreach(var oge in dizi)
                    dummy[i++] = oge;
                dummy[i] = x;
                dizi = dummy;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < size; i++)
                yield return dizi[i];
        }

        public object this[int i] => dizi[i];

        public int Sayi {  get { return size; } }

    }
}
