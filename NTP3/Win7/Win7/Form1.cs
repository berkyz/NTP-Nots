using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;
namespace Win7
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti; // conn
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder baglantiMetni = new();
            baglantiMetni.DataSource = "Lab00";
            baglantiMetni.IntegratedSecurity = true;
            baglantiMetni.TrustServerCertificate = true;
            baglantiMetni.InitialCatalog = "Okul";

            baglanti = new(baglantiMetni.ConnectionString);
            try
            {
                baglanti.Open();

                // Birimler
                string sql = "SELECT * FROM Birim";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                DataTable birim = new();
                SqlDataAdapter adaptor = new(komut);
                adaptor.Fill(birim);

                cboBirim.DataSource = birim;
                cboBirim.DisplayMember = "Aciklama";
                cboBirim.ValueMember = "BirimKodu";



            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnKaydet.Enabled = false;
            }


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            baglanti.Dispose();
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı sonlandırılmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnKaydet.Enabled = false;
                return;
            }

            
            string sql = $"insert into Ogrenci  values('{nudNumara.Value.ToString()}', '{txtAd.Text}', '{txtSoyad.Text}', '{cboBirim.SelectedValue}', '{cboBolum.SelectedValue}', '{dtpDogumTarihi.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}', '{txtDogumYeri.Text}')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            try
            {
                int n = komut.ExecuteNonQuery();
                MessageBox.Show(n.ToString() + " kayıt eklendi.");
            }
            catch(Exception hata)
            {
                MessageBox.Show("Kayıt eklenemedi.\r\n" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cboBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboBirim_SelectedValueChanged(object sender, EventArgs e)
        {
            string? birimKodu = cboBirim?.SelectedValue?.ToString();
            if(baglanti.State != ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı sonlandırılmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnKaydet.Enabled = false;
                return;
            }

            string sql = $"select * from Bolum where BirimKodu='{birimKodu}'";
            SqlCommand komut = new(sql, baglanti);

            DataTable bolum = new();
            SqlDataAdapter adaptor = new(komut);
            adaptor.Fill(bolum);

            cboBolum.DataSource = bolum;
            cboBolum.DisplayMember = "Aciklama";
            cboBolum.ValueMember = "BolumKodu";
            cboBolum.Enabled = true;
        }
    }
}
