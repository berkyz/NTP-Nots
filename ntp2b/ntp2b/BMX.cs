namespace ntp2b
{
    class BMX : Bisiklet
    {
        Bisiklet dummy;

        public BMX()
        {
            dummy = new Bisiklet();
        }
        public void FrenYap()
        {
            fren = true;  // fren ebeveyn sınıf (Bisiklet)
        }
    }
}
