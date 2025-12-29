using System.Collections;
namespace ntp2r1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList liste = new SortedList();
            liste["4"] = "Yusuf";
            liste["2.9"] = "Mikail";
            liste["3.45"] = "Cevat";
            liste["3"] = "Şeyhmus";
            liste["3.75"] = "Mısra";

            // Anahtar koleksiyonu ile erişme
            Console.WriteLine(" > Anahtar ile ...");
            foreach (var anahtar in liste.Keys)
                Console.WriteLine("{0} {1}",anahtar,liste[anahtar]);

            // Anahtara göre arama
            string aranan = "3.45";
            Console.WriteLine(" > Anahtar ile arama ...");
            if (liste.ContainsKey(aranan))
                Console.WriteLine($"{aranan} {liste[aranan]}  sıra:{liste.IndexOfKey(aranan)}");
            else
                Console.WriteLine($"{aranan} listede  yer almıyor.");


            string deger = "Mısra";
            Console.WriteLine(" > Değer ile arama ...");
            if (liste.ContainsValue(deger))
                Console.WriteLine($"{deger} listede yer alıyor. Sıra:{liste.IndexOfValue(deger)}");
            else
                Console.WriteLine($"{deger} değeri listede yer almıyor.");

            // Değere ile erişme
            Console.WriteLine(" > Değerle erişme ...");
            foreach (string s in liste.Values)
                Console.WriteLine(s);

            // Anahtar değer çifti
            Console.WriteLine(" > Anahtar - değer çifti ile erişme ...");
            foreach(DictionaryEntry entry in liste)
                Console.WriteLine($"Anahtar: {entry.Key}  Değer: {entry.Value}");

            Console.WriteLine(liste["3.11"]);

            liste["3.75"] = "Ahmet";  // Üzerine yazar
            Console.WriteLine(liste["3.75"]);            
        }
    }
}
