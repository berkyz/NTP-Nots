namespace ntp2e
{
    class Insan
    {
        public string? Ad { get; set; }
        public int Boy { get; set; }
        public float Kutle { get; set; }
        public Insan(string? ad = null)
        {
            Ad = ad;
            Boy = 50;
            Kutle = 3.5f;
        }

        public void Buyu()
        {
            Boy += 1;
            Kutle += 0.5f;
        }
    }
}
