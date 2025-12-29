namespace ntp2g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IComparable nesne = new IComparable(); // Arayüzlerden nesne örneklenemez.
            Ogrenci ogrenci = new Ogrenci();
            IComparable nesne = ogrenci;
            // nesne = new Daire();
            // Ogrenci yeniOgrenci = nesne; 
            //int a = 15; 
            //double b = 15.0;
            //object c = b;
            //Console.WriteLine(a.CompareTo(c));
        }
    }
}
