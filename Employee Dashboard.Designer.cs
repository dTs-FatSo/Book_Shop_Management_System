namespace Book_Shop_Management_System
{
    partial class Employee_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Dashboard));
            this.btn_purchase_history = new System.Windows.Forms.Button();
            this.pnl_emp_main = new System.Windows.Forms.Panel();
            this.pnl_emp_up = new System.Windows.Forms.Panel();
            this.btncross = new System.Windows.Forms.Button();
            this.pnl_emp_side = new System.Windows.Forms.Panel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_sales_history = new System.Windows.Forms.Button();
            this.btn_srch_bk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_author = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_own_approve = new System.Windows.Forms.Button();
            this.btn_search_employee = new System.Windows.Forms.Button();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.lbl_emp_welcome = new System.Windows.Forms.Label();
            this.lbl_own_dash = new System.Windows.Forms.Label();
            this.pnl_emp_up.SuspendLayout();
            this.pnl_emp_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_purchase_history
            // 
            this.btn_purchase_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_purchase_history.Location = new System.Drawing.Point(123, 467);
            this.btn_purchase_history.Name = "btn_purchase_history";
            this.btn_purchase_history.Size = new System.Drawing.Size(170, 40);
            this.btn_purchase_history.TabIndex = 12;
            this.btn_purchase_history.Text = "Purchase History";
            this.btn_purchase_history.UseVisualStyleBackColor = false;
            this.btn_purchase_history.Click += new System.EventHandler(this.btn_purchase_history_Click);
            // 
            // pnl_emp_main
            // 
            this.pnl_emp_main.BackColor = System.Drawing.Color.Ivory;
            this.pnl_emp_main.Location = new System.Drawing.Point(299, 39);
            this.pnl_emp_main.Name = "pnl_emp_main";
            this.pnl_emp_main.Size = new System.Drawing.Size(702, 774);
            this.pnl_emp_main.TabIndex = 8;
            // 
            // pnl_emp_up
            // 
            this.pnl_emp_up.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_emp_up.Controls.Add(this.btncross);
            this.pnl_emp_up.Location = new System.Drawing.Point(0, 0);
            this.pnl_emp_up.Name = "pnl_emp_up";
            this.pnl_emp_up.Size = new System.Drawing.Size(1001, 39);
            this.pnl_emp_up.TabIndex = 6;
            // 
            // btncross
            // 
            this.btncross.Location = new System.Drawing.Point(907, 2);
            this.btncross.Name = "btncross";
            this.btncross.Size = new System.Drawing.Size(90, 36);
            this.btncross.TabIndex = 0;
            this.btncross.Text = "Log out";
            this.btncross.UseVisualStyleBackColor = true;
            this.btncross.Click += new System.EventHandler(this.btncross_Click);
            // 
            // pnl_emp_side
            // 
            this.pnl_emp_side.BackColor = System.Drawing.Color.Linen;
            this.pnl_emp_side.Controls.Add(this.btn_reports);
            this.pnl_emp_side.Controls.Add(this.btn_sales_history);
            this.pnl_emp_side.Controls.Add(this.btn_srch_bk);
            this.pnl_emp_side.Controls.Add(this.btn_purchase_history);
            this.pnl_emp_side.Controls.Add(this.button1);
            this.pnl_emp_side.Controls.Add(this.btn_author);
            this.pnl_emp_side.Controls.Add(this.btn_add_book);
            this.pnl_emp_side.Controls.Add(this.btn_own_approve);
            this.pnl_emp_side.Controls.Add(this.btn_search_employee);
            this.pnl_emp_side.Controls.Add(this.txt_emp_name);
            this.pnl_emp_side.Controls.Add(this.lbl_emp_welcome);
            this.pnl_emp_side.Controls.Add(this.lbl_own_dash);
            this.pnl_emp_side.Location = new System.Drawing.Point(0, 36);
            this.pnl_emp_side.Name = "pnl_emp_side";
            this.pnl_emp_side.Size = new System.Drawing.Size(301, 780);
            this.pnl_emp_side.TabIndex = 7;
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_reports.Location = new System.Drawing.Point(123, 639);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(170, 40);
            this.btn_reports.TabIndex = 15;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_sales_history
            // 
            this.btn_sales_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sales_history.Location = new System.Drawing.Point(123, 585);
            this.btn_sales_history.Name = "btn_sales_history";
            this.btn_sales_history.Size = new System.Drawing.Size(170, 40);
            this.btn_sales_history.TabIndex = 14;
            this.btn_sales_history.Text = "Sales History";
            this.btn_sales_history.UseVisualStyleBackColor = false;
            this.btn_sales_history.Click += new System.EventHandler(this.btn_sales_history_Click);
            // 
            // btn_srch_bk
            // 
            this.btn_srch_bk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_srch_bk.Location = new System.Drawing.Point(123, 527);
            this.btn_srch_bk.Name = "btn_srch_bk";
            this.btn_srch_bk.Size = new System.Drawing.Size(170, 40);
            this.btn_srch_bk.TabIndex = 13;
            this.btn_srch_bk.Text = "Search Books";
            this.btn_srch_bk.UseVisualStyleBackColor = false;
            this.btn_srch_bk.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(123, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_author
            // 
            this.btn_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_author.Location = new System.Drawing.Point(123, 344);
            this.btn_author.Name = "btn_author";
            this.btn_author.Size = new System.Drawing.Size(170, 40);
            this.btn_author.TabIndex = 10;
            this.btn_author.Text = "Authors ";
            this.btn_author.UseVisualStyleBackColor = false;
            this.btn_author.Click += new System.EventHandler(this.btn_author_Click);
            // 
            // btn_add_book
            // 
            this.btn_add_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_add_book.Location = new System.Drawing.Point(123, 284);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(170, 40);
            this.btn_add_book.TabIndex = 8;
            this.btn_add_book.Text = "Add Books";
            this.btn_add_book.UseVisualStyleBackColor = false;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_own_approve
            // 
            this.btn_own_approve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_own_approve.Location = new System.Drawing.Point(123, 221);
            this.btn_own_approve.Name = "btn_own_approve";
            this.btn_own_approve.Size = new System.Drawing.Size(170, 40);
            this.btn_own_approve.TabIndex = 7;
            this.btn_own_approve.Text = "Approve Order";
            this.btn_own_approve.UseVisualStyleBackColor = false;
            this.btn_own_approve.Click += new System.EventHandler(this.btn_own_approve_Click);
            // 
            // btn_search_employee
            // 
            this.btn_search_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_search_employee.Location = new System.Drawing.Point(123, 162);
            this.btn_search_employee.Name = "btn_search_employee";
            this.btn_search_employee.Size = new System.Drawing.Size(170, 40);
            this.btn_search_employee.TabIndex = 6;
            this.btn_search_employee.Text = "Employee Details";
            this.btn_search_employee.UseVisualStyleBackColor = false;
            this.btn_search_employee.Click += new System.EventHandler(this.btn_search_employee_Click);
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Location = new System.Drawing.Point(143, 113);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.ReadOnly = true;
            this.txt_emp_name.Size = new System.Drawing.Size(150, 32);
            this.txt_emp_name.TabIndex = 4;
            this.txt_emp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_emp_welcome
            // 
            this.lbl_emp_welcome.AutoSize = true;
            this.lbl_emp_welcome.Location = new System.Drawing.Point(3, 81);
            this.lbl_emp_welcome.Name = "lbl_emp_welcome";
            this.lbl_emp_welcome.Size = new System.Drawing.Size(161, 29);
            this.lbl_emp_welcome.TabIndex = 3;
            this.lbl_emp_welcome.Text = "Welcome Employee : ";
            // 
            // lbl_own_dash
            // 
            this.lbl_own_dash.AutoSize = true;
            this.lbl_own_dash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_own_dash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_own_dash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_own_dash.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_own_dash.Location = new System.Drawing.Point(24, 21);
            this.lbl_own_dash.Name = "lbl_own_dash";
            this.lbl_own_dash.Size = new System.Drawing.Size(262, 47);
            this.lbl_own_dash.TabIndex = 2;
            this.lbl_own_dash.Text = "Employee Dashboard";
            this.lbl_own_dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 816);
            this.Controls.Add(this.pnl_emp_main);
            this.Controls.Add(this.pnl_emp_up);
            this.Controls.Add(this.pnl_emp_side);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Dashboard";
            this.Load += new System.EventHandler(this.Employee_Dashboard_Load);
            this.pnl_emp_up.ResumeLayout(false);
            this.pnl_emp_side.ResumeLayout(false);
            this.pnl_emp_side.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_purchase_history;
        private System.Windows.Forms.Panel pnl_emp_main;
        private System.Windows.Forms.Panel pnl_emp_up;
        private System.Windows.Forms.Button btncross;
        private System.Windows.Forms.Panel pnl_emp_side;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_author;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_own_approve;
        private System.Windows.Forms.Button btn_search_employee;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.Label lbl_emp_welcome;
        private System.Windows.Forms.Label lbl_own_dash;
        private System.Windows.Forms.Button btn_srch_bk;
        private System.Windows.Forms.Button btn_sales_history;
        private System.Windows.Forms.Button btn_reports;
    }
}