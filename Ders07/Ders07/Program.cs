namespace Ders07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taban çevirme...");
            Console.Write("10luk tabanda pozitif bir tamsayı: ");
            var sayi = Convert.ToUInt64(Console.ReadLine());
            ulong yedek = sayi;
            Console.Write("Taban: ");
            byte taban = Convert.ToByte(Console.ReadLine());

            string yeniSayi = "";

            while (sayi > 0)
            {
                yeniSayi = (sayi % taban) + yeniSayi;
                sayi /= taban;
            }

            Console.Write($"({yedek})10 = ({yeniSayi}){taban}");
        }
    }
}
