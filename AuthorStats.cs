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
    public partial class AuthorStats : Form
    {
        int author_id = Session.CurrentAuthorID;
        public AuthorStats()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
        private void LoadStats(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@aID", author_id);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_stats.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void AuthorStats_Load(object sender, EventArgs e)
        {

        }

        private void btn_sold_bks_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT b.bName AS [Book Name], COUNT(p.bID) AS [Total Sold]
                FROM Book b
                INNER JOIN WrittenBy w ON b.bID = w.bID
                INNER JOIN Purchase p ON b.bID = p.bID
                WHERE w.aID = @aID
                GROUP BY b.bName
                ORDER BY [Total Sold] DESC;";
            LoadStats(query);
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT b.Category, COUNT(p.bID) AS [Total Sold]
                FROM Book b
                INNER JOIN WrittenBy w ON b.bID = w.bID
                INNER JOIN Purchase p ON b.bID = p.bID
                WHERE w.aID = @aID
                GROUP BY b.Category
                ORDER BY [Total Sold] DESC;";
            LoadStats(query);
        }

        private void btn_gender_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT c.Gender, COUNT(p.bID) AS [Total Purchased]
                FROM Customer c
                INNER JOIN Purchase p ON c.cID = p.cID
                INNER JOIN WrittenBy w ON p.bID = w.bID
                WHERE w.aID = @aID
                GROUP BY c.Gender;";
            LoadStats(query);
        }

        private void btn_Age_group_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    CASE 
                        WHEN DATEDIFF(YEAR, c.dateofbirth, GETDATE()) < 20 THEN 'Below 20'
                        WHEN DATEDIFF(YEAR, c.dateofbirth, GETDATE()) BETWEEN 20 AND 30 THEN '20-30'
                        WHEN DATEDIFF(YEAR, c.dateofbirth, GETDATE()) BETWEEN 31 AND 40 THEN '31-40'
                        ELSE '40+'
                    END AS AgeGroup,
                    COUNT(p.bID) AS [Total Purchased]
                FROM Customer c
                INNER JOIN Purchase p ON c.cID = p.cID
                INNER JOIN WrittenBy w ON p.bID = w.bID
                WHERE w.aID = @aID
                GROUP BY 
                    CASE 
                        WHEN DATEDIFF(YEAR, c.dateofbirth, GETDATE()) < 20 THEN 'Below 20'
                        WHEN DATEDIFF(YEAR, c.dateofbirth, GETDATE()) BETWEEN 20 AND 30 THEN '20-30'
                        WHEN DATEDIFF(YEAR, c.dateofbirth, GETDATE()) BETWEEN 31 AND 40 THEN '31-40'
                        ELSE '40+'
                    END;";
            LoadStats(query);
        }
    }
}
