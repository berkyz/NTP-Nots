using Win10a.Model;
namespace Win10a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciKayitFormu form = new();
            
            form.Text = "HACKlendin"; 
            //form.txtAd.Text = "Yaşasın";
            //form.txtSoyad.Text = "Yazılım Kardeşliği";

            if (form.ShowDialog() == DialogResult.Cancel)
                return;

            Ogrenci ogrenci = form.ogrenci;
            //    new Ogrenci()
            //{
            //    //Numara = form.nudNumara.Value.ToString(),
            //    //Ad = form.txtAd.Text,
            //    //Soyad = form.txtSoyad.Text

            //};

            MessageBox.Show(ogrenci.ToString());
        }
    }
}
