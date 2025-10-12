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
    public partial class Employee_Dashboard : Form
    {
        public Employee_Dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.pnl_emp_main.Controls.Count > 0)
                this.pnl_emp_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_emp_main.Controls.Add(f);
            this.pnl_emp_main.Tag = f;
            f.Show();
        }

        private void Employee_Dashboard_Load(object sender, EventArgs e)
        {
            txt_emp_name.Text = Session.CurrentEmployeename;
        }

        private void btn_own_approve_Click(object sender, EventArgs e)
        {
            loadform(new owner_approve());
        }

        private void btn_purchase_history_Click(object sender, EventArgs e)
        {
            loadform(new Purchase_History());
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Login l1 = new Employee_Login();
            l1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform (new update_cstmr());
        }

        private void btn_author_Click(object sender, EventArgs e)
        {
            loadform(new Author());
        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            loadform(new Book());
        }

        private void btn_search_employee_Click(object sender, EventArgs e)
        {
            loadform(new Employee_update());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Search_Books());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_sales_history_Click(object sender, EventArgs e)
        {
            loadform(new Sales_history());
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            loadform(new Report_Solving("Employee"));
        }
    }
}
