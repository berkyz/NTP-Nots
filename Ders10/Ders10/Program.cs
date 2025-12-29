namespace Ders10
{
    internal class Program
    {

        static int Ebob(int m, int n)
        {
            int t;
            while (m > 0)
            {
                if (m < n)
                {
                    t = m; m = n; n = t;
                }
                m %= n;
            }
            return n;
        }
        static void Main(string[] args)
        {
            // Tanımlar
            int pay, payda, bolen;

            // Girişler
            Console.Write("Pay  : ");
            pay = int.Parse(Console.ReadLine());
            Console.Write("Payda: ");
            payda = Convert.ToInt32(Console.ReadLine());

            // Hesaplama
            bolen = Ebob(pay, payda); pay /= bolen; payda /= bolen;

            // Çıkışlar
            Console.WriteLine("Sade hali: "+pay+" / "+payda);
        }
    }
}
