using System.Collections;

namespace ntp2n4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste1 = new() { "Abdulselam", "Yusuf", "Mısra", "Abdulsamet", 
                "Cevat Han", "Emir Can", "Ahmet", "Şeyhmus", "Mikail", "Fatma Sümeyye"};

            ArrayList liste = liste1.GetRange(0, 8);

            foreach (var i in liste) Console.WriteLine(i); Console.WriteLine();
            liste.Insert(5, "Berk");
            foreach (var i in liste) Console.WriteLine(i); Console.WriteLine();
            
            // liste.RemoveAt(liste.Count - 1);
            // liste.Remove("Şeyhmus");

            string aranan = "Şeyhmus";
            int index = liste.IndexOf(aranan); // -1 bulunamadı, >= 0 indis
            if(index < 0)
                Console.WriteLine($"{aranan} listede yer almıyor.");
            else
                liste.RemoveAt(index);
            
            foreach (var i in liste) Console.WriteLine(i); Console.WriteLine();


            //foreach (var i in liste) Console.WriteLine(i); Console.WriteLine();
            //liste.Sort();
            //foreach (var i in liste) Console.WriteLine(i); Console.WriteLine();

            //liste.Reverse();
            //foreach (var i in liste) Console.WriteLine(i); Console.WriteLine();


        }
    }
}
