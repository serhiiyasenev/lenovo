using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to apply your changes?", "The second will be equal the first", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            textBox2.Text = textBox1.Text;
        }
    }
}