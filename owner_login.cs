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
    public partial class owner_login : Form

    {
        string username, pass;
        public owner_login()
        {
            InitializeComponent();
        }

        private void owner_login_Load(object sender, EventArgs e)
        {

        }

        private void txt_own_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void btn_owner_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txt_own_name.Text == "")
                lblerror.Text = " * User Name required !";
            if (txt_own_pass.Text == "")
                lblerrorpass.Text = " * Password required !";
            username = txt_own_name.Text;
            pass = txt_own_pass.Text;
            string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                String query = "Select count(*) from Employee where eName = '" + username + "' and ePassword = '" + pass + "' and role = 'Owner' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {

                    Session.CurrentOwnerName = txt_own_name.Text;
                    owner_dashboard d1 = new owner_dashboard();
                    d1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
                cmd.ExecuteNonQuery();
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
