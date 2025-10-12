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
    public partial class Employee_update : Form
    {
        string cs = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
        public Employee_update()
        {
            InitializeComponent();
        }

        private void Employee_update_Load(object sender, EventArgs e)
        {
            txt_e_name.Text = Session.CurrentEmployeename;
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string query = "SELECT ePassword FROM Employee WHERE eName = @eName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eName", Session.CurrentEmployeename);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txt_e_pass.Text = reader["ePassword"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_e_name.Text) || string.IsNullOrWhiteSpace(txt_e_pass.Text))
            {
                MessageBox.Show("Name and Password cannot be empty.");
                return;
            }
            try
            {

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string query = "UPDATE Employee SET eName = @name, ePassword = @pass WHERE eName = @eName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txt_e_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@eName", Session.CurrentEmployeename);
                        cmd.Parameters.AddWithValue("@pass", txt_e_pass.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
                return;
            }

            MessageBox.Show("Profile updated successfully!");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
