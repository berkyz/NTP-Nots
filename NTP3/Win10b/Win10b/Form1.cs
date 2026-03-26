using Win10b.Model;

namespace Win10b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciKayitFormu form = new();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild as OgrenciKayitFormu;
            Ogrenci ogrenci = form.ogrenci;
            MessageBox.Show(ogrenci.ToString() + " kaydedildi.");
            form.Close();
        }
    }
}
