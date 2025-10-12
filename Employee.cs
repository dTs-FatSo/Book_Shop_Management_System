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
    public partial class Employee : Form
    {
        string hiddenID;
        public Employee()
        {
            InitializeComponent();
            dgv_employee_search.Visible = false;
            btn_add_employee.Visible = false;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            txt_e_name.Visible = false;
            txt_e_pass.Visible = false;
            txt_salary.Visible = false;
            dtp_e_joining.Visible = false;
            cmbo_role_chose.Visible = false;
            lbl_e_name.Visible = false;
            lbl_e_pass.Visible = false;
            lbl_e_salary.Visible = false;
            lbl_join_date.Visible = false;
            lbl_role.Visible = false;
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_srch_employee_Click(object sender, EventArgs e)
        {
            string keyword = txt_search_employee.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword.");
                return;
            }
            try
            {
                DBConnection db = new DBConnection();
                SqlCommand cmd = db.GetQuery(@"SELECT eID as [Employee ID], eName as [Employee name], salary as Salary, 
                               joiningDate as [Joining date], role as [Role], ePassword as [Employee Password] 
                               FROM Employee WHERE eName LIKE @keyword OR role LIKE @keyword");
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                cmd.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_employee_search.DataSource = dt;
                cmd.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dgv_employee_search.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hiddenID))
            {
                MessageBox.Show("Select an employee first.");
                return;
            }

            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery(@"UPDATE Employee SET eName = @name, salary = @salary, joiningDate = @joiningDate, role = @role, ePassword = @password WHERE eID = @id");
            cmd.Parameters.AddWithValue("@name", txt_e_name.Text);
            cmd.Parameters.AddWithValue("@salary", txt_salary.Text);
            cmd.Parameters.AddWithValue("@joiningDate", dtp_e_joining.Value);
            cmd.Parameters.AddWithValue("@role", cmbo_role_chose.Text);
            cmd.Parameters.AddWithValue("@password", txt_e_pass.Text);
            cmd.Parameters.AddWithValue("@id", hiddenID);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Employee updated successfully!");
            btn_srch_employee.PerformClick(); // reload grid

        }

        private void dgv_employee_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure not header row
            {
                DataGridViewRow row = dgv_employee_search.Rows[e.RowIndex];

                txt_e_name.Text = row.Cells["Employee Name"].Value.ToString();
                txt_salary.Text = row.Cells["Salary"].Value.ToString();
                dtp_e_joining.Value = Convert.ToDateTime(row.Cells["Joining Date"].Value);
                cmbo_role_chose.Text = row.Cells["Role"].Value.ToString();
                txt_e_pass.Text = row.Cells["Employee Password"].Value.ToString();

                // Store Employee ID for update/delete
                hiddenID= row.Cells["Employee ID"].Value.ToString();
            }
            btn_add_employee.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
            txt_e_name.Visible = true;
            txt_e_pass.Visible = true;
            txt_salary.Visible = true;
            dtp_e_joining.Visible = true;
            cmbo_role_chose.Visible = true;
            lbl_e_name.Visible = true;
            lbl_e_pass.Visible = true;
            lbl_e_salary.Visible = true;
            lbl_join_date.Visible = true;
            lbl_role.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hiddenID))
            {
                MessageBox.Show("Select an employee first.");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this employee?",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DBConnection db = new DBConnection();
                SqlCommand cmd = db.GetQuery("DELETE FROM Employee WHERE eID = @id");
                cmd.Parameters.AddWithValue("@id", hiddenID);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                MessageBox.Show("Employee deleted successfully!");
                btn_srch_employee.PerformClick(); // reload grid

            }
            txt_e_name.Visible = false;
            txt_e_pass.Visible = false;
            txt_salary.Visible = false;
            dtp_e_joining.Visible = false;
            cmbo_role_chose.Visible = false;
            lbl_e_name.Visible = false;
            lbl_e_pass.Visible = false;
            lbl_e_salary.Visible = false;
            lbl_join_date.Visible = false;
            lbl_role.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            // 1️⃣ Validate inputs
            if (string.IsNullOrWhiteSpace(txt_e_name.Text) ||
                string.IsNullOrWhiteSpace(txt_salary.Text) ||
                string.IsNullOrWhiteSpace(cmbo_role_chose.Text) ||
                string.IsNullOrWhiteSpace(txt_e_pass.Text))
            {
                MessageBox.Show("Please fill all fields before adding an employee.");
                return;
            }

            if (!decimal.TryParse(txt_salary.Text, out decimal salary))
            {
                MessageBox.Show("Salary must be a valid number.");
                return;
            }

            DBConnection db = new DBConnection();

            try
            {
                // 2️⃣ Generate new eID manually
                SqlCommand getIdCmd = db.GetQuery("SELECT ISNULL(MAX(eID),0)+1 FROM Employee");
                getIdCmd.Connection.Open();
                int newID = (int)getIdCmd.ExecuteScalar();
                getIdCmd.Connection.Close();

                // 3️⃣ Check if employee already exists
                SqlCommand checkCmd = db.GetQuery("SELECT COUNT(*) FROM Employee WHERE eName = @name");
                checkCmd.Parameters.AddWithValue("@name", txt_e_name.Text);
                checkCmd.Connection.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                checkCmd.Connection.Close();

                if (exists > 0)
                {
                    MessageBox.Show("An employee with this name already exists. Try a different name.");
                    return;
                }

                // 4️⃣ Insert new employee with generated eID
                SqlCommand insertCmd = db.GetQuery(@"
            INSERT INTO Employee (eID, eName, salary, joiningDate, role, ePassword) 
            VALUES (@id, @name, @salary, @joiningDate, @role, @password)");
                insertCmd.Parameters.AddWithValue("@id", newID);
                insertCmd.Parameters.AddWithValue("@name", txt_e_name.Text);
                insertCmd.Parameters.AddWithValue("@salary", salary);
                insertCmd.Parameters.AddWithValue("@joiningDate", dtp_e_joining.Value);
                insertCmd.Parameters.AddWithValue("@role", cmbo_role_chose.Text);
                insertCmd.Parameters.AddWithValue("@password", txt_e_pass.Text);

                insertCmd.Connection.Open();
                insertCmd.ExecuteNonQuery();
                insertCmd.Connection.Close();

                MessageBox.Show("Employee added successfully!");

                // 5️⃣ Reset form
                dgv_employee_search.Visible = false;
                txt_e_name.Text = "";
                txt_salary.Text = "";
                txt_e_pass.Text = "";
                dtp_e_joining.Value = DateTime.Now;
                cmbo_role_chose.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_add_new_emp_Click(object sender, EventArgs e)
        {
            dgv_employee_search.Visible = false;
            txt_e_name.Text = "";
            txt_salary.Text = "";
            txt_e_pass.Text = "";
            dtp_e_joining.Value = DateTime.Now;
            cmbo_role_chose.Text = "";
            hiddenID = null;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            txt_search_employee.Text = "";
            txt_e_name.Visible = true;
            txt_e_pass.Visible = true;
            txt_salary.Visible = true;
            dtp_e_joining.Visible = true;
            cmbo_role_chose.Visible = true;
            lbl_e_name.Visible = true;
            lbl_e_pass.Visible = true;
            lbl_e_salary.Visible = true;
            lbl_join_date.Visible = true;
            lbl_role.Visible = true;
            btn_add_employee.Visible = true;
        }
    }
}
