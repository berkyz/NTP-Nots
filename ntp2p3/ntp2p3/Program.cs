using System.Collections;
namespace ntp2p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable tablo = new Hashtable();
            ////    Anahtar (Key)  Değer (value)
            //tablo[2301060025] = "Emir Can KILIÇ";
            //tablo[3.14] = "Pi sayısı";
            //tablo['A'] = 65;
            //tablo[1] = "Galatasaray";
            //tablo[-90] = -67.778;

            //// Console.WriteLine(tablo['A']);

            //foreach (var s in tablo.Keys)
            //    Console.WriteLine(tablo[s]);
            Ogrenci ogr1 = new Ogrenci() { Numara = 23601060036, Ad = "Fatma", Bolum = "Yazılım", Gano = 3.35 };
            tablo[ogr1.Numara] = ogr1;
            Ogrenci ogr2 = new Ogrenci() { Numara = 23601060034, Ad = "Mikail", Bolum = "Yazılım", Gano = 3.65 };
            tablo[ogr2.Numara] = ogr2;
            Ogrenci ogr3 = new Ogrenci() { Numara = 23601060030, Ad = "Ahmet", Bolum = "Yazılım", Gano = 2.95 };
            tablo[ogr3.Numara] = ogr3;
            Ogrenci ogr4 = new Ogrenci() { Numara = 23601060017, Ad = "Berk", Bolum = "Yazılım", Gano = 3.11 };
            tablo[ogr4.Numara] = ogr4;

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("  > Anahtarlara göre ...");
            foreach (var ogr in tablo.Keys)
            {
                Ogrenci ogrenci = tablo[ogr] as Ogrenci;
                Console.WriteLine(ogrenci.ToString());
                Console.WriteLine(ogr.GetHashCode());
            }

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("  > Değerlere göre...");
            foreach (var oge in tablo.Values)
                Console.WriteLine(oge);


            Console.WriteLine(new String('-', 40));
            Console.WriteLine("  > Anahtar-değer çiftine göre...");
            foreach (DictionaryEntry oge in tablo)
            {
                Console.WriteLine("Anahtar: "+oge.Key+"  Değer: "+oge.Value);
            }
            Console.WriteLine(new String('-', 40));
            long aranan = 2301060033;
            if (tablo.Contains(aranan))
                Console.WriteLine($"Evet, tablo {aranan} anahatarını içeriyor.");
            else
                Console.WriteLine($"Hayır, tablo {aranan} anahatarını içermiyor.");
        }
    }
}
