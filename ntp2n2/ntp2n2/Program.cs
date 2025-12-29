using System.Collections;

namespace ntp2n2
{
    internal class Program
    {
        static ArrayList DosyadanOku(string filename)
        {
            ArrayList list = new ArrayList(File.ReadAllLines(filename));
            return list;
        }


        static void ListeyiYazdir(ArrayList liste)
        {
            Console.WriteLine("+"+ new String('-',78)+"+");

            foreach (var oge in liste)
                Console.WriteLine("| " + oge);

            Console.WriteLine("+" + new String('-', 78) + "+");
        }

        static void Main(string[] args)
        {
            ArrayList liste = DosyadanOku("C:\\Users\\lenovo\\source\\repos\\NTP\\veriler.txt");
            ListeyiYazdir(liste);
        }
    }
}
