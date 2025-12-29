namespace ntp2s1
{
    class Ogrenci
    {
        public int Numara { get; set; }
        public string Ad { get; set; }

        public override string ToString()
        {
            return "" + Numara + ": " + Ad;
        }
    }
}
