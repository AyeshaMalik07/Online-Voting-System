using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Voting_System
{
    public partial class Form3 : Form
    { 
       

        public Form3()
        {
            InitializeComponent();
            //checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "pass123")
            {
                MessageBox.Show("Login Successfull!!!");
                //Form5 F5 = new Form5();
                //F5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
