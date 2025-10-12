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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Shop_Management_System
{
    public partial class Employee_Login : Form
    {
        string username, pass;
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void btn_emp_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txt_emp_name.Text == "")
                lblerror.Text = " * User Name required !";
            if (txt_emp_pass.Text == "")
                lblerrorpass.Text = " * Password required !";
            username = txt_emp_name.Text;
            pass = txt_emp_pass.Text;
            string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                String query = "Select eID, eName from Employee where eName = '" + username + "' and ePassword = '" + pass + "' and role = 'Seller' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Session.CurrentOwnerID = Convert.ToInt32(reader["eID"]);
                        Session.CurrentEmployeename = reader["eName"].ToString();
                        Employee_Dashboard e1 = new Employee_Dashboard();
                        e1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
