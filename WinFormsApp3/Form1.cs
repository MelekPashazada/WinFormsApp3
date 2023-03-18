namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime date = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
           
            label1.Text=date.ToString();
            listBox1.Items.Add(date.ToLongDateString());
            listBox1.Items.Add(date.ToShortDateString());
            listBox1.Items.Add(date.Year);
            listBox1.Items.Add(date.Month);
            listBox1.Items.Add(date.Day);
            listBox1.Items.Add(date.Hour);
            listBox1.Items.Add(date.ToString(""));




            DateTime date1 = new DateTime(2016, 05, 23);
            label2.Text= date1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text=date.AddDays(3).ToString();
            label4.Text = date.AddYears(3).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime tevellud = new DateTime(1991,01,23);
            DateTime tarix_bugun = new DateTime(2023,03,12);

            TimeSpan age = tarix_bugun - tevellud;
            listBox1.Items.Add(age.Days);
            listBox1.Items.Add(age.ToString());
            int age1=age.Days;
            listBox1.Items.Add(age1 / 30/12);
           label6.Text = (Convert.ToInt32(tarix_bugun.Year) - Convert.ToInt32(tevellud.Year)).ToString();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();
            this.Hide();
        }
    }
}