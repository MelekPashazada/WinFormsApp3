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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure to delete?","Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           // button1.Location=new Point( this.Width/2, this.Height/2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            button2.ForeColor = Color.Fuchsia;


            dateTimePicker1.Enabled = true;
            label2.Text = dateTimePicker1.Value.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            int year1 = int.Parse(year);
            if (year1>2000)
            {
                BackColor = Color.Red;
                button1.BackColor = Color.Gold;
            }
            else if (year1<2000)
            {
                BackColor = Color.Green;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
