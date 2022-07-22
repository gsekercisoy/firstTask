using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicDbLoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM admin where id=@user AND password=@pass";

            con = new SqlConnection("server=.; Initial Catalog=dbTaskExample;Integrated Security=true");
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Welcome!");
                con.Close();
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                f2.admin = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Wrong id or password!");
            }
        }
    }
}
