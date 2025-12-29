using System.Transactions;

namespace ntp2i.Model
{
    class Spiker : IInsan
    {
        public string Ad { get; set; }
        private IInsan.Isim name;

        public IInsan.Isim Name
        {
            get { return name; }
            set { name = value; }
        }


        public Spiker(string ad="Fatih Portakal")
        {
            Ad = ad;
            Name= new IInsan.Isim{ OnAd = "Fatih", GobekAdi = "", SoyAd = "Portakal"} ;

        }
        public string Kanal { get; set; }
        protected void Konus(string isim)
        {
            Console.WriteLine($"Merhaba, benim adım {isim}.");
            Console.WriteLine(IInsan.Mantik.True);
            Console.WriteLine(Name.OnAd+" "+Name.SoyAd);

        }

        public void Tanit()
        {
            Console.WriteLine("Ben {0} kanında çalışıyorum.", Kanal);
        }

        void IInsan.Konus(string ad)
        {
            Konus(ad);
        }
    }
}
