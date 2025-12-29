namespace ntp2k
{
    internal class Program
    {
        private delegate double Temsilci(double x, double y);

        private static double Topla(double a, double b)
        {
            Console.WriteLine(" > Toplama");
            return a + b; 
        }
        private static double Cikar(double a, double b)
        {
            Console.WriteLine(" > Çıkarma");
            return a - b; 
        }
        private static double Carp(double a, double b)
        {
            Console.WriteLine(" > Çarpma");
            return a * b; 
        }
        private static double Bol(double a, double b)
        {
            Console.WriteLine(" > Bölme");
            return a / b; 
        }

        static void Main(string[] args)
        {
            Temsilci temsilci = new Temsilci(Topla);
            Console.WriteLine("\nTanımlamadan sonra...");
            Console.WriteLine( temsilci(12.5, 67.75));

            temsilci = Cikar;
            Console.WriteLine("\n temsilci = Cikar;");
            Console.WriteLine(temsilci(12.5, 67.75));

            temsilci += Carp;
            Console.WriteLine("\n temsilci += Carp;");
            Console.WriteLine(temsilci(12.5, 67.75));

            temsilci -= Cikar;
            temsilci += Bol;
            Console.WriteLine("\n temsilci -= Cikar;\r\n temsilci += Bol;");
            Console.WriteLine(temsilci(12.5, 67.75));

            // for (int i=0; i<temsilci.GetInvocationList()) 
            foreach (var item in temsilci.GetInvocationList())
                Console.WriteLine(item.DynamicInvoke(12.5, 67.75));

            Test test = new Test();
            Temsilci testTemsilci = new Temsilci(test.Mod);
            Console.WriteLine(testTemsilci(-37, -15));
            testTemsilci = test.Yuzde;
            Console.WriteLine(testTemsilci(-37, -15));
            testTemsilci += test.Mod;
            Console.WriteLine(testTemsilci(-37, -15));
        }
    }
}
