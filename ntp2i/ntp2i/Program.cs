using ntp2i.Model;

namespace ntp2i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Ogretmen ogretmen = new Ogretmen();

            ogrenci.Konus();
            ogretmen.Konus();

            ogrenci.Oku();
            ogretmen.Oku();

            //OkuyanInsan okuyanInsan = new OkuyanInsan();
            //okuyanInsan.Oku();

            OkuyanInsan ogrenci2 = new Ogrenci();
            OkuyanInsan ogretmen2 = new Ogretmen();

            IInsan spiker = new Spiker() { Kanal="TRT"};
            // IInsan.Konus("Alper");

            IInsan birInsan = new Spiker();
            birInsan = spiker;
            birInsan.Konus("fATİH");
            Console.WriteLine( birInsan.Ad);
            // Console.WriteLine(birInsan.Kanal);
            // birInsan.Tanit();
            // spiker = birInsan;
            // Console.WriteLine(Mantik.True);
            IInsan.Isim isim = new IInsan.Isim();
            isim.OnAd = "Alper";
            isim.GobekAdi = "İlhan";
            isim.SoyAd = "Gülbe";

            IInsan.Bebek bebek = new();


        }
    }
}
