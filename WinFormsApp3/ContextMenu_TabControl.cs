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
    public partial class ContextMenu_TabControl : Form
    {
        public ContextMenu_TabControl()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int eded = rnd.Next(0,100);
            textBox1.Text=eded.ToString();
           
            double eded1 = rnd.NextDouble();
            label1.Text = eded1.ToString();
        }
    }
}
