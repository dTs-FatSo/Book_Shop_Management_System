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
    public partial class Author_Dashboard : Form
    {
        public Author_Dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.pnl_author_main.Controls.Count > 0)
                this.pnl_author_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_author_main.Controls.Add(f);
            this.pnl_author_main.Tag = f;
            f.Show();
        }
        public void RefreshAuthorName()
        {
            txt_author_name.Text = Session.CurrentAuthorName;
        }

        private void Author_Dashboard_Load(object sender, EventArgs e)
        {
            txt_author_name.Text = Session.CurrentAuthorName;
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            this.Close();
            Author_Login l1 = new Author_Login();
            l1.Show();
        }

        private void btn_authr_profile_Click(object sender, EventArgs e)
        {
            loadform(new Author_update());
        }

        private void pnl_author_side_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_own_approve_Click(object sender, EventArgs e)
        {
            loadform(new Search_Books());
        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            loadform(new Book());
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            loadform(new Report_Solving("Author"));
        }

        private void btn_sold_bks_Click(object sender, EventArgs e)
        {
            loadform(new Sells());
        }

        private void btn_purchase_history_Click(object sender, EventArgs e)
        {

        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            loadform(new AuthorStats());
        }
    }
}
