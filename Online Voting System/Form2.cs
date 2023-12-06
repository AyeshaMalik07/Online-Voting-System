using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Voting_System
{
    public partial class Form2 : Form
    {
        String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\afoma\OneDrive\Documents\voting db.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            InitializeComponent();
            String[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            comboBox2.Items.AddRange(Months);

            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int i = 1900; i <= 2005; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
