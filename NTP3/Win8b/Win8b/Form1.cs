namespace Win8b
{
    public partial class Form1 : Form
    {
        char[] dizi = "/ꟷ\\|".ToCharArray();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left -= 16;
            if (label1.Width + label1.Left < 10)
                label1.Left = 801;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = dizi[index++].ToString();
            index %= 4;

        }
    }
}
