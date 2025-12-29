namespace ntp2m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Width += 20;
            button.Left -= 10;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width -= 20;
            btn.Left += 10;
        }
    }
}
