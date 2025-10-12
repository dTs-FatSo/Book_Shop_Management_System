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
    public partial class top_sold : Form
    {
        public top_sold()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_top_bks_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
                {
                    string query = @"
            SELECT TOP 10 
                a.aName AS [Author Name], 
                b.bName AS [Book Name], 
                b.bPrice as Price, 
                b.category as Category, 
                COUNT(s.saleID) AS TotalSold
            FROM Sale s
            INNER JOIN Book b ON s.bID = b.bID
            INNER JOIN WrittenBy w ON b.bID = w.bID
            INNER JOIN Author a ON w.aID = a.aID
            GROUP BY a.aName, b.bName, b.bPrice, b.category
            ORDER BY TotalSold DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No ranking available yet.");
                        dgv_top_sold_bks.DataSource = null;
                    }
                    else
                    {
                        dgv_top_sold_bks.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
