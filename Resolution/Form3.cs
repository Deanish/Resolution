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
    public partial class Form3 : Form
    {
        public Form3()
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

                string str = "insert into reg values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + checkBox1.Checked.ToString() + "','" + checkBox2.Checked.ToString() + "','" + checkBox3.Checked.ToString() + "','" + checkBox4.Checked.ToString() + "','" + checkBox5.Checked.ToString() + "','" + checkBox6.Checked.ToString() + "','" + checkBox7.Checked.ToString() + "','" + checkBox8.Checked.ToString() + "','" + checkBox9.Checked.ToString() + "','" + checkBox10.Checked.ToString() + "')";

                OleDbCommand cmd = new OleDbCommand(str, con);

               // OleDbDataReader rdr = cmd.ExecuteReader();

                int i = cmd.ExecuteNonQuery();
                
                MessageBox.Show(i+" Student Registered");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                textBox1.Focus();
               
            }

            catch
            {

                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
            }

            finally
            {

                con.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
