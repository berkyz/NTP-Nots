namespace ntp2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matematik mat = new();
            Console.WriteLine(Matematik.Signum(-3.75));
            Console.WriteLine(Matematik.start);
            Console.WriteLine(Matematik.Pi);

            var hoca = new { Ad = "Alper", Brans = "Bilgisayar" };
            Console.WriteLine(hoca.Ad, hoca.Brans);
        }
    }
}
