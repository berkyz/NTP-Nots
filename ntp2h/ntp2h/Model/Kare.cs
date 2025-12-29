namespace ntp2h.Model
{
    class Kare : I2BSekil
    {
        public double Kenar;
        public double Alan()
        {
            return Kenar*Kenar;
        }

        public double Cevre()
        {
            return Kenar * 4;
        }
    }
}
