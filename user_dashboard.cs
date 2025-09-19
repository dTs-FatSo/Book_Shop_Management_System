using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop_Management_System
{
    public partial class user_dashboard : Form
    {
        public user_dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.pnl_user_main.Controls.Count > 0)
                this.pnl_user_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_user_main.Controls.Add(f);
            this.pnl_user_main.Tag = f;
            f.Show();
        }

        private void lbluname_Click(object sender, EventArgs e)
        {

        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void user_dashboard_Load(object sender, EventArgs e)
        {
            txt_d_uname.Text = Session.CurrentUsername;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            loadform(new cstmr());
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Close();
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void pnl_user_side_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_search_book_Click(object sender, EventArgs e)
        {
            loadform(new purchase());
        }

        private void pnl_user_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_user_up_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_u_dash_Click(object sender, EventArgs e)
        {

        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            loadform(new User_receipt());
        }
    }
}
