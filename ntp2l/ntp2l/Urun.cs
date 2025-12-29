namespace ntp2l
{
    class Urun
    {
        public delegate void StokBittiEventHandler(object sender, EventArgs e);
        public event StokBittiEventHandler StokBitti;  // Olay tanımlama

        public int KritikStokSeviyesi { get; set; }

        private int stokMiktari; // Alan

        public int StokMiktari  // Özellik
        {
            get { return stokMiktari; }
            set
            {
                if (value < 0)
                    throw new Exception("Stokta olmayan ürünü satamazsın.");
                stokMiktari = value;
                if (stokMiktari < KritikStokSeviyesi && StokBitti != null)
                    StokBitti(this, new EventArgs());
            }
        }
    


        public string Ad { get; set; }

        public Urun(string ad, int stok, int kritik=10)
        {
            Ad = ad;
            StokMiktari = stok;
            KritikStokSeviyesi = kritik;
        }

        public void Al(int miktar)
        {
            StokMiktari += miktar;
        }

        public void Sat(int miktar)
        {
            StokMiktari -= miktar;
        }

        public override string ToString()
        {
            return $"{Ad} adlı üründen stokta {StokMiktari} adet mevcuttur.";
        }
    }
}
