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
    public partial class owner_dashboard : Form
    {
        public owner_dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.pnl_owner_main.Controls.Count > 0)
                this.pnl_owner_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_owner_main.Controls.Add(f);
            this.pnl_owner_main.Tag = f;
            f.Show();
        }

        private void owner_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void txt_d_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncross_Click(object sender, EventArgs e)
        {
            this.Hide();
            owner_login o1 = new owner_login(); 
            o1.Show();
        }

        private void btn_own_approve_Click(object sender, EventArgs e)
        {
            loadform(new owner_approve());
        }

        private void pnl_owner_side_Paint(object sender, PaintEventArgs e)
        {

        }
        public void pnl_owner_main_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
