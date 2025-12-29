namespace ntp2b
{
    class Bisiklet
    {
        // alanlar
        private float hiz;
        private byte vites;
        protected bool fren;
        private string renk;

        // Özellikler
        public float Hiz
        {
            get
            {
                return hiz;
            }

            set
            {
                if (value >= 0 && value <= 60)
                    hiz = value;                
            }
        }

        public byte Vites
        {
            get
            {  
                return vites;
            }
            set
            {
                if (value >= 1 && value <= 21)
                    vites = value;
            }
        }

        public string Renk
        {
            set
            {
                if (renk.CompareTo( value) != 0)
                    renk = value;
            }
        }

        public int Model { get; set; } // Property

        // Full Property
        private DateTime uretimTarihi; // alan

        public DateTime UretimTarihi // Özellikler
        {
            get { return uretimTarihi; }
            set { uretimTarihi = value; }
        }

        public bool Fren
        {
            get;
        }


        // Metodlar

        public Bisiklet()
        {
            fren = false;
            hiz = 0;
            vites = 1;
        }
        public void VitesDegistir(byte v)
        {
            vites = v;
        }

        public void FrenYap()
        {
            fren = true;
            hiz = 0;
            vites = 1;
        }

        public void BilgiVer()
        {
            Console.WriteLine(@"
Bisikletin...
     Hızı = {0}
     Vitesi = {1}
     Fren = {2}
", hiz, vites, fren);
        }


    }
}
