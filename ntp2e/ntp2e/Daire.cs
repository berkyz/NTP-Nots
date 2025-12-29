namespace ntp2e
{
    class Daire:Sekil
    {
        public const double Pi = 3.1415927;
        public Daire(double cap):base(cap,cap)
        {
        }

        public override double Alan()
        {
            // return base.Alan()*Pi/4; // Aynı şey
            return Pi * A * A/4;
        }
    }
}
