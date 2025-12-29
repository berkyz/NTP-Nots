namespace ntp2e
{
    class Elips:Sekil
    {
        public Elips(double a, double b):base(a,b)
        {
        }

        public override double Alan()
        {
            return base.Alan() * Daire.Pi / 4;
        }
    }
}
