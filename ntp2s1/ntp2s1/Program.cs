using System.Collections.Generic;

namespace ntp2s1
{
    internal class Program
    {
        public struct Nokta
        {
            public int X;
            public int Y;

            public Nokta(int x, int y)
            {
                X = x; Y=y;
            }

            public override readonly string ToString()
            {
                return "("+X+", "+Y+")";
            }
        }

        public static T Topla<T> (T x, T y)
        {
            // if(x is Int32 || x is Double || x is Decimal) ...

            dynamic sayi1 = x;
            dynamic sayi2 = y;
            return (T)(sayi1+sayi2);
        }


        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Berk");
            list.Add("Yazılım Mühendisliği");
            list.Add("3");
            // list.Add(true);
            // list.Add(500);
            // list.Add('A');

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci() { Ad = "Berk", Numara = 17 });

            var ogr = new Ogrenci();
            ogr.Ad = "Mikail";
            ogr.Numara = 34;
            ogrenciler.Add(ogr);


            List<Nokta> noktalar = new List<Nokta>();
            noktalar.Add(new Nokta(1, 3));
           
            Nokta nokta = new Nokta(2, -3);
            noktalar.Add(nokta);

            Console.WriteLine(Topla(15, 20));
            Console.WriteLine(Topla(15.75F, 20.75F));
            Console.WriteLine(Topla(1.23456778909M, 3.123456789M));
            Console.WriteLine(Topla("Berk"," Yılmaz"));

            List<int> sayilar = new() {2, 3, 5, 7, 11, 13, 17, 19};

            Console.WriteLine(new String('-', 20));
            foreach (var oge in sayilar)  // int
                Console.WriteLine(oge);

            Console.WriteLine(new String('-', 20));
            foreach (var oge in list)  // string
                Console.WriteLine(oge);

            Console.WriteLine(new String('-', 20));
            foreach (var oge in noktalar) // struct: Nokta
                Console.WriteLine(oge);

            Console.WriteLine(new String('-', 20));
            foreach (var oge in ogrenciler)  // class: Ogrenci
                Console.WriteLine(oge);

            Console.WriteLine(new String('-', 20));
            Console.WriteLine(ogrenciler[1]);
            // ogrenciler[2] = new Ogrenci() {Numara=25, Ad="Emir Can" };
            ogrenciler.Add(null);
            ogrenciler[2] = new Ogrenci() { Numara = 25, Ad = "Emir Can" };

            Console.WriteLine(new String('-', 20));
            foreach (var oge in ogrenciler)  // class: Ogrenci
                Console.WriteLine(oge);

            Console.WriteLine(new String('-', 20));
            for(int i=0;i<ogrenciler.Count;i++)
                Console.WriteLine(""+i+": "+ogrenciler[i]);

            ogrenciler.Reverse();
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < ogrenciler.Count; i++)
                Console.WriteLine("" + i + ": " + ogrenciler[i]);

            ogrenciler.Insert(1, new Ogrenci() {Numara=30, Ad="Ahmet"});
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < ogrenciler.Count; i++)
                Console.WriteLine("" + i + ": " + ogrenciler[i]);

            var kayitDonduranOgrenciler = new List<Ogrenci>();
            kayitDonduranOgrenciler.Add(new Ogrenci() { Numara = 33, Ad = "Şeyhmus" });
            kayitDonduranOgrenciler.Add(new Ogrenci() { Numara = 4, Ad = "Cevat Han" });

            // ogrenciler.AddRange(kayitDonduranOgrenciler);
            ogrenciler.InsertRange(2, kayitDonduranOgrenciler);
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < ogrenciler.Count; i++)
                Console.WriteLine("" + i + ": " + ogrenciler[i]);

            ogrenciler.Clear();
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < ogrenciler.Count; i++)
                Console.WriteLine("" + i + ": " + ogrenciler[i]);

            Ogrenci[] ogrDizisi = new Ogrenci[kayitDonduranOgrenciler.Count];
             kayitDonduranOgrenciler.CopyTo(ogrDizisi);
            for(int i=0; i<ogrDizisi.Length; i++)
                Console.WriteLine(ogrDizisi[i]);

            ogrenciler = new List<Ogrenci>(ogrDizisi);
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < ogrenciler.Count; i++)
                Console.WriteLine("" + i + ": " + ogrenciler[i]);

            var aranan = sayilar[5];
            if(sayilar.Contains(aranan))
                Console.WriteLine($"{aranan} dizide var ve {sayilar.IndexOf(aranan)}. sırada yer alıyor.");
            else
                Console.WriteLine($"{aranan} dizide yok.");

            int sinir = 20;
            if(sayilar.TrueForAll(oge => oge < sinir))
                Console.WriteLine($"Bütün öğeler {sinir}'dan küçüktür.");
            else
                Console.WriteLine($"Bazı öğeler {sinir} veya {sinir}'dan büyüktür.");

            string metin = string.Join("\t", list);
            Console.WriteLine(metin);
        }
    }
}
