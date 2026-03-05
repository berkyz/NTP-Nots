using Microsoft.Data.SqlClient;
namespace Win6
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder baglantiMetni = new();
            baglantiMetni.DataSource = "LAB00";
            baglantiMetni.InitialCatalog = "Okul";
            baglantiMetni.IntegratedSecurity = true;
            baglantiMetni.TrustServerCertificate = true;

            baglanti = new SqlConnection(baglantiMetni.ConnectionString);
            try
            {
                baglanti.Open();

                string sql = @"
SELECT Numara, Ad, Soyad, Birim.Aciklama, Bolum.Aciklama, DogumTarihi, DogumYeri
from Ogrenci
join Birim ON Ogrenci.BirimKodu = Birim.BirimKodu
join Bolum ON Ogrenci.BolumKodu = Bolum.BolumKodu
";

                SqlCommand komut = new(sql, baglanti);

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                    txtOgrenci.Text += okuyucu["Numara"] + "\t" +
                        okuyucu["Ad"] + " " + okuyucu["Soyad"] + "\r\n";


                komut.Dispose();

                baglanti.Close();
                baglanti.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
