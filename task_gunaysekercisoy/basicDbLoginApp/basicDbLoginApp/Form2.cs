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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string admin = string.Empty;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        public void getdata()
        {
            con = new SqlConnection("server=.; Initial Catalog=dbTaskExample;Integrated Security=true");
            da = new SqlDataAdapter("select * from books ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "books");
            dataGridView1.DataSource = ds.Tables["books"];
            con.Close();
        }        
        private void Form2_Load(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
