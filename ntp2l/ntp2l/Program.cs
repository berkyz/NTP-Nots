using System.Threading.Channels;

namespace ntp2l
{
    internal class Program
    {
        private static void SiparisVer(object sender, EventArgs e)
        {
            Urun urun = sender as Urun;
            int siparis = urun.KritikStokSeviyesi - urun.StokMiktari;
            Console.WriteLine($"{urun.Ad} adlı üründen {siparis} adet sipariş verildi.");
            urun.StokMiktari += siparis;        
        }
        static void Main(string[] args)
        {
            string islem = "";
            int adet;
            bool devam = true;
            Urun urun = new Urun("Defter", 10, 5);
            urun.StokBitti += SiparisVer;  // Olaya abome olma
            do
            {
                Console.WriteLine(urun.ToString());
                Console.Write(@"
MENÜ
-------------
1 Al
2 Sat
3 Çık

İşleminiz: ");
                islem = Console.ReadLine();
                switch (islem)
                {
                    case "1":
                        Console.Write("Kaç tane satın aldınız: ");
                        adet = int.Parse(Console.ReadLine());
                        urun.Al(adet);
                        break;
                    case "2":
                        Console.Write($"Kaç tane sattınız:[{urun.StokMiktari} adetten az olmalıdır.] ");
                        adet = int.Parse(Console.ReadLine());
                        urun.Sat(adet);
                        break;
                    case "3":
                        devam = false;
                        break;
                    default:
                        break;
                }

            } while (devam);
        }
    }
}
