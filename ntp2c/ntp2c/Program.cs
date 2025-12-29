namespace ntp2c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var ogrenci = new Ogrenci();
            // Ogrenci ogrenci = new Ogrenci("Yusuf", 3, 3.52);
            //Ogrenci ogrenci = new Ogrenci("Abdülselam", 3, 3.5);
            //var ogrenci = new Ogrenci() { Ad = "Mısra", Gano = 3.4, Sinif = 3 };
            //Console.WriteLine(ogrenci.ToString());

            //object nesne = new object();

            //YazilimOgrencisi cevat = new YazilimOgrencisi("Cevat Han ALKAŞİ", 3, 3.6, "Laptop i7 12. Nesil CPU, 16 GB RAM, 1 TB SSD, Nvidia 3050 GPU");
            //Console.WriteLine(cevat.ToString());

            List<Ders> ivirzirir = new List<Ders>();
            ivirzirir.Add(new Ders { Ad = "PT", Akts = 6, BasariNotu = 3.5 });
            ivirzirir.Add(new Ders { Ad = "GA1", Akts = 4, BasariNotu = 3 });
            ivirzirir.Add(new Ders { Ad = "OY", Akts = 4, BasariNotu = 4 });
            ivirzirir.Add(new Ders { Ad = "WE", Akts = 3, BasariNotu = 2.5 });

            Console.WriteLine( Ogrenci.GanoHesapla(ivirzirir));
        }
    }
}
