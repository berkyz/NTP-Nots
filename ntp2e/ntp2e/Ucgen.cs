namespace ntp2e
{
    class Ucgen:Sekil
    {
        public Ucgen(double taban, double yukseklik):base(taban, yukseklik)
        {
        }

        public override double Alan()
        {
            return base.Alan()/2;
        }
    }
}
