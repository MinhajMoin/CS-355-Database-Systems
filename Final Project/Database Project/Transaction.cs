using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search S = new Search();
            S.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.textBox2.Text = textBox6.Text.ToString();
            checkOut.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i=0; i<dataGridView2.ColumnCount;i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[i].Value;
            }
            MessageBox.Show((0).ToString() + ' ' + (dataGridView1.Rows.Count - 1).ToString());
            dataGridView1[5, 0].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value) * Convert.ToInt32(dataGridView1.Rows[0].Cells[4].Value);
            MessageBox.Show("Yellow");
            int totalPrice = 0;
            for (int i=0;i<dataGridView1.RowCount;i++)
            {
                totalPrice += Convert.ToInt32(dataGridView1[dataGridView1.ColumnCount - 1, i].Value);
            }
            textBox6.Text = totalPrice.ToString();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
