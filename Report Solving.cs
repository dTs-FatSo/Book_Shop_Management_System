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
    public partial class Report_Solving : Form
    {
        string currentRole;

        public Report_Solving(string currentRole)
        {
            InitializeComponent();
            this.currentRole = currentRole;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_Solving_Load(object sender, EventArgs e)
        {
            btn_investigating.Visible = false;
            btn_resolved.Visible = false;
            btn_delete.Visible = false;
        }
        private void UpdateReportStatus(string newStatus)
        {
            if (dgv_submitted_reports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a report first.");
                return;
            }

            int reportId = Convert.ToInt32(dgv_submitted_reports.SelectedRows[0].Cells["Report ID"].Value);
            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery("UPDATE Report SET rStatus=@status WHERE rID=@id");
            try
            {
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", reportId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report status updated to " + newStatus);
                LoadReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating report status: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }
        private void LoadReports()
        {
            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery(@"SELECT r.rID AS [Report ID], r.report AS Report, r.rAgainst AS Against, r.rStatus AS [Report status], r.cID AS [Customer ID], c.cName AS [Customer Name] 
                                  FROM Report r 
                                  INNER JOIN Customer c ON r.cID = c.cID");

            if (currentRole == "Employee")
                cmd.CommandText += " WHERE rAgainst NOT IN ('Employee','Owner')";
            else if (currentRole == "Author")
                cmd.CommandText += " WHERE rAgainst = 'Author'";

            try
            {
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_submitted_reports.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }


        private void btn_submit_reports_Click(object sender, EventArgs e)
        {
         LoadReports();
            if (currentRole == "Owner")
            {
                btn_investigating.Visible = true;
                btn_resolved.Visible = true;
                btn_delete.Visible = true;
            }
            else if (currentRole == "Employee")
            {
                btn_investigating.Visible = true;
                btn_resolved.Visible = true;
                btn_delete.Visible = false;
            }
            else if (currentRole == "Author")
            {
                btn_investigating.Visible = false;
                btn_resolved.Visible = false;
                btn_delete.Visible = false;
            }
        }

        private void btn_resolved_Click(object sender, EventArgs e)
        {
            UpdateReportStatus("Resolved");
        }

        private void btn_investigating_Click(object sender, EventArgs e)
        {
            UpdateReportStatus("Investigating");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_submitted_reports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a report first.");
                return;
            }

            int reportId = Convert.ToInt32(dgv_submitted_reports.SelectedRows[0].Cells["Report ID"].Value);
            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery("DELETE FROM Report WHERE rID=@id");
            try
            {
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@id", reportId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report deleted.");
                LoadReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting report: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }
    }
}
