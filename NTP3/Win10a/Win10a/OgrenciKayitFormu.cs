using Win10a.Model;

namespace Win10a
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
    }
}
