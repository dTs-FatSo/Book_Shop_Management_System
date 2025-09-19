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
    public partial class User_receipt : Form
    {
        public User_receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_receipt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT b.bName as [Book Name], p.pAmount as [Price], p.pDate as [Purchase Date]
                         FROM Purchase p
                         INNER JOIN Book b ON p.bID = b.bID
                         WHERE p.cID = @userID 
                           AND CAST(p.pDate AS DATE) = CAST(GETDATE() AS DATE);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", Session.CurrentUserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_receipt.DataSource = dt;
                    decimal total = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        total += Convert.ToDecimal(row["Price"]);
                    }
                    lbl_total.Text = "Total Today: " + total.ToString("C");
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
