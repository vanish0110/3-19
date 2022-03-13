namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);           
            double c;
            if ((x - y) == 0)
                c = Math.Sin(x * x) + Math.Cos(y * y);
            else if ((x - y) < 0)
                c = Math.Tan(x * x + y * y);
            else 
                    c = Math.Pow(Math.Sin(x * x), 2) + Math.Pow(Math.Cos(y * y), 2);


            textBox4.Text += "Результат работы программы" + " Уткин И.А." + Environment.NewLine;
            textBox4.Text += "При Х =" + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y =" + textBox2.Text + Environment.NewLine;
            textBox4.Text += "c=" + c.ToString() + Environment.NewLine;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = ("");
        }
    }
}