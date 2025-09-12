using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class cstmr : Form

    {
        string username = Session.CurrentUsername;
        public cstmr()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cstmr_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                conn.Open();
                string query = "SELECT phoneNumber, email, password,dateofbirth FROM customer WHERE cname = '" + username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_p_uname.Text = username;
                    txt_p_upass.Text = reader["password"].ToString();
                    txt_p_email.Text = reader["email"].ToString();
                    dtp_p_dob_user.Value = Convert.ToDateTime(reader["dateofbirth"]);
                    txt_p_phone.Text = reader["phoneNumber"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string password = txt_p_upass.Text;
            string email = txt_p_email.Text;
            string phone = txt_p_phone.Text;
            try
            {
                string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string updatequery = "update customer set phoneNumber = '" + phone + "', email= '" + email + "', password = '" + password + "',dateofbirth = '" + dtp_p_dob_user.Value + "' where cname = '"+username+"'";
                    SqlCommand cmd = new SqlCommand(updatequery, conn);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your profile has been updated successfully. ");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again. ");
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
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void txt_p_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
