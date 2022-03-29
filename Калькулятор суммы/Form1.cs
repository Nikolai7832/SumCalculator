using System;
using System.Windows.Forms;

namespace Калькулятор_суммы
{
    public partial class Form1 : Form
    {
        double a=0;
        double b=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            string v = $"{a + b}";
            textBox3.Text = v;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = double.Parse(textBox2.Text);
            string v = $"{a + b}";
            textBox3.Text = v;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
