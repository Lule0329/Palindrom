using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reversed = new string(textBox1.Text.Reverse().ToArray());

            if (textBox1.Text.Length <= 2)
            {
                MessageBox.Show("Ordet är för kort");
            }
            else if (reversed == textBox1.Text)
            {
                MessageBox.Show(textBox1.Text + " är ett palindrom.");
            }
            else if (reversed != textBox1.Text)
            {
                MessageBox.Show(textBox1.Text + " är INTE ett palindrom.");
            }
        }
    }
}
