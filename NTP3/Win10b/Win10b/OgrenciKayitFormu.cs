using Win10b.Model;

namespace Win10b
{
    public partial class OgrenciKayitFormu : Form
    {
        public Ogrenci ogrenci;
        public OgrenciKayitFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ogrenci = new()
            {
                Numara = nudNumara.Value.ToString(),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text
            };
        }

        private void OgrenciKayitFormu_Load(object sender, EventArgs e)
        {
            ogrenci = new();
        }

        private void nudNumara_ValueChanged(object sender, EventArgs e)
        {
            ogrenci.Numara = nudNumara.Value.ToString();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            ogrenci.Ad = txtAd.Text;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            ogrenci.Soyad = txtSoyad.Text;
        }
    }
}
