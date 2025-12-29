namespace ntp2e
{
    class Sekil
    {
        public double A { get; set; }
        public double B { get; set; }

        public Sekil(double a, double b)
        {
            A= a; B = b;
        }
        public virtual double Alan()
        {
            return A * B;
        }
    }
}
