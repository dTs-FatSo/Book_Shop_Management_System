using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Shop_Management_System
{
    public partial class Login : Form
    {
        public string username, pass;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtUname.Text, @"^[a-zA-Z]+$"))
            {
                lblerror.Text = " * Username must only contain letters !";
                return;
            }
            if (txtUname.Text == "")
                lblerror.Text = " * User Name required !";
            if (txtupass.Text == "")
                lblerrorpass.Text = " * Password required !";
            username = txtUname.Text;
            pass = txtupass.Text;
            string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT cid, cname FROM customer WHERE cname = @username AND password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUname.Text);
                        cmd.Parameters.AddWithValue("@pass", txtupass.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Session.CurrentUserID = Convert.ToInt32(reader["cid"]);
                                Session.CurrentUsername = reader["cname"].ToString();

                                user_dashboard u1 = new user_dashboard();
                                u1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void lblerrorpass_Click(object sender, EventArgs e)
        {

        }

        private void lblnewuser1_Click(object sender, EventArgs e)
        {
            Register r1 = new Register();
            r1.Show();
            this.Hide();
        }

        private void lbluname_Click(object sender, EventArgs e)
        {

        }

        private void btnowner_Click(object sender, EventArgs e)
        {
            owner_login own1 = new owner_login();
            own1.Show();
            this.Hide();
        }

        private void lblupass_Click(object sender, EventArgs e)
        {

        }
    }
}
