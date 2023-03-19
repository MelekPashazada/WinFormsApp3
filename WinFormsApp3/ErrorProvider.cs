using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class ErrorProvider : Form
    {
        public ErrorProvider()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ErrorProvider_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(textBox1.Text) < 100)
            {
                errorProvider1.SetError(textBox1, "textbox doldurulmalidir");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (int.Parse(textBox2.Text) > 0)
            {
                errorProvider2.SetError(textBox2, "eded musbetdir");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (textBox3.Text.Length < 8)
            {
                errorProvider3.SetError(textBox3, "password 8-den cox olmalidir");
            }else
            {
                errorProvider3.Clear();
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
            BackColor = Color.FromArgb(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
        }
    }
}
