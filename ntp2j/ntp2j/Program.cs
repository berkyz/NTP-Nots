using System.Security.Cryptography.X509Certificates;

namespace ntp2j
{
    internal class Program
    {
        // 1. Tanımlama
        public delegate void MyHandler();
        // Bu delege ile ancak ve ancak
        // "void <metod> ()"
        // şeklinde tanımlanan metodlar çağrılabilir. 

        public static void Method1()
        {
            Console.WriteLine("Merhaba. Benim adım Method1.");
        }

        public static void Method2()
        { Console.WriteLine("Merhaba. Yine ben, Method2."); }

        static void Main(string[] args)
        {
            // 2. Delege örnekleme, Method1 temsilciye abone edildi.
            MyHandler handler = new MyHandler(Method2);

            Console.WriteLine("> handler tanımlandı. Bu esnada Method2 abone edildi.");
            handler();

            // 2.5 Method1'i temsilciye abone etme
            handler += Method1;
            Console.WriteLine("> handler'a Method1 abone edildi.");

            // Method1(); // Derleme zamanı
            handler();  // Çalışma zamanı

            if(handler != null)
                handler -= Method2;

            Console.WriteLine("> Method2 abonelikten çıkarıldı.");
            handler();
        }
    }
}
