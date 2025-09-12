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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_pur_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_pur_search.Text.Trim();
            if (string.IsNullOrEmpty(keyword) ) {
                MessageBox.Show("Please enter a keyword.");
                return;
            }
            try
            {
                string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = @"SELECT b.bID,b.bName, a.aID , a.aName as Author, b.bPrice from Book b inner JOIN WrittenBy p ON b.bID = p.bID inner JOIN Author a ON p.aID = a.aID WHERE b.bName LIKE @keyword OR a.aName LIKE @keyword;";
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
    }
}
