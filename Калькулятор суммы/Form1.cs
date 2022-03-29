using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_суммы
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text =($"{a + b}" );
        }
private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
        }

private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          textBox3.Text = ($"{a + b}");
        }
    }
}
