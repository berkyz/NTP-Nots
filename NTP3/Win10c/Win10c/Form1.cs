namespace Win10c
{
    public partial class Form1 : Form
    {
        int belgeNo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotFormu form = new();
            form.Text = "Not " + belgeNo++;
            form.MdiParent = this;
            form.Show();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Salt metin dosyaları (*.txt)|*.txt|"+
                "C# code dosyaları (*.cs)|*.cs|"+
                "Hipermetin İşaretleme Dili dosyaları (*.htm/*.html)|*.htm;*.html|"+
                "Tüm dosyalar (*.*)|*.*";
            dosya.Title = "Dosya Aç";
            dosya.Multiselect = true;
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in dosya.FileNames) 
                {
                    NotFormu form = new();
                    form.Text = s;
                    form.MdiParent = this;
                    form.txtNot.Text = File.ReadAllText(s);
                    form.Show();
                }
            }
        }
    }
}
