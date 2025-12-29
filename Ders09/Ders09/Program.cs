namespace Ders09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nor ortalaması...");

            sbyte vize, final;


            do
            {
                Console.Write(" Vize notunuz [0..100]: ");
                vize = sbyte.Parse(Console.ReadLine());
            } while (vize < 0 || vize > 100);

            do
            {
                Console.Write("Final notunuz [0..100]: ");
                final = sbyte.Parse(Console.ReadLine());
            } while (final < 0 || final > 100);

            sbyte ort = (sbyte)((vize*4 + final*6 + 5)/ 10) ;

            Console.WriteLine("Başarı notu: "+ort);
        }
    }
}
