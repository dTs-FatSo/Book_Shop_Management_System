using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Shop_Management_System
{
    public partial class Login : Form
    {
        public string username = "jihad";
        public string pass = "143611";
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
            if (txtUname.Text == "")
                lblerror.Text = " * User Name required !";
            if (txtupass.Text == "")
                lblerrorpass.Text = " * Password required !";
            if (txtUname.Text == username && txtupass.Text == pass)
            {
                MessageBox.Show("Login Successfully !");
            }
            else
            {
                MessageBox.Show("Invalid Credentials !");
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

        private void lblupass_Click(object sender, EventArgs e)
        {

        }
    }
}
