using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class update_cstmr : Form
    {
        string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
        int selectedCustomerId = -1;
        public update_cstmr()
        {
            InitializeComponent();
            txt_cstmr_name.Visible = false;
            txt_phone.Visible = false;
            txt_email.Visible = false;
            txt_pass.Visible = false;
            rdbmale.Visible = false;
            rdbfemale.Visible = false;
            rdbother.Visible = false;
            dtp_dob.Visible = false;
            btn_add_cstmr.Visible = false;
            btn_update.Visible = false;
            btn_delete.Visible = false;
            lbl_cstmr_name.Visible = false;
            lbl_phone.Visible = false;
            lbl_email.Visible = false;
            lbl_pass.Visible = false;
            lblgender.Visible = false;
            lbl_dob.Visible = false;

        }
        private bool ValidateInputs(bool checkUnique = true)
        {
            if (string.IsNullOrEmpty(txt_cstmr_name.Text) ||
                string.IsNullOrEmpty(txt_phone.Text) ||
                string.IsNullOrEmpty(txt_email.Text) ||
                string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }
            if (!rdbmale.Checked && !rdbfemale.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }
            try 
            { var addr = new MailAddress(txt_email.Text); }
            catch
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }
            if (txt_phone.Text.Length < 6 || txt_phone.Text.Length > 15)
            {
                MessageBox.Show("Phone number must be between 6 and 15 digits.");
                return false;
            }
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                if (checkUnique)
                {
                    string query = "SELECT COUNT(*) FROM Customer WHERE cName=@name AND cID<>@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txt_cstmr_name.Text);
                    cmd.Parameters.AddWithValue("@id", selectedCustomerId);
                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("This customer name already exists!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void btn_add_new_cstmr_Click(object sender, EventArgs e)
        {
            txt_cstmr_name.Visible = true;
            txt_phone.Visible = true;
            txt_email.Visible = true;
            txt_pass.Visible = true;
            rdbmale.Visible = true;
            rdbfemale.Visible = true;
            dtp_dob.Visible = true;
            btn_add_cstmr.Visible = true;
            lbl_cstmr_name.Visible = true;
            lbl_phone.Visible = true;
            lbl_email.Visible = true;
            lbl_pass.Visible = true;
            lblgender.Visible = true;
            lbl_dob.Visible = true;
            rdbother.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
            selectedCustomerId = -1; // Reset selected customer
            txt_cstmr_name.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_pass.Clear();
            rdbmale.Checked = false;
            rdbfemale.Checked = false;
            dtp_dob.Value = DateTime.Now;
            rdbother.Checked = false;
            dgv_cstmr_search.Visible=false;
            txt_search_cstmr.Clear();
        }

        private void update_cstmr_Load(object sender, EventArgs e)
        {

        }

        private void btn_srch_cstmr_Click(object sender, EventArgs e)
        {
            string keyword = txt_search_cstmr.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Enter something to search.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = @"SELECT cid as [CID], cname as [Customer Name], phoneNumber as [Phone Number], email as [Email], password as [Password], gender as [Gender], dateOfbirth as [BirthDay]
                                 FROM Customer
                                 WHERE cname LIKE @kw OR phoneNumber LIKE @kw OR email LIKE @kw";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_cstmr_search.DataSource = dt;
            }

        }

        private void dgv_cstmr_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_cstmr_search.Rows[e.RowIndex].Cells["CID"].Value != null)
            {
                selectedCustomerId = Convert.ToInt32(dgv_cstmr_search.Rows[e.RowIndex].Cells["cID"].Value);

                txt_cstmr_name.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Customer Name"].Value.ToString();
                txt_phone.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Phone Number"].Value.ToString();
                txt_email.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txt_pass.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                string gender = dgv_cstmr_search.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                if (gender == "Male")
                {
                    rdbmale.Checked = true;
                    rdbfemale.Checked = false;
                }
                else if (gender == "Female")
                {
                    rdbmale.Checked = false;
                    rdbfemale.Checked = true;
                }
                dtp_dob.Value = Convert.ToDateTime(dgv_cstmr_search.Rows[e.RowIndex].Cells["Birthday"].Value);
            }
            txt_cstmr_name.Visible = true;
            txt_phone.Visible = true;
            txt_email.Visible = true;
            txt_pass.Visible = true;
            rdbmale.Visible = true;
            rdbfemale.Visible = true;
            dtp_dob.Visible = true;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            lbl_cstmr_name.Visible = true;
            lbl_phone.Visible = true;
            lbl_email.Visible = true;
            lbl_pass.Visible = true;
            lblgender.Visible = true;
            lbl_dob.Visible = true;
            rdbother.Visible = true;
            btn_add_cstmr.Visible = false;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId <= 0)
            {
                MessageBox.Show("Select a customer first.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string query = "DELETE FROM Customer WHERE cID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedCustomerId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer deleted.");
                btn_srch_cstmr.PerformClick();
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string gender = rdbmale.Checked ? "Male" : "Female";

            try
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "UPDATE Customer SET cname=@cName, phoneNumber=@phone, email=@Email, password=@Password, gender=@Gender, dateOfbirth=@DOB WHERE cID=@cID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cName", txt_cstmr_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txt_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txt_pass.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", dtp_dob.Value);
                        cmd.Parameters.AddWithValue("@cID", selectedCustomerId); // keep track of selected customer
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
                return;
            }

            MessageBox.Show("Customer updated successfully!");
            btn_srch_cstmr.PerformClick(); // Refresh the search results
        }

        private void btn_add_cstmr_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string query = @"INSERT INTO Customer (cname, phoneNumber, email, password, gender, dateOfbirth)
                                 VALUES (@name, @phone, @em, @pass, @gender, @dob)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txt_cstmr_name.Text);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@em", txt_email.Text);
                cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                string gender = rdbmale.Checked ? "Male" : "Female";
                cmd.Parameters.AddWithValue("@gender",gender);
                cmd.Parameters.AddWithValue("@dob", dtp_dob.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added.");
                txt_cstmr_name.Clear();
                txt_phone.Clear();
                txt_email.Clear();
                txt_pass.Clear();
                rdbmale.Checked = false;
                rdbfemale.Checked = false;
                dtp_dob.Value = DateTime.Now;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
