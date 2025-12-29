namespace Ders08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EBOB Hesaplama...");

            Console.Write("Bir pozitif tamsayı: ");
            ulong sayi1 = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Bir pozitif tamsayı daha: ");
            ulong sayi2 = Convert.ToUInt64(Console.ReadLine());

            //ulong bolen = 2, ebob = 1;

            //while(sayi1>1 && sayi2 > 1)
            //{
            //    // Her iki sayıyıyı da böldüğü sürece
            //    while(sayi1%bolen == 0 && sayi2%bolen == 0)
            //    {
            //        ebob *= bolen;
            //        sayi1 /= bolen;
            //        sayi2 /= bolen;
            //    }
            //    while (sayi1 % bolen == 0)
            //        sayi1 /= bolen;
            //    while (sayi2 % bolen == 0)
            //        sayi2 /= bolen;
            //    bolen++;
            //}
            //Console.WriteLine("EBOB: "+ebob);

            ulong gecici;
            while (sayi2 > 0)
            {
                gecici = sayi1 % sayi2;
                sayi1 = sayi2;
                sayi2 = gecici;
            }
            Console.WriteLine("EBOB: "+sayi1);
        }
    }
}
