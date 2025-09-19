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
    public partial class owner_approve : Form
    {
        public owner_approve()
        {
            InitializeComponent();
            dgv_pendingorders.Visible = false;
        }

        private void owner_approve_Load(object sender, EventArgs e)
        {

        }
        public void LoadPendingOrders()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
            {
                conn.Open();
                string query = @"
            SELECT 
                c.CartID,
                u.cname,
                b.bName,
                c.pAmount,
                c.pDate,
                c.Status
            FROM Cart c
            INNER JOIN Book b ON c.bID = b.bID
            INNER JOIN customer u ON c.cid = u.cid
            WHERE c.Status = 'Pending'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_pendingorders.DataSource = dt;
                dgv_pendingorders.Visible = true;
            }
        }

        private void btn_pending_Click(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void dgv_pendingorders_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (dgv_pendingorders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an order to confirm.");
                return;
            }

            int cartId = Convert.ToInt32(dgv_pendingorders.SelectedRows[0].Cells["CartID"].Value);

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {

                    string insertPurchaseQuery = @" INSERT INTO Purchase (cID, bID, pAmount, pDate) SELECT cID, bID, pAmount, GETDATE() FROM Cart WHERE CartID = @cartId";

                    using (SqlCommand cmd = new SqlCommand(insertPurchaseQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.ExecuteNonQuery();
                    }
                    string insertSaleQuery = @"INSERT INTO Sale (eID, bID, saleDate) SELECT @eID, bID, GETDATE() FROM Cart WHERE CartID = @cartId";

                    using (SqlCommand cmd = new SqlCommand(insertSaleQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.Parameters.AddWithValue("@eID", Session.CurrentOwnerID);
                        cmd.ExecuteNonQuery();
                    }
                    string insertemployeeAccounteQuery = @"INSERT INTO EmployeeAccount (eID,accNumber) select @eID, accNumber from Account where cid = (select cid from Cart where CartID = @cartID)";

                    using (SqlCommand cmd = new SqlCommand(insertemployeeAccounteQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.Parameters.AddWithValue("@eID", Session.CurrentOwnerID);
                        cmd.ExecuteNonQuery();
                    }

                    // Update cart status
                    string updateQuery = "UPDATE Cart SET Status = 'Confirmed' WHERE CartID = @cartId";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn,transaction))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    MessageBox.Show("Order confirmed and added to Purchase history!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error confirming order. "+ ex.Message );
                }
            }
            LoadPendingOrders();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (dgv_pendingorders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an order to cancel.");
                return;
            }

            int cartId = Convert.ToInt32(dgv_pendingorders.SelectedRows[0].Cells["CartID"].Value);

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
            {
                conn.Open();

                // Move cart → purchase
                string insertQuery = @"
            INSERT INTO Purchase (cID, bID, pAmount, pDate)
            SELECT cID, bID, pAmount, GETDATE()
            FROM Cart WHERE CartID = @cartId";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@cartId", cartId);
                    cmd.ExecuteNonQuery();
                }

                // Update cart status
                string updateQuery = "UPDATE Cart SET Status = 'Cancelled' WHERE CartID = @cartId";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@cartId", cartId);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
