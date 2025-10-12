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
            DialogResult result = MessageBox.Show("Are you sure you want to shut down the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txt_own_name.Text == "")
                lblerror.Text = " * User Name required !";
            if (txt_own_pass.Text == "")
                lblerrorpass.Text = " * Password required !";
            username = txt_own_name.Text;
            pass = txt_own_pass.Text;

            
            DBConnection db = new DBConnection();
            SqlCommand cmd = db.GetQuery("SELECT eID, eName FROM Employee WHERE eName = @username AND ePassword = @pass AND role = 'Owner'");

            
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);

            try
            {
                cmd.Connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Session.CurrentOwnerID = Convert.ToInt32(reader["eID"]);
                        Session.CurrentOwnerName = reader["eName"].ToString();
                        owner_dashboard d1 = new owner_dashboard();
                        d1.Show();
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
                cmd.Connection.Close();

            }
        }
    }
}
