namespace ntp2e
{
    class Ogrenci : Insan
    {
        public string? OkulNo { get; set; }
        public Ogrenci(string? ad = null, string? numara = null) : base(ad)
        {
            OkulNo = numara;
        }

        public new void Buyu()
        {
            Boy += 2;
            Kutle += 1;
        }
    }
}
