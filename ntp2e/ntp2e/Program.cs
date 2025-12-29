using System.Net.Http.Headers;

namespace ntp2e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Varlik nesne = new Varlik();
            //Console.WriteLine(nesne.GetType());
            //Console.WriteLine(nesne.GetHashCode());
            //Console.WriteLine(nesne.ToString());

            //var baskaNesne = new Varlik();
            //Console.WriteLine(baskaNesne.GetHashCode());
            //Console.WriteLine(nesne.Equals(baskaNesne));

            //Console.WriteLine(Object.Equals(nesne, baskaNesne));

            Ogrenci ogr;          // tanımlama
            ogr = new Ogrenci();  // örnekleme

            Insan cevat = new Ogrenci();
            //  Ogrenci mikail = new Insan();
            Ogrenci berk = new();
            cevat = berk;
            // berk = cevat;

            Console.WriteLine(Object.Equals(cevat, berk));

            Console.WriteLine($"Cevat'ın Boyu:{cevat.Boy}  Kütlesi:{cevat.Kutle}");
            cevat.Buyu();
            Console.WriteLine($"Cevat'ın Boyu:{cevat.Boy}  Kütlesi:{cevat.Kutle}");
            //Console.WriteLine(cevat.OkulNo);

            Console.WriteLine($"Berk'in Boyu:{berk.Boy}  Kütlesi:{berk.Kutle}");
            berk.Buyu();
            Console.WriteLine($"Berk'in Boyu:{berk.Boy}  Kütlesi:{berk.Kutle}");
            Console.WriteLine(berk.OkulNo);

            Console.WriteLine($"Cevat'ın Boyu:{cevat.Boy}  Kütlesi:{cevat.Kutle}");

            List<Insan> liste = new List<Insan>();
            liste.Add(cevat);
            liste.Add(berk);

            foreach(Insan insan in liste)
                Console.WriteLine(insan.GetType());


            var kare = new Kare(10);
            var dikdortgen = new Dikdortgen(10, 20);
            var daire = new Daire(10);
            var elips = new Elips(10, 20);
            var paralelkenar = new ParalelKenar(10, 20);
            var ucgen = new Ucgen(10, 20);

            List<Sekil> listem = new List<Sekil>();
            listem.Add(kare);
            listem.Add(dikdortgen);
            listem.Add(daire);
            listem.Add(elips);
            listem.Add(ucgen);
            listem.Add(paralelkenar);

            foreach (Sekil sekil in listem)
                Console.WriteLine(sekil.GetType().ToString() +": "+ sekil.Alan());

        }
    }
}
