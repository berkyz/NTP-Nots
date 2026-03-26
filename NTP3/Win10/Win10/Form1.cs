namespace Win10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormAc_Click(object sender, EventArgs e)
        {
            IkinciForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Kaydet düğmesi ile kapandı.");
            }
            else
            {
                MessageBox.Show("Kapat düğmesi ile kaptıldı.");
            }
        }
    }
}
