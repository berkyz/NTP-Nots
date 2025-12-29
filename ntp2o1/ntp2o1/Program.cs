using System.Collections;

namespace ntp2o1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { "Berk", 90, 3.65};

            Console.WriteLine("for ile ArrayList...");
            foreach (var oge in arrayList)
                Console.WriteLine(oge);


            DiziListe liste = new DiziListe();
            Console.WriteLine(liste.Sayi);
            liste.Ekle("Berk");
            liste.Ekle(90);
            liste.Ekle(3.65);
            Console.WriteLine(liste.Sayi);

            Console.WriteLine("for ile DiziListe...");
            for(int i = 0; i < liste.Sayi; i++)
                Console.WriteLine(liste[i]);

            Console.WriteLine("foreach ile DiziListe...");
            foreach (object oge in liste)
                Console.WriteLine(oge);
        }
    }
}
