namespace Ders10b
{
    internal class Program
    {
        static double Alan3(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt( s*(s-a)*(s-b)*(s-c));
        }
        static void Main(string[] args)
        {
            // Tanımlar
            double aKenar, bKenar, cKenar, alan;

            // Girişler
            Console.Write("Üçgenin a kenarının uzunluğu: ");
            aKenar = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Üçgenin b kenarının uzunluğu: ");
            bKenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçgenin c kenarının uzunluğu: ");
            cKenar = double.Parse(Console.ReadLine() ?? "0");

            // Hesaplama
            alan = Alan3(aKenar, bKenar, cKenar);

            // Çıkışlar
            Console.WriteLine("Üçgenin alanı:"+alan);

        }
    }
}
