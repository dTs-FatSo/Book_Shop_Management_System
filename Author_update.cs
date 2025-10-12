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
    public partial class Author_update : Form
    {
        int author_id = Session.CurrentAuthorID;
        public Author_update()
        {
            InitializeComponent();
        }

        private void Author_update_Load(object sender, EventArgs e)
        {
            txt_authr_name.Visible = false;
            txt_authr_pass.Visible = false;
            lbl_authr_name.Visible = false;
            lbl_authr_pass.Visible = false;
            btn_update.Visible = false;
        }

        private void btn_click_update_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    string query = "SELECT aName, aPass FROM Author WHERE aID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", author_id);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_authr_name.Text = reader["aName"].ToString();
                        txt_authr_pass.Text = reader["aPass"].ToString();

                        // Reveal the fields
                        txt_authr_name.Visible = true;
                        txt_authr_pass.Visible = true;
                        btn_update.Visible = true;
                        lbl_authr_name.Visible = true;
                        lbl_authr_pass.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_authr_name.Text) || string.IsNullOrWhiteSpace(txt_authr_pass.Text))
            {
                MessageBox.Show("Name and Password cannot be empty.");
                return;
            }

            try
            {
                string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Author WHERE aName=@name AND aID<>@id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@name", txt_authr_name.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@id", author_id);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("This author name already exists! Choose a different name.");
                        return;
                    }

                    string query = "UPDATE Author SET aName=@name, aPass=@pass WHERE aID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txt_authr_name.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_authr_pass.Text);
                    cmd.Parameters.AddWithValue("@id", author_id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }

            MessageBox.Show("Profile updated successfully.");
            Session.CurrentAuthorName = txt_authr_name.Text;
            if(this.ParentForm is Author_Dashboard dashboard)
            {
                dashboard.RefreshAuthorName();
            }

            txt_authr_name.Clear();
            txt_authr_pass.Clear();

        }

        private void btn_bks_you_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    string query = @"SELECT b.bID AS [Book ID], 
                                        b.bName AS [Book Name], 
                                        b.ISBN, 
                                        b.bPrice AS [Price], 
                                        b.category AS [Category]
                                 FROM Book b
                                 INNER JOIN WrittenBy w ON b.bID = w.bID
                                 WHERE w.aID = @id";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@id", author_id);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_bks_you.DataSource = dt;
                    dgv_bks_you.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }   
        }

        private void dgv_bks_you_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
