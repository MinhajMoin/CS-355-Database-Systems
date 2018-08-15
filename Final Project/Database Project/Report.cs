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
    public partial class Report : Form
    {
        private SqlConnection cnn;
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int days = 7;
            if (radioButton2.Checked) days = 60;
            else if (radioButton3.Checked) days = 1;
            ReportDataGrid RDG = new ReportDataGrid();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from customers";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                while(rd.Read())
                {
                    RDG.dataGridView1.Rows.Add(rd[0], rd[1]);
                }
            }

            RDG.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
