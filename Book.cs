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

namespace Book_Shop_Management_System
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void btn_add_bk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_bk_name.Text) ||
        string.IsNullOrWhiteSpace(txt_isbn.Text) ||
        string.IsNullOrWhiteSpace(txt_price.Text) ||
        string.IsNullOrWhiteSpace(cmbo_category.Text))
            {
                MessageBox.Show("Please fill all fields and select a category.");
                return;
            }

            
            if (!decimal.TryParse(txt_price.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
            {
                conn.Open();


                string checkQuery = "SELECT COUNT(*) FROM Book WHERE bName = @bName OR ISBN = @isbn";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@bName", txt_bk_name.Text);
                checkCmd.Parameters.AddWithValue("@isbn", txt_isbn.Text);

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("A book with this name or ISBN already exists in the database!");
                    return;
                }


                string insertQuery = @"INSERT INTO Book (bName, ISBN, bPrice, category) 
                               VALUES (@bName, @isbn, @price, @category)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@bName", txt_bk_name.Text);
                insertCmd.Parameters.AddWithValue("@isbn", txt_isbn.Text);
                insertCmd.Parameters.AddWithValue("@price", price);
                insertCmd.Parameters.AddWithValue("@category", cmbo_category.Text);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Book added successfully!");

                txt_bk_name.Clear();
                txt_isbn.Clear();
                txt_price.Clear();
                cmbo_category.SelectedIndex = -1;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
