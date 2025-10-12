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
            // Validate input
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

            DBConnection db = new DBConnection();

            // Generate next bID manually
            SqlCommand maxIdCmd = db.GetQuery("SELECT ISNULL(MAX(bID), 0) + 1 FROM Book");
            maxIdCmd.Connection.Open();
            int newID = (int)maxIdCmd.ExecuteScalar();
            maxIdCmd.Connection.Close();

            // Check if book already exists
            SqlCommand checkCmd = db.GetQuery("SELECT COUNT(*) FROM Book WHERE bName = @bName OR ISBN = @isbn");
            checkCmd.Parameters.AddWithValue("@bName", txt_bk_name.Text);
            checkCmd.Parameters.AddWithValue("@isbn", txt_isbn.Text);

            checkCmd.Connection.Open();
            int exists = (int)checkCmd.ExecuteScalar();
            checkCmd.Connection.Close();

            if (exists > 0)
            {
                MessageBox.Show("A book with this name or ISBN already exists in the database!");
                return;
            }

            // Insert new book with manually generated bID
            SqlCommand insertCmd = db.GetQuery(@"INSERT INTO Book (bID, bName, ISBN, bPrice, category) 
                                         VALUES (@bID, @bName, @isbn, @price, @category)");
            insertCmd.Parameters.AddWithValue("@bID", newID);
            insertCmd.Parameters.AddWithValue("@bName", txt_bk_name.Text);
            insertCmd.Parameters.AddWithValue("@isbn", txt_isbn.Text);
            insertCmd.Parameters.AddWithValue("@price", price);
            insertCmd.Parameters.AddWithValue("@category", cmbo_category.Text);

            insertCmd.Connection.Open();
            insertCmd.ExecuteNonQuery();
            insertCmd.Connection.Close();

            MessageBox.Show("Book added successfully!");

            // Clear fields
            txt_bk_name.Clear();
            txt_isbn.Clear();
            txt_price.Clear();
            cmbo_category.SelectedIndex = -1;
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }
    }
}
