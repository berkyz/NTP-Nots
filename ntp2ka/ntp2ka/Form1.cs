namespace ntp2ka
{
    public partial class Form1 : Form
    {
        Cihaz cihaz;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cihaz = new Cihaz();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            lblCihaz.Text = cihaz.Kontrol();
            if (lblCihaz.Text.Equals("Cihaz çalýþýyor."))
                btnKontrol.Image = Image.FromFile(@"C:\Users\lenovo\Downloads\Paomedia-Small-N-Flat-Switch-on.128.png");
            else
                btnKontrol.Load(@"C:\Users\lenovo\Downloads\Paomedia-Small-N-Flat-Switch-off.128.png");
        }
    }
}
