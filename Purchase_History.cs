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
    public partial class Purchase_History : Form
    {
        public Purchase_History()
        {
            InitializeComponent();
        }

        private void btn_p_history_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
            {
                try
                {
                    string query = @"
                SELECT 
                    c.cName AS [Customer Name],
                    b.bName AS [Book Name],
                    p.pDate AS [Purchase Date],
                    b.bPrice AS [Book Price]
                FROM Purchase p
                INNER JOIN Customer c ON p.cID = c.cID
                INNER JOIN Book b ON p.bID = b.bID
                ORDER BY p.pDate DESC;";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_purchase_history.DataSource = dt;   // your DataGridView
                    dgv_purchase_history.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading purchase history: " + ex.Message);
                }
            }
        }

        private void dgv_purchase_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
