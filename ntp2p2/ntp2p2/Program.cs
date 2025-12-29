using System.Collections;
namespace ntp2p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yığın LIFO, Last In First Out
            Stack yigin = new Stack();

            yigin.Push("Mısra");
            yigin.Push("Cevat");
            yigin.Push(1250);
            yigin.Push(3.14);

            foreach (var x in yigin)
                Console.WriteLine(x);

            Console.WriteLine("Yığındaki öğe sayısı: "+yigin.Count);
            Console.WriteLine("  > En son eklenen öğe"+yigin.Pop());
            Console.WriteLine("Yığındaki öğe sayısı: " + yigin.Count);

            Console.WriteLine("  > Şu an yığın...");
            foreach (var x in yigin)
                Console.WriteLine(x);

            Console.WriteLine("Sıradaki öğe: " + yigin.Peek());

            yigin.Clear();
            Console.WriteLine("Yığındaki öğe sayısı: " + yigin.Count);
            Console.WriteLine(yigin.Pop());
        }
    }
}
