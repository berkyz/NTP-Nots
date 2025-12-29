namespace ntp2h.Model
{
    class Ucgen : I2BSekil
    {
        public double KenarA { get; set; }
        public double KenarB { get; set; }
        public double KenarC { get; set; }
        public double Alan()
        {
            double S = Cevre()/2;
            return Math.Sqrt(S*(S-KenarA)*(S-KenarB)*(S-KenarC));
        }

        public double Cevre()
        {
            return KenarA + KenarB + KenarC;
        }
    }
}
