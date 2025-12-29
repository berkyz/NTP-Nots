namespace Ders10d
{
    internal class Program
    {
        static void DiziOku(string[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"{i+1}. İsim:");
                dizi[i] = Console.ReadLine() ?? "";
            }
        }

        static int EnKucuk(string[] dizi, int bas, int son)
        {
            int indis = bas;
            for (int i = bas+1; i<son; i++)
                if (dizi[indis].CompareTo( dizi[i]) > 0)
                    indis = i;

            return indis;
        }

        static void Takas(ref string a, ref string b)
        {
            string g = a;
            a = b;
            b = g;
        }

        static void DiziYaz(string[] dizi)
        {
            Console.WriteLine("Dizi elemanları ...");
            for(int i = 0;i < dizi.Length;i++)
                Console.WriteLine(dizi[i]);
        }
        static void Main(string[] args)
        {
            Console.Write("Kaç isim gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] Adlar = new string[n];
            DiziOku(Adlar);
            int maxIndis;
            for (int i = 0; i < (n - 1); i++)
            {
                maxIndis = EnKucuk(Adlar, i, n);
                Takas(ref Adlar[i], ref Adlar[maxIndis]);
            }
            DiziYaz(Adlar);
        }
    }
}
