namespace ntp2h.Model
{
    class Daire : I2BSekil
    {
        public const double Pi = 3.1415927;
        public double Cap;
        public double Alan()
        {
            return Pi * Cap * Cap / 4;
        }

        public double Cevre()
        {
            return Pi * Cap;
        }
    }
}
