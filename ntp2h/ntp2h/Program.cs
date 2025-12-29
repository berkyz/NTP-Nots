using ntp2h.Model;

namespace ntp2h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Daire daire = new Daire() { Cap = 12.5};
            Ucgen ucgen = new Ucgen() { KenarA=7.8, KenarB=8.68, KenarC=9.27};
            Kare kare = new Kare() { Kenar = 10 };

            List<I2BSekil> sekiller = new List<I2BSekil>();
            sekiller.Add(ucgen);
            sekiller.Add(kare);
            sekiller.Add(daire);

            foreach (var i in sekiller)
                Console.WriteLine(i.GetType()+" Alan: "+i.Alan() +" \t Çevre: "+i.Cevre());
        }
    }
}
