namespace ntp2c
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public int Sinif { get; set; }
        public double Gano { get; set; }

        List<Ders> dersler = new List<Ders>();
        // Kurucu method: constructor

        void DersleriAta()
        {
            dersler.Add(new Ders() { Ad = "NTP1",Akts= 3,BasariNotu= 3.5 });
            dersler.Add(new Ders() { Ad = "NTP2", Akts = 3, BasariNotu = 3 });
            dersler.Add(new Ders() { Ad = "YM", Akts = 3, BasariNotu = 4 });
            dersler.Add(new Ders() { Ad = "YMG", Akts = 4, BasariNotu = 2.5 });
        }

        // Default constructor (varsayılan kurucu)
        public Ogrenci()
        {
            Ad = "İsimsiz";
            Sinif = 1;
            DersleriAta();
            Gano = GanoHesapla(dersler);
        }
        //// Overloaded constructor (aşırı yüklenmiş kurucu)
        //public Ogrenci(string ad, int sinif, double gano)
        //{
        //    Ad = ad;
        //    Sinif = sinif;
        //    Gano = gano;
        //}

        // Varsayılan değerler
        public Ogrenci(string ad, int sinif=1, double gano=0.0)
        {
            Ad = ad; 
            Sinif = sinif; 
            DersleriAta();
            gano = GanoHesapla(dersler);
        }

        public static double GanoHesapla(List<Ders> d)
        {
            double puan = 0.0, aktsToplami = 0.0;
            foreach (Ders ders in d)
            {
                puan += ders.Akts * ders.BasariNotu;
                aktsToplami += ders.Akts;
            }
            return puan/aktsToplami;
        }

        public string ToString()
        {
            return Ad + " adlı öğrencimiz " + Sinif + ". sınıfta okumakta ve şu an GANOsu 4 üzerinden " + Gano + "'dır.";
        }

    }
}
