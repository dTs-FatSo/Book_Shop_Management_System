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
            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery(@"
        SELECT 
            c.CartID as [Cart ID],
            u.cName as [Customer Name],
            b.bName as [Book Name],
            c.pAmount as Amount,
            c.pDate as [Purchase Date],
            c.Status
        FROM Cart c
        INNER JOIN Book b ON c.bID = b.bID
        INNER JOIN Customer u ON c.cID = u.cID
        WHERE c.Status = 'Pending'
    ");

            cmd.Connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_pendingorders.DataSource = dt;
            cmd.Connection.Close();
            dgv_pendingorders.Visible = true;
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

            int cartId = Convert.ToInt32(dgv_pendingorders.SelectedRows[0].Cells["Cart ID"].Value);
            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery(""); 
            cmd.Connection.Open();
            SqlTransaction transaction = cmd.Connection.BeginTransaction();

            try
            {
                // 1️⃣ Insert into Purchase
                SqlCommand cmdPurchase = db.GetQuery(@"
            INSERT INTO Purchase (cID, bID, pAmount, pDate)
            SELECT cID, bID, pAmount, GETDATE()
            FROM Cart WHERE CartID = @cartId");
                cmdPurchase.Parameters.AddWithValue("@cartId", cartId);
                cmdPurchase.Connection = cmd.Connection;
                cmdPurchase.Transaction = transaction;
                cmdPurchase.ExecuteNonQuery();

                // 2️⃣ Insert into Sale
                SqlCommand cmdSale = db.GetQuery(@"
            INSERT INTO Sale (eID, bID, saleDate)
            SELECT @eID, bID, GETDATE()
            FROM Cart WHERE CartID = @cartId");
                cmdSale.Parameters.AddWithValue("@cartId", cartId);
                cmdSale.Parameters.AddWithValue("@eID", Session.CurrentOwnerID);
                cmdSale.Connection = cmd.Connection;
                cmdSale.Transaction = transaction;
                cmdSale.ExecuteNonQuery();

                // 3️⃣ Insert into EmployeeAccount
                SqlCommand cmdEmpAcc = db.GetQuery(@"
            INSERT INTO EmployeeAccount (eID, accNumber)
            SELECT @eID, accNumber
            FROM Account
            WHERE cID = (SELECT cID FROM Cart WHERE CartID = @cartId)");
                cmdEmpAcc.Parameters.AddWithValue("@cartId", cartId);
                cmdEmpAcc.Parameters.AddWithValue("@eID", Session.CurrentOwnerID);
                cmdEmpAcc.Connection = cmd.Connection;
                cmdEmpAcc.Transaction = transaction;
                cmdEmpAcc.ExecuteNonQuery();

                // 4️⃣ Update Cart status
                SqlCommand cmdUpdate = db.GetQuery("UPDATE Cart SET Status = 'Confirmed' WHERE CartID = @cartId");
                cmdUpdate.Parameters.AddWithValue("@cartId", cartId);
                cmdUpdate.Connection = cmd.Connection;
                cmdUpdate.Transaction = transaction;
                cmdUpdate.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Order confirmed and added to Purchase history!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error confirming order: " + ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
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

            int cartId = Convert.ToInt32(dgv_pendingorders.SelectedRows[0].Cells["Cart ID"].Value);
            DBConnection db = new DBConnection();

            // 1️⃣ Insert into Purchase
            SqlCommand cmdInsert = db.GetQuery(@"
        INSERT INTO Purchase (cID, bID, pAmount, pDate)
        SELECT cID, bID, pAmount, GETDATE()
        FROM Cart WHERE CartID = @cartId");
            cmdInsert.Parameters.AddWithValue("@cartId", cartId);
            cmdInsert.Connection.Open();
            cmdInsert.ExecuteNonQuery();
            cmdInsert.Connection.Close();

            // 2️⃣ Update Cart status
            SqlCommand cmdUpdate = db.GetQuery("UPDATE Cart SET Status = 'Cancelled' WHERE CartID = @cartId");
            cmdUpdate.Parameters.AddWithValue("@cartId", cartId);
            cmdUpdate.Connection.Open();
            cmdUpdate.ExecuteNonQuery();
            cmdUpdate.Connection.Close();

            LoadPendingOrders();
        }


        private void dgv_pendingorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
