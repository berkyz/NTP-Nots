using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Win5
{
    public partial class Form1 : Form
    {
        private string ogrenim, cinsiyet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Primary school");
            comboBox1.Items.Add("Middle school");
            comboBox1.Items.Add("Under graduate");
            comboBox1.Items.Add("Bachelor");

            comboBox1.Items.Insert(2, "High schhol");

            comboBox1.SelectedIndex = 4;

            listBox1.Items.Clear();
            foreach (var item in comboBox1.Items)
                listBox1.Items.Add(item);
            listBox1.Items.Add("Master");
            listBox1.Items.Add("PhD");

            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string metin = "";
            if (comboBox1.SelectedIndex < 0)
                metin = "TextBox olarak kullanılmış. \r\n" + comboBox1.Text +
                    "\r\nListe: " + listBox1.Text;
            else
                metin = "Seçili öğe (SelectedItem): " + comboBox1.SelectedItem +
                    "\r\n Seçili öğe (SelectedIndex): " + comboBox1.Items[comboBox1.SelectedIndex] +
                    "\r\nListe: " + listBox1.SelectedItem;

            MessageBox.Show(metin);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in listBox1.SelectedItems)
                listBox2.Items.Add(item);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radyo = sender as System.Windows.Forms.RadioButton;
            var grup = radyo.Parent as System.Windows.Forms.GroupBox;

            if (grup.Name == "groupBox1")
                ogrenim = radyo.Text;
            else
                cinsiyet = radyo.Text;
            lblDurum.Text = "Öğrenim durumu: " + ogrenim + "  -  " + "Cinsiyet: " + cinsiyet;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string durum = "";

            durum += (checkBox1.Checked) ? " Evli." : " Bekar.";
            durum += (checkBox2.Checked) ? " Çalışıyor." : " Çalışmıyor.";
            durum += (checkBox3.Checked) ? " Çocuğu var." : " Çocuğu yok.";

            lblDurum.Text = durum;
        }
    }
}
