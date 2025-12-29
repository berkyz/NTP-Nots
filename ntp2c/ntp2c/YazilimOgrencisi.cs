namespace ntp2c
{
    class YazilimOgrencisi : Ogrenci
    {
        public string Bilgisayar { get; set; }

        public YazilimOgrencisi(string ad, int sinif=1, double gano=0.0, string bilgisayar=null)
            : base(ad, sinif, gano)
        {
            Bilgisayar = bilgisayar;
        }

        public new string ToString()
        {
            return base.ToString() + "\nÖğrencimizin bilgisayarının özellekleri şöyledir:\n" + Bilgisayar;
        }
    }
}
