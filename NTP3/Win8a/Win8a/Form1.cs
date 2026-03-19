namespace Win8a
{
    public partial class Form1 : Form
    {
        Random random;
        int yatay, dikey;
        DateTime baslangic;
        bool aktif;
        int mouseX, mouseY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Rastgele sayı üreteci oluştur.
            random = new(218);

            // Ekran boyutlarını al ve formu olabilecek en büyük boyuta getir.
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            Top = 0;
            Left = 0;

            // Zamanlayıcıyı başlat.
            timer1.Start();
            aktif = true;
            baslangic = DateTime.Now;

            // Balığın hareket edebileceği alanı belirle
            yatay = Width - pctBalik.Width;
            dikey = Height - pctBalik.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            do
            {
                pctBalik.Left = random.Next(0, yatay);
                pctBalik.Top = random.Next(0, dikey);
            } while (pctBalik.Left <= mouseX && mouseX < (pctBalik.Left+pctBalik.Width) &&
                     pctBalik.Top <= mouseY && mouseY < (pctBalik.Top + pctBalik.Height) );
        }

        private void pctBalik_Click(object sender, EventArgs e)
        {
            if (!aktif)
            {
                timer1.Start();
                baslangic = DateTime.Now;
                aktif = true;
                return;
            }

            timer1.Stop();
            DialogResult sonuc =
            MessageBox.Show(
                $"Beni {(DateTime.Now - baslangic).Seconds} saniyede yakaladın.",
                "BRAVO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                timer1.Start();
                baslangic = DateTime.Now;
                aktif = true;
            }

            else
            {
                timer1.Stop();
                aktif = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
