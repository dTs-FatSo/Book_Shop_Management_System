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
    public partial class Search_Books : Form
    {
        public Search_Books()
        {
            InitializeComponent();
        }

        private void txt_pur_search_Click(object sender, EventArgs e)
        {
            txt_pur_search.Text = "";
            txt_pur_search.ForeColor = Color.Black;
            txt_pur_search.Font = new Font("Microsoft Uighur", 14, FontStyle.Regular);
        }

        private void btn_pur_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_pur_search.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword.");
                return;
            }
            try
            {
                string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = @"SELECT b.bID as [Book ID],b.bName as [Book Name], a.aID as [Author ID], a.aName as [Author Name], 
                b.bPrice as [Book Price] from Book b inner JOIN WrittenBy p ON b.bID = p.bID inner JOIN Author a ON p.aID = a.aID WHERE b.bName LIKE @keyword OR a.aName LIKE @keyword;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_book.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
