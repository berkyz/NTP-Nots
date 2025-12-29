using System.Collections;

namespace ntp2n3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste1 = new() { "Yusuf", "Mısra" };
            ArrayList liste2 = new() { "Abdulsamet", "Cevat Han" };
            liste1.AddRange(liste2);

            //foreach(var i in liste1)
            //    Console.WriteLine(i);
            for(int i = 0; i < liste1.Count; i++)
                Console.WriteLine(liste1[i]);
        }
    }
}
