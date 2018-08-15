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
    public partial class Employee : Form
    {
        private SqlConnection cnn;

        public Employee()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SampleCheck;Data Source=.";
            cnn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Employees";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read() == true)
                {
                    while (rd.Read())
                    {
                        dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4],rd[5],rd[6], rd[7]);

                    }
                    rd.Close();
                }
                else
                {
                    MessageBox.Show("connection failed");
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
  
            int x = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string y = x.ToString();
            Console.Write(y);
            Console.Read();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from Employees where EmployeeID =" + y;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Close();
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
