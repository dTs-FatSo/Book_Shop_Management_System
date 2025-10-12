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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxt_rprt_write.Text) || cmbo_against.SelectedIndex == -1)
            {
                MessageBox.Show("Please select whom you are reporting against and write your report.");
                return;
            }
            try
            {
                string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    string query = "INSERT INTO Report (cid, report, rAgainst, rStatus) VALUES (@cid, @report, @against, 'Pending')";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", Session.CurrentUserID); // assuming session holds logged-in cid
                        cmd.Parameters.AddWithValue("@report", rtxt_rprt_write.Text.Trim());
                        cmd.Parameters.AddWithValue("@against", cmbo_against.SelectedItem.ToString());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting report: " + ex.Message);
                return;
            }
            MessageBox.Show("Report submitted successfully! Status is pending.");
            rtxt_rprt_write.Clear();
            cmbo_against.SelectedIndex = -1;
        }

        private void btn_previous_reports_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = @"SELECT rID AS [Report ID], 
                                report AS [Report], 
                                rAgainst AS [Against], 
                                rStatus AS [Status]
                         FROM Report 
                         WHERE cid = @cid
                         ORDER BY rID DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@cid", Session.CurrentUserID);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_reports.DataSource = dt;
                dgv_reports.Visible = true;
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dgv_reports.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_reports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a report to delete.");
                return;
            }
            int reportID = Convert.ToInt32(dgv_reports.SelectedRows[0].Cells["Report ID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this report?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            try
            {
                string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    string query = "DELETE FROM Report WHERE rID = @rid AND cid = @cid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rid", reportID);
                        cmd.Parameters.AddWithValue("@cid", Session.CurrentUserID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Report deleted successfully.");

                            // Refresh the grid after deletion
                            btn_previous_reports_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete report. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting report: " + ex.Message);
            }
        }

        private void dgv_reports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
