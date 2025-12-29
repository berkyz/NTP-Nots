namespace Ders05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, sonuc;
            char islem;

            Console.Write("1. sayı: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayı: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"
    Dört İşlem
    ----------------------------
    +   Toplama
    -   Çıkarma
    /   Bölme
    *   Çarpma
    ----------------------------
    Lütfen işleminizi giriniz... 
");
            islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+': Console.WriteLine("Sonuç: " + (a + b)); break;
                case '-': Console.WriteLine("Sonuç: " + (a - b)); break;
                case '/': Console.WriteLine("Sonuç: " + (a / b)); break;
                case '*': Console.WriteLine("Sonuç: " + (a * b)); break;
                default: Console.WriteLine("Bilinmeyen işlem..."); break;
            }
        }
    }
}
