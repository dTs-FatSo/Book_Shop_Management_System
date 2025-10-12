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
    public partial class Sales_history : Form
    {
        public Sales_history()
        {
            InitializeComponent();
            txt_emp_name.Text = Session.CurrentEmployeename;
        }

        private void Sales_history_Load(object sender, EventArgs e)
        {
            string empName = Session.CurrentEmployeename;
            string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    string query = @"SELECT s.saleID AS [Sale ID], e.eName AS [Employee Name], b.bName AS [Book Name], b.ISBN, b.bPrice AS [Price], s.saleDate AS [Sale Date] FROM Sale s INNER JOIN Book b ON s.bID = b.bID INNER JOIN Employee e ON s.eID = e.eID WHERE e.eName = @empName ORDER BY s.saleDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@empName", empName);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_sales_history.DataSource = dt;
                    dgv_sales_history.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales history: " + ex.Message);
            }
        }

        private void txt_emp_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
