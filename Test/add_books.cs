using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\idwbya\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        public add_books()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books_info values('"+ guna2TextBox1.Text +"', '"+ guna2TextBox2.Text + "', '"+guna2TextBox3.Text+"', '"+ datepicker.Text + "', '"+ guna2TextBox5.Text + "', '"+ guna2TextBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Books Added Successfully!");
            this.Hide();
        }

        private void add_books_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void datepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books_info values('" + guna2TextBox1.Text + "', '" + guna2TextBox2.Text + "', '" + guna2TextBox3.Text + "', '" + datepicker.Text + "', '" + guna2TextBox5.Text + "', '" + guna2TextBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Books Added Successfully!");
            this.Hide();
        }
    }
}
