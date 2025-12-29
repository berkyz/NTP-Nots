namespace Vize1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen...");

            Console.Write("Satır ayısı [1..20]: ");
            byte n = Convert.ToByte(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine(new string(' ', (n-i)) + new string('*', i));
            }
        }
    }
}
