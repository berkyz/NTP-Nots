using System.Collections;

namespace ntp2n1
{
    internal class Program
    {

        static void ListeYaz(ArrayList liste)
        {
            foreach(var oge in liste)
                Console.WriteLine(oge);
        }

        static void KaresiniAl(ArrayList liste)
        {
            for (int i = 0; i < liste.Count; i++)
                liste[i] = Convert.ToInt32(liste[i]) * Convert.ToInt32(liste[i]);
        }
        static void Main(string[] args)
        {
            ArrayList liste1 = new ArrayList();
            liste1.Add(20);
            liste1.Add("Berk");
            liste1.Add(new Ogrenci());

            ListeYaz(liste1);

            ArrayList liste2 = new() { 1, "Alper", 3.49 };
            var liste3 = new ArrayList() { 1, 2, 3, 4, 5};
            KaresiniAl(liste3 );
            ListeYaz(liste3);

            // List<int> liste3 = new() { 1, 2.5, 3 };  // 
        }
    }
}
