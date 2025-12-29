namespace Ders04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte vize, final, basariNotu;

            Console.Write(" Vize: ");
            vize = Convert.ToByte(Console.ReadLine());

            Console.Write("Final: ");
            final = Convert.ToByte(Console.ReadLine()); 

            if(final < 50)
                Console.WriteLine("Kaldın!");
            else
            {
                basariNotu = (byte)(vize*0.4+final*0.6+0.5);
                if(basariNotu < 60)
                    Console.WriteLine("Kaldın!");
                else
                {
                    // AA: 90-100
                    if(basariNotu >= 90 && basariNotu <= 100)
                        Console.WriteLine("AA");
                    // BA: 80-89
                    else if (basariNotu >= 80)
                        Console.WriteLine("BA");
                    // BB: 70-79
                    else if(basariNotu >=70)
                        Console.WriteLine("BB");
                    // CB: 65-69
                    else if(basariNotu >= 65)
                        Console.WriteLine("CB");
                    // CC: 60-64
                    else if(basariNotu >= 60)
                        Console.WriteLine("CC");
                    // FD: 50-59
                    else if(basariNotu>=50)
                        Console.WriteLine("FD");
                    // FF: 0-49
                    else
                        Console.WriteLine("FF");
                }
            }
        }
    }
}
