namespace Win8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ekranın kullanılabiir yüksekliği ve genişliğini al
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            int width = Screen.PrimaryScreen.WorkingArea.Width;

            // Formu ekranın sağ üst köşesine konumlandır.
            Top = 0;
            Left = width - Width;

            // Zamanlayıcıyı başlat
            timer1.Start();

            Opacity = 50;
            TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy hh.mm.ss");
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }
    }
}
