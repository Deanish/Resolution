using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void connect()
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb");

            try
            {

                con.Open();

                string name = txtName.Text;

                string pwd1 = txtPwd.Text;

                string str = "SELECT * FROM login WHERE user='" + name.ToString() + "' AND pwd='" + pwd1.ToString() + "'";

                OleDbCommand cmd = new OleDbCommand(str, con);

                OleDbDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows == true)
                {

                    Form2 f = new Form2();

                    f.Show();

                    this.Hide();

                }

                else
                {

                    MessageBox.Show("Access Denied", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtName.Clear();

                    txtPwd.Clear();

                    txtName.Focus();

                }

            }

            catch
            {

                MessageBox.Show("Access Denied", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtName.Clear();

                txtPwd.Clear();

                txtName.Focus();

            }

            finally
            {

                con.Close();

            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
