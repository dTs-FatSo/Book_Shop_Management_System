using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Shop_Management_System
{
    public partial class Register : Form
    {
        string gender,uname,upass,email,phone,dob;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblbacklog_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void btnsignup_Click(object sender, EventArgs e)

        {
            try
            {
                if
                    (string.IsNullOrWhiteSpace(txtuname.Text) || string.IsNullOrWhiteSpace(txtupass.Text) || string.IsNullOrWhiteSpace(txtemail.Text) || string.IsNullOrWhiteSpace(txtphone.Text) || (!rdbmale.Checked && !rdbfemale.Checked && !rdbother.Checked))
                {
                    MessageBox.Show("Please fill all points correctly ! ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!txtuname.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Username must contain only letters and spaces.",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                if (!long.TryParse(txtphone.Text, out _))
                {
                    MessageBox.Show("Phone number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtemail.Text);
                    if (addr.Address != txtemail.Text)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtupass.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                uname = txtuname.Text;
                upass = txtupass.Text;
                phone = txtphone.Text;
                email = txtemail.Text;
                //dob = dtp_dob_user.Text;
                try
                {
                    string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    String checkquery = "Select count(*) from customer where cname = '" + uname + "'";
                    SqlCommand checkcmd = new SqlCommand(checkquery, conn);
                    int count =(int)checkcmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username Already exists. Please chose different user Name.");
                    }
                    else {
                        try
                        {
                            if (rdbmale.Checked)
                                gender = "Male";
                            if (rdbfemale.Checked)
                                gender = "Female";
                            if (rdbother.Checked)
                                gender = "Others";
                            //string connectionString = @"Data Source=LAPTOP-7FEPICVT;Initial Catalog=BSMS;Integrated Security=True;";
                            //SqlConnection conn = new SqlConnection(connectionString);
                            conn.Open();
                            String query = "insert into customer (cname,phoneNumber,email,password,gender,dateofbirth) values ('" + uname + "','" + phone + "','" + email + "','" + upass + "','" + gender + "','" + dtp_dob_user.Value + "')";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        MessageBox.Show("Account created successfully ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
