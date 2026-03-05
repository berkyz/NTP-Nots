namespace Win3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelamla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, " + txtAd.Text);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
