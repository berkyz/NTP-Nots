namespace Ders10c
{
    internal class Program
    {

        static void Test(out int a, out int b)
        {
            a = 100;
            b = 500;
        }
        static void Main(string[] args)
        {
            int X;
            int Y;

            // Console.WriteLine($"X: {X}   Y: {Y}");
            Test(out X, out Y);
            Console.WriteLine($"X: {X}   Y: {Y}");

        }
    }
}
