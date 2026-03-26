namespace Win10a.Model
{
    public class Ogrenci
    {
        public string? Numara { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }

        public override string ToString()
        {
            string? ogr;
            ogr = Numara + " : " + Ad + " " + Soyad;
            return ogr;
        }
    }
}
