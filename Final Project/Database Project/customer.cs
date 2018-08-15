using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Database_Project
{
    public partial class customer : Form
    {
        static public SqlConnection cnn;

        public customer()
        {
            InitializeComponent();
            




        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string y = x.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from Customers where CustomerID =" + y;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Close();

            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = check; Data Source = MINHAJ - PC\\SQLEXPRESS";
            //"Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = check; Data Source = MINHAJ - PC\SQLEXPRESS""
            cnn.Open();
           
           if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Customers";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read() == true)
                {
                    while (rd.Read())
                    {
                        dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3]);

                    }
                    rd.Close();
                }
                else
                {
                    MessageBox.Show("connection failed");
                }
            }
            if (textBox1.Text.Length != 0 && textBox2.Text.Length == 0)
            {
                string name = textBox1.Text;
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = "select * from Customers where Customers.FirstName like '" + name+"'";
                cmdd.CommandType = CommandType.Text;
                cmdd.Connection = cnn;
                SqlDataReader rdd = cmdd.ExecuteReader();

                if (rdd.Read() == true)
                {
                    while (rdd.Read())
                    {
                        dataGridView1.Rows.Add(rdd[0], rdd[1], rdd[2], rdd[3]);

                    }
                    rdd.Close();
                }
                else
                {
                    MessageBox.Show("connection failed");
                }
            }
            if (textBox1.Text.Length == 0 && textBox2.Text.Length != 0)
            {
                int contact = Convert.ToInt32(textBox2.Text);
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = "select * from Customers where Customers.Contact =" + "contact";
                cmdd.CommandType = CommandType.Text;
                cmdd.Connection = cnn;
                SqlDataReader rdd = cmdd.ExecuteReader();
                if (rdd.Read() == true)
                {
                    while (rdd.Read())
                    {
                        dataGridView1.Rows.Add(rdd[0], rdd[1], rdd[2], rdd[3]);

                    }
                    rdd.Close();
                }
                else
                {
                    MessageBox.Show("connection failed");
                }
            }
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                int contact = Convert.ToInt32(textBox2.Text);
                string name = textBox1.Text;
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = "select * from Customers where Customers.Contact =" + "contact" + " and Customers.FirstName like '" + name+"'";
                cmdd.CommandType = CommandType.Text;
                cmdd.Connection = cnn;
                SqlDataReader rdd = cmdd.ExecuteReader();
                if (rdd.Read() == true)
                {
                    while (rdd.Read())
                    {
                        dataGridView1.Rows.Add(rdd[0], rdd[1], rdd[2], rdd[3]);

                    }
                    rdd.Close();
                }
                else
                {
                    MessageBox.Show("connection failed");
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
