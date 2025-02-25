namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double num = 0;

            //§PÂ_²Å¸¹
            if (label2.Text == "+") { num = double.Parse(textBox1.Text) + double.Parse(textBox4.Text);}
            if (label2.Text == "-") { num = double.Parse(textBox1.Text) - double.Parse(textBox4.Text); }
            if (label2.Text == "*") { num = double.Parse(textBox1.Text) * double.Parse(textBox4.Text); }
            if (label2.Text == "¡Ò") { num = double.Parse(textBox1.Text) / double.Parse(textBox4.Text); }

            textBox2.Text = num.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "*";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "¡Ò";
        }
    }
}