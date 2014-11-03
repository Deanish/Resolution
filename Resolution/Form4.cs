using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Resolution
{
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb");
           
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            con.Open();
            string str = "SELECT * from reg ";

            OleDbDataAdapter da = new OleDbDataAdapter(str, con);

            DataTable data = new DataTable();

            da.Fill(data);

            datagd.DataSource = data;

            datagd.Columns[0].HeaderText = "College";

            datagd.Columns[1].HeaderText = "Student Name";

            datagd.Columns[2].HeaderText = "Department";

            datagd.Columns[3].HeaderText = "Mobile";

            datagd.Columns[4].HeaderText = "Ice Breaker";

            datagd.Columns[5].HeaderText = "Best Manager";

            datagd.Columns[6].HeaderText = "Gaming";

            datagd.Columns[7].HeaderText = "Quiz";

            datagd.Columns[8].HeaderText = "Coding";

            datagd.Columns[9].HeaderText = "Dumb Chardes";

            datagd.Columns[10].HeaderText = "Treasure Hunt";

            datagd.Columns[11].HeaderText = "Web Designing";

            datagd.Columns[12].HeaderText = "Paper Presentation";

            datagd.Columns[13].HeaderText = "Photography";

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            con.Open();
            string str = "SELECT * from reg where coll='"+textBox1.Text.ToString()+"'";

            OleDbDataAdapter da = new OleDbDataAdapter(str, con);

            DataTable data = new DataTable();

            da.Fill(data);

            datagd.DataSource = data;

            datagd.Columns[0].HeaderText = "College";

            datagd.Columns[1].HeaderText = "Student Name";

            datagd.Columns[2].HeaderText = "Department";

            datagd.Columns[3].HeaderText = "Mobile";

            datagd.Columns[4].HeaderText = "Ice Breaker";

            datagd.Columns[5].HeaderText = "Best Manager";

            datagd.Columns[6].HeaderText = "Gaming";

            datagd.Columns[7].HeaderText = "Quiz";

            datagd.Columns[8].HeaderText = "Coding";

            datagd.Columns[9].HeaderText = "Dumb Chardes";

            datagd.Columns[10].HeaderText = "Treasure Hunt";

            datagd.Columns[11].HeaderText = "Web Designing";

            datagd.Columns[12].HeaderText = "Paper Presentation";

            datagd.Columns[13].HeaderText = "Photography";

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void datagd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
