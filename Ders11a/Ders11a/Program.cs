namespace Ders11a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba araba = new Araba(); // örnekleme, instantiation
            //var araba2 = new Araba() { ModelYili=2024};
            //Araba araba3 = new();

            //araba.Marka = "TOGG";
            //araba.Model = "TX10";
            //araba.ModelYili = 2025;

            //Console.WriteLine(araba.Marka+" " +araba.Model);
            Console.WriteLine($"Piyasadaki taksi sayısı: {Taksi.Sayisi}");
            Taksi taksi = new Taksi(60, 12.75m, "TOGG", "TX10", 2024);
            Console.WriteLine(taksi.ToString());
            Console.WriteLine($"Piyasadaki taksi sayısı: {Taksi.Sayisi}");

            var taxi = new Taksi(75, 20, "Mercedes", "E200", 2024);
            Console.WriteLine(taxi.ToString());
            Console.WriteLine($"Bu taxi ile 20 km giderseniz {taxi.UcretHesapla(20)} ₺ ödersiniz.");
            Console.WriteLine($"Piyasadaki taksi sayısı: {Taksi.Sayisi}");

            Console.WriteLine($"Açılış fiyatı 50₺, Birim Fiyatı 12.50₺ iken 20 km yol alırsanız taksi size {Taksi.Ucret(50, 12.5m, 20)} ₺ yazar.");

            Console.WriteLine($"Yarıçapı 10 cm olan dairenin alanı: {Geometri.DaireninAlani(10)} cm²");
            Console.WriteLine($"Yarıçapı 10 cm olan dairenin çevresi: {Geometri.DaireninCevresi(10)} cm");

            Console.WriteLine(Global.TamYol);

            var alperHoca = new { Adi = "Alper", Soyadi = "Gülbe", Dersi = "NDP" };
            var sedaHoca = new { Adi = "Seda", Soyadi = "TÜRK", Dersi = "VYA" };

            Console.WriteLine(alperHoca.Adi+" "+alperHoca.Soyadi);
            Console.WriteLine(sedaHoca.Adi  +" "+sedaHoca.Soyadi);

            VipTaksi vip = new(2000, 100, "Cadillac", "ETX", 2024);
            vip.MiniBar = true;
            Console.WriteLine(vip.ToString());

            object nesne1 = new Taksi(2000, 100, "Cadillac", "ETX", 2024);
            object nesne2 = new Araba();
            object nesne3 = new VipTaksi(2000, 100, "Cadillac", "ETX", 2024);
            Taksi myTaksi = nesne1 as Taksi;
            Console.WriteLine(Geometri.KareninCevresi(10.5));
        }
    }
}
