using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "Anas" && textBox2.Text.ToString() == "anas123") {
                this.Hide();
                main mm = new main();
                mm.ShowDialog();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = customer.cnn;
            cmd.CommandText = "select employeename from employees where employees.employeename = " + textBox1.Text.ToString();
            SqlDataReader rd = cmd.ExecuteReader();
            int t = 0;
            if (textBox2.Text.ToString() == "password")
            if (rd.Read())
            {
                while (rd.Read())
                {
                    if (rd[0].ToString() == textBox1.Text.ToString()) { t++; this.Hide(); main mm = new main(); mm.ShowDialog(); }
                }
                if (t == 0) MessageBox.Show("Invalid Username and Password");
            }
            else
            {
                MessageBox.Show("Server could not be connected");
            }
            //this.Hide();
            //main mm = new main();
            //mm.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
