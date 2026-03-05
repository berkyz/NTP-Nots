namespace Win4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Islem(object sender, EventArgs e)
        {
            Button dugme = sender as Button;
            switch (dugme.Text)
            {
                case "+": lblSonuc.Text = "Toplama"; break;
                case "-": lblSonuc.Text = "Çıkarma"; break;
                case "×": lblSonuc.Text = "Çarpma"; break;
                case "÷": lblSonuc.Text = "Bölme"; break;
                default: lblSonuc.Text = "Ey Programcı! \r\nYanlış düğmeye atama yapmışsın."; break;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
