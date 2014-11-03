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
    public partial class Form10 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb");
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void datagd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            con.Open();
            string str = "SELECT coll,sname,dept,mobile from reg where dc='" + true + "'";

            OleDbDataAdapter da = new OleDbDataAdapter(str, con);

            DataTable data = new DataTable();

            da.Fill(data);

            datagd.DataSource = data;

            datagd.Columns[0].HeaderText = "College";

            datagd.Columns[1].HeaderText = "Student Name";

            datagd.Columns[2].HeaderText = "Department";

            datagd.Columns[3].HeaderText = "Mobile";

            con.Close();
        }
    }
}
