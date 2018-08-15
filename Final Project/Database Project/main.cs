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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction T = new Transaction();
            T.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchItems S = new SearchItems();
            S.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Frm = new Form2();
            Frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report R = new Report();
            R.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CompanyOrders CO = new CompanyOrders();
            CO.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customer fs = new customer();
            fs.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
