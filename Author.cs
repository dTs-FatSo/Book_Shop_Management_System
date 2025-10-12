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
    public partial class Author : Form

    {
        int selectedBookId = -1;
        

        public Author()
        {
            InitializeComponent();
            lbl_author_name.Visible = false;
            txt_author_name.Visible = false;
            btn_add_author.Visible = false;
        }

        private void txt_pur_search_TextChanged(object sender, EventArgs e)
        {

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
                DBConnection db = new DBConnection();
                SqlCommand cmd = db.GetQuery(@"
                    SELECT 
                        b.bID    AS [Book ID],
                        b.bName  AS [Book Name],
                        a.aID    AS [Author ID],
                        a.aName  AS [Author Name],
                        b.bPrice AS [Book Price]
                    FROM Book b
                    LEFT JOIN WrittenBy wb ON b.bID = wb.bID
                    LEFT JOIN Author a    ON wb.aID = a.aID
                    WHERE b.bName LIKE @keyword OR a.aName LIKE @keyword
                    ORDER BY b.bName;");
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                cmd.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_book.DataSource = dt;
                cmd.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            dgv_book.Visible = true;
            selectedBookId = -1;
            lbl_author_name.Visible = false;
            txt_author_name.Visible = false;
            btn_add_author.Visible = false;
        }

        private void txt_pur_search_Click(object sender, EventArgs e)
        {
            txt_pur_search.Text = "";
            txt_pur_search.ForeColor = Color.Black;
            txt_pur_search.Font = new Font("Microsoft Uighur", 14, FontStyle.Regular);
        }

        private void dgv_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_book.Rows.Count == 0)
            {
                MessageBox.Show("No books available to select.");
                return;
            }

            if (e.RowIndex >= 0)
            {
                var row = dgv_book.Rows[e.RowIndex];

                object bidObj = row.Cells["Book ID"].Value;
                if (bidObj == null || bidObj == DBNull.Value)
                {
                    MessageBox.Show("Selected row does not contain a valid Book ID.");
                    return;
                }

                selectedBookId = Convert.ToInt32(bidObj);

                object authorObj = row.Cells["Author Name"].Value;
                string existingAuthor = (authorObj == null || authorObj == DBNull.Value)
                                        ? string.Empty
                                        : authorObj.ToString();

                if (!string.IsNullOrEmpty(existingAuthor))
                {
                    MessageBox.Show("Author already assigned: " + existingAuthor);
                    lbl_author_name.Visible = false;
                    txt_author_name.Visible = false;
                    btn_add_author.Visible = false;
                }
                else
                {
                    lbl_author_name.Visible = true;
                    txt_author_name.Visible = true;
                    btn_add_author.Visible = true;
                    txt_author_name.Text = "";
                    txt_author_name.Focus();
                }
            }
        }

        private void Author_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_author_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_add_author_Click_1(object sender, EventArgs e)
        {
            if (selectedBookId <= 0)
            {
                MessageBox.Show("Please select a book first.");
                return;
            }

            string authorName = txt_author_name.Text.Trim();
            if (string.IsNullOrEmpty(authorName))
            {
                MessageBox.Show("Please enter an author name.");
                return;
            }

            DBConnection db = new DBConnection();
            SqlCommand tempCmd = db.GetQuery("SELECT 1"); // Get a connection
            SqlConnection connection = tempCmd.Connection; // Reuse this connection
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int authorId;

                    // Check if author exists
                    SqlCommand checkAuthorCmd = new SqlCommand("SELECT aID FROM Author WHERE aName = @aName", connection);
                    checkAuthorCmd.Parameters.AddWithValue("@aName", authorName);
                    checkAuthorCmd.Transaction = transaction;

                    object result = checkAuthorCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        authorId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Get next aID manually
                        SqlCommand getMaxIdCmd = new SqlCommand("SELECT ISNULL(MAX(aID), 0) FROM Author", connection);
                        getMaxIdCmd.Transaction = transaction;
                        int newAuthorId = Convert.ToInt32(getMaxIdCmd.ExecuteScalar()) + 1;

                        // Insert new author with generated ID
                        SqlCommand insertAuthorCmd = new SqlCommand("INSERT INTO Author (aID, aName, aPass) VALUES (@aID, @aName, @aPass)", connection);
                        insertAuthorCmd.Parameters.AddWithValue("@aID", newAuthorId);
                        insertAuthorCmd.Parameters.AddWithValue("@aName", authorName);
                        insertAuthorCmd.Parameters.AddWithValue("@aPass", ""); // Default empty password; adjust as needed
                        insertAuthorCmd.Transaction = transaction;
                        insertAuthorCmd.ExecuteNonQuery();

                        authorId = newAuthorId;
                    }

                    // Check if author is already assigned to this book
                    SqlCommand checkWB = new SqlCommand("SELECT COUNT(*) FROM WrittenBy WHERE aID = @aID AND bID = @bID", connection);
                    checkWB.Parameters.AddWithValue("@aID", authorId);
                    checkWB.Parameters.AddWithValue("@bID", selectedBookId);
                    checkWB.Transaction = transaction;

                    int existsWB = Convert.ToInt32(checkWB.ExecuteScalar());
                    if (existsWB > 0)
                    {
                        MessageBox.Show("This author is already assigned to the selected book.");
                        transaction.Rollback();
                        return;
                    }

                    // Insert into WrittenBy
                    SqlCommand insertWB = new SqlCommand("INSERT INTO WrittenBy (aID, bID) VALUES (@aID, @bID)", connection);
                    insertWB.Parameters.AddWithValue("@aID", authorId);
                    insertWB.Parameters.AddWithValue("@bID", selectedBookId);
                    insertWB.Transaction = transaction;
                    insertWB.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Author assigned successfully!");

                    lbl_author_name.Visible = false;
                    txt_author_name.Visible = false;
                    btn_add_author.Visible = false;
                    txt_author_name.Text = "";
                    btn_pur_search.PerformClick();
                }
                catch (Exception ex)
                {
                    try { transaction.Rollback(); } catch { }
                    MessageBox.Show("Error while assigning author: " + ex.Message);
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
