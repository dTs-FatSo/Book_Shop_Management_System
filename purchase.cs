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
            dgv_book.Visible = false;
            btn_purchase.Visible = false;
            dgv_purchase_history.Visible = false;
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
                string query = @"SELECT b.bID as [Book ID],b.bName as [Book Name], a.aID as [Author ID], a.aName as [Author Name], b.bPrice as [Book Price] from Book b inner JOIN WrittenBy p ON b.bID = p.bID inner JOIN Author a ON p.aID = a.aID WHERE b.bName LIKE @keyword OR a.aName LIKE @keyword;";
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
            dgv_book.Visible = true;
            btn_purchase.Visible = false;
            dgv_purchase_history.Visible = false;

        }

        private void txt_pur_search_Click(object sender, EventArgs e)
        {
            txt_pur_search.Text = "";
            txt_pur_search.ForeColor = Color.Black;
            txt_pur_search.Font = new Font("Microsoft Uighur",14, FontStyle.Regular);
        }

        private void txt_pur_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_purchase.Visible = true;
            }
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (dgv_book.SelectedRows.Count == 0) // no row selected
            {
                MessageBox.Show("Please select a book before purchasing.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dgv_book.SelectedRows[0];
            int bookId = Convert.ToInt32(row.Cells["Book ID"].Value);
            decimal price = Convert.ToDecimal(row.Cells["Book Price"].Value);
            int cid= Session.CurrentUserID;

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO Cart (cID, bID, pAmount, pDate, Status) 
                               VALUES (@cid, @bID, @pAmount, @pDate, @status)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@bID", bookId);
                    cmd.Parameters.AddWithValue("@pAmount", price);
                    cmd.Parameters.AddWithValue("@pDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@status", "Pending");
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book Added to cart successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add to  cart. Please try again.");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_p_history_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                           p.purchaseID, 
                           b.bName AS [Book Name], 
                           a.aName AS [Author Name], 
                           p.pDate AS [Purchase Date], 
                           p.pAmount AS [Price]
                            FROM Purchase p
                            INNER JOIN Book b ON p.bID = b.bID
                            INNER JOIN WrittenBy w ON b.bID = w.bID
                            INNER JOIN Author a ON w.aID = a.aID
                            WHERE p.cid = @cid
                            ORDER BY p.pDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid",Session.CurrentUserID);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgv_purchase_history.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading purchase history: " + ex.Message);
                }
            }
            dgv_purchase_history.Visible = true;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchase_Load(object sender, EventArgs e)
        {

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                c.CartID,
                b.bName AS [Book Name],
                c.pAmount AS [Price],
                c.pDate AS [Added Date],
                c.Status
            FROM Cart c
            INNER JOIN Book b ON c.bID = b.bID
            WHERE c.cID = @cid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", Session.CurrentUserID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_purchase_history.DataSource = dt;
                }
            }
            dgv_purchase_history.Visible = true;
        }
    }
}
