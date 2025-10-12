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
            if (!rdbmale.Checked && !rdbfemale.Checked && !rdbother.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }
            try
            {
                var addr = new MailAddress(txt_email.Text);
            }
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
            if (checkUnique)
            {
                DBConnection db = new DBConnection();
                SqlCommand cmd = db.GetQuery("SELECT COUNT(*) FROM Customer WHERE cName=@name AND cID<>@id");
                try
                {
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@name", txt_cstmr_name.Text);
                    cmd.Parameters.AddWithValue("@id", selectedCustomerId);
                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("This customer name already exists!");
                        return false;
                    }
                    cmd.CommandText = "SELECT COUNT(*) FROM Customer WHERE email=@email AND cID<>@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@id", selectedCustomerId);
                    exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("This email is already in use!");
                        return false;
                    }
                    cmd.CommandText = "SELECT COUNT(*) FROM Customer WHERE phoneNumber=@phone AND cID<>@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                    cmd.Parameters.AddWithValue("@id", selectedCustomerId);
                    exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("This phone number is already in use!");
                        return false;
                    }
                }
                finally
                {
                    if (cmd.Connection.State == ConnectionState.Open)
                        cmd.Connection.Close();
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

            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery(@"SELECT cID AS [CID], cName AS [Customer Name], phoneNumber AS [Phone Number], email AS [Email], password AS [Password], gender AS [Gender], dateOfBirth AS [BirthDay]
                                  FROM Customer
                                  WHERE cName LIKE @kw OR phoneNumber LIKE @kw OR email LIKE @kw");
            try
            {
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_cstmr_search.DataSource = dt;
                dgv_cstmr_search.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching customers: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

        private void dgv_cstmr_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_cstmr_search.Rows[e.RowIndex].Cells["CID"].Value != null && dgv_cstmr_search.Rows[e.RowIndex].Cells["CID"].Value != DBNull.Value)
            {
                selectedCustomerId = Convert.ToInt32(dgv_cstmr_search.Rows[e.RowIndex].Cells["CID"].Value);
                txt_cstmr_name.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Customer Name"].Value?.ToString() ?? "";
                txt_phone.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Phone Number"].Value?.ToString() ?? "";
                txt_email.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? "";
                txt_pass.Text = dgv_cstmr_search.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? "";
                string gender = dgv_cstmr_search.Rows[e.RowIndex].Cells["Gender"].Value?.ToString() ?? "";
                rdbmale.Checked = gender == "Male";
                rdbfemale.Checked = gender == "Female";
                rdbother.Checked = gender == "Other";
                object dobValue = dgv_cstmr_search.Rows[e.RowIndex].Cells["BirthDay"].Value;
                dtp_dob.Value = dobValue != null && dobValue != DBNull.Value ? Convert.ToDateTime(dobValue) : DateTime.Now;

                txt_cstmr_name.Visible = true;
                txt_phone.Visible = true;
                txt_email.Visible = true;
                txt_pass.Visible = true;
                rdbmale.Visible = true;
                rdbfemale.Visible = true;
                rdbother.Visible = true;
                dtp_dob.Visible = true;
                btn_update.Visible = true;
                btn_delete.Visible = true;
                lbl_cstmr_name.Visible = true;
                lbl_phone.Visible = true;
                lbl_email.Visible = true;
                lbl_pass.Visible = true;
                lblgender.Visible = true;
                lbl_dob.Visible = true;
                btn_add_cstmr.Visible = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId <= 0)
            {
                MessageBox.Show("Select a customer first.");
                return;
            }

            DBConnection db = new DBConnection();
            SqlCommand checkCmd = db.GetQuery("SELECT (SELECT COUNT(*) FROM Account WHERE cID=@id) + (SELECT COUNT(*) FROM Cart WHERE cID=@id) + (SELECT COUNT(*) FROM Purchase WHERE cID=@id) + (SELECT COUNT(*) FROM Report WHERE cID=@id) AS total");
            try
            {
                checkCmd.Connection.Open();
                checkCmd.Parameters.AddWithValue("@id", selectedCustomerId);
                int relatedRecords = Convert.ToInt32(checkCmd.ExecuteScalar());
                checkCmd.Connection.Close();

                if (relatedRecords > 0)
                {
                    MessageBox.Show("Cannot delete customer because they have associated accounts, cart items, purchases, or reports.");
                    return;
                }

                SqlCommand deleteCmd = db.GetQuery("DELETE FROM Customer WHERE cID=@id");
                try
                {
                    deleteCmd.Parameters.AddWithValue("@id", selectedCustomerId);
                    deleteCmd.Connection.Open();
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted.");
                    btn_srch_cstmr.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
                finally
                {
                    if (deleteCmd.Connection.State == ConnectionState.Open)
                        deleteCmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking related records: " + ex.Message);
            }
            finally
            {
                if (checkCmd.Connection.State == ConnectionState.Open)
                    checkCmd.Connection.Close();
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

            string gender = rdbmale.Checked ? "Male" : rdbother.Checked ? "Other" : "Female";

            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery("UPDATE Customer SET cName=@cName, phoneNumber=@phone, email=@Email, password=@Password, gender=@Gender, dateOfBirth=@DOB WHERE cID=@cID");
            try
            {
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@cName", txt_cstmr_name.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txt_pass.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", dtp_dob.Value);
                cmd.Parameters.AddWithValue("@cID", selectedCustomerId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully!");
                btn_srch_cstmr.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

        private void btn_add_cstmr_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery("SELECT ISNULL(MAX(cID), 0) FROM Customer");
            try
            {
                cmd.Connection.Open();
                int newCustomerId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                cmd.CommandText = "INSERT INTO Customer (cID, cName, phoneNumber, email, password, gender, dateOfBirth) VALUES (@cID, @name, @phone, @em, @pass, @gender, @dob)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cID", newCustomerId);
                cmd.Parameters.AddWithValue("@name", txt_cstmr_name.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text.Trim());
                cmd.Parameters.AddWithValue("@em", txt_email.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txt_pass.Text.Trim());
                string gender = rdbmale.Checked ? "Male" : rdbother.Checked ? "Other" : "Female";
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dtp_dob.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added.");
                txt_cstmr_name.Clear();
                txt_phone.Clear();
                txt_email.Clear();
                txt_pass.Clear();
                rdbmale.Checked = false;
                rdbfemale.Checked = false;
                rdbother.Checked = false;
                dtp_dob.Value = DateTime.Now;
                btn_srch_cstmr.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
