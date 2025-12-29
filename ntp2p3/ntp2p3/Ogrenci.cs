namespace ntp2p3
{
    class Ogrenci
    {
        public long Numara { get; set; }
        public string Ad { get; set; }
        public string Bolum { get; set; }
        public int Sinif { get; set; }
        public double Gano { get; set; }

        public override string ToString()
        {
            return ""+Numara+" numaralı "+Ad+" "+Bolum+" bölümü "+Sinif+". sınıf öğrencisidir. "+
                "GANOS'su "+Gano+" olan başarılı bir arkadaşımızdır.";    
        }
    }
}
