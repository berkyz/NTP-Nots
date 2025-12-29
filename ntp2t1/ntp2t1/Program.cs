using System.Collections;

namespace ntp2t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long,string> sozluk = new Dictionary<long, string>()
            {
                {2301060011L,"Cevat Han ALKAŞİ"},
                {2301060017L, "Berk YILMAZ"} 
            };

            sozluk[2301060009l] = "Mısra CAN";
            sozluk[2301060003l] = "Abdülselam ONAKBAŞ";
            sozluk[2301060010L] = "Abdulsamet DÖLCEK";
            sozluk[2301060005L] = "Yusuf ŞANVERDİ";

            sozluk[2301060034] = "Şeyhmuz YERSİZ";
            // ..
            

            Console.WriteLine(new String('-', 40));
            foreach (var oge in sozluk)
                Console.WriteLine($"{oge.Key}: {sozluk[oge.Key]}");  // Yavaş
                // Console.WriteLine($"{oge.Key}: {oge.Value}");

            sozluk.Clear();
            sozluk[2301060034] = "Şeyhmus YERSİZ";
            sozluk.Remove(2301060017);

            Console.WriteLine(new String('-', 40));
            foreach (KeyValuePair<long,string> oge in sozluk)
                Console.WriteLine($"{oge.Key}: {oge.Value}");

            //Console.WriteLine(new String('-', 40));
            //foreach (DictionaryEntry oge in sozluk)
            //    Console.WriteLine($"{oge.Key}: {oge.Value}");

            Console.WriteLine(new String('-', 20)+" ANAHTARLAR");
            foreach (long anahtar in sozluk.Keys)
                Console.WriteLine(anahtar);

            Console.WriteLine(new String('-', 20) + " DEĞERLER");
            foreach (string deger in sozluk.Values)
                Console.WriteLine(deger);

            Console.WriteLine(new String('-', 20) + " SAYI");
            Console.WriteLine("Sözlükteki öğe sayısı: "+sozluk.Count);

            long aranan = 2301060005L;
            //if (sozluk?[aranan] is not null)
            //    Console.WriteLine(sozluk[aranan]);
            //else
            //    Console.WriteLine($"{aranan} eklenmemiş");
            if(sozluk.ContainsKey(aranan))
                Console.WriteLine(sozluk[aranan]);
            else
                Console.WriteLine($"{aranan} eklenmemiş");

            
            if(sozluk.TryGetValue(aranan, out string mesaj))
                Console.WriteLine(mesaj);

            Console.WriteLine(sozluk.GetValueOrDefault(aranan)); // Varsa değeri, yoksa varsayılan string değeri: ""

            sozluk.Add(2301060017, "Berk YILMAZ");

            Console.WriteLine(new String('-', 20)+" Add() ...");
            foreach (KeyValuePair<long, string> oge in sozluk)
                Console.WriteLine($"{oge.Key}: {oge.Value}");

            if (sozluk.TryAdd(2301060005, "Yusuf ŞANVERDİ"))
                Console.WriteLine("Öğe başarıyla eklendi.");
            else
                Console.WriteLine("Öğe zaten eklenmiş.");

            if (sozluk.TryAdd(2301060036, "Fatma Sümeyye KOYUNCU"))
                Console.WriteLine("Öğe başarıyla eklendi.");
            else
                Console.WriteLine("Öğe zaten eklenmiş.");

            string arananDeger = "Berk YILMAZ";
            if (sozluk.ContainsValue(arananDeger))
            {
                Console.WriteLine($"{arananDeger} sözlüğe eklenmiş.");
                Console.WriteLine($"{sozluk.Values.ToList().IndexOf(arananDeger)}. sırada...");
            }                
            else
                Console.WriteLine($"{arananDeger} sözlüğe eklenmemiş");


        }
    }
}
