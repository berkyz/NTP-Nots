namespace Win2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba!");
            // List<string> liste = new List<string>(textBox1.Lines);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //label1.BackColor = Color.Red;
            label1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            //label1.BackColor = SystemColors.Control;
            // label1_Click(sender, e);
            label1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double a = 10_27.25;
            //textBox1.Text = a.ToString();
        }
    }
}
