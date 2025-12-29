namespace ntp2i.Model
{
    interface IInsan
    {
        public enum Mantik { False, True }

        public struct Isim { public string OnAd, GobekAdi, SoyAd;  }

        public class Bebek { }
        public string Ad { get; set; }
        // void Oku();
        void Konus(string ad);
    }
}
