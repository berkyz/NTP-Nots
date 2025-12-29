namespace ntp2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bisiklet bisiklet = new Bisiklet();
            bisiklet.Hiz = -10000;
            Console.WriteLine(bisiklet.Hiz);
            bisiklet.Hiz = 65;
            Console.WriteLine(bisiklet.Hiz);
            bisiklet.Hiz =7.5F;
            Console.WriteLine(bisiklet.Hiz);
            bisiklet.FrenYap();
            bisiklet.BilgiVer();
            // bisiklet.vites = 5;
            // bisiklet.fren = false;
        }
    }
}
