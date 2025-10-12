namespace Book_Shop_Management_System
{
    partial class owner_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_dashboard));
            this.pnl_owner_main = new System.Windows.Forms.Panel();
            this.pnl_owner_up = new System.Windows.Forms.Panel();
            this.btncross = new System.Windows.Forms.Button();
            this.pnl_owner_side = new System.Windows.Forms.Panel();
            this.btn_purchase_history = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_author = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_own_approve = new System.Windows.Forms.Button();
            this.btn_search_employee = new System.Windows.Forms.Button();
            this.txt_owner_uname = new System.Windows.Forms.TextBox();
            this.lbl_owner_welcome = new System.Windows.Forms.Label();
            this.lbl_own_dash = new System.Windows.Forms.Label();
            this.btn_submitted_reports = new System.Windows.Forms.Button();
            this.pnl_owner_up.SuspendLayout();
            this.pnl_owner_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_owner_main
            // 
            this.pnl_owner_main.BackColor = System.Drawing.Color.Ivory;
            this.pnl_owner_main.Location = new System.Drawing.Point(300, 39);
            this.pnl_owner_main.Name = "pnl_owner_main";
            this.pnl_owner_main.Size = new System.Drawing.Size(702, 774);
            this.pnl_owner_main.TabIndex = 5;
            this.pnl_owner_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_owner_main_Paint_1);
            // 
            // pnl_owner_up
            // 
            this.pnl_owner_up.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_owner_up.Controls.Add(this.btncross);
            this.pnl_owner_up.Location = new System.Drawing.Point(1, 0);
            this.pnl_owner_up.Name = "pnl_owner_up";
            this.pnl_owner_up.Size = new System.Drawing.Size(1001, 39);
            this.pnl_owner_up.TabIndex = 3;
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
            // pnl_owner_side
            // 
            this.pnl_owner_side.BackColor = System.Drawing.Color.Linen;
            this.pnl_owner_side.Controls.Add(this.btn_submitted_reports);
            this.pnl_owner_side.Controls.Add(this.btn_purchase_history);
            this.pnl_owner_side.Controls.Add(this.button1);
            this.pnl_owner_side.Controls.Add(this.btn_author);
            this.pnl_owner_side.Controls.Add(this.btn_add_book);
            this.pnl_owner_side.Controls.Add(this.btn_own_approve);
            this.pnl_owner_side.Controls.Add(this.btn_search_employee);
            this.pnl_owner_side.Controls.Add(this.txt_owner_uname);
            this.pnl_owner_side.Controls.Add(this.lbl_owner_welcome);
            this.pnl_owner_side.Controls.Add(this.lbl_own_dash);
            this.pnl_owner_side.Location = new System.Drawing.Point(1, 36);
            this.pnl_owner_side.Name = "pnl_owner_side";
            this.pnl_owner_side.Size = new System.Drawing.Size(301, 780);
            this.pnl_owner_side.TabIndex = 4;
            this.pnl_owner_side.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_owner_side_Paint);
            // 
            // btn_purchase_history
            // 
            this.btn_purchase_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_purchase_history.Location = new System.Drawing.Point(123, 515);
            this.btn_purchase_history.Name = "btn_purchase_history";
            this.btn_purchase_history.Size = new System.Drawing.Size(170, 40);
            this.btn_purchase_history.TabIndex = 12;
            this.btn_purchase_history.Text = "Purchase History";
            this.btn_purchase_history.UseVisualStyleBackColor = false;
            this.btn_purchase_history.Click += new System.EventHandler(this.btn_purchase_history_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(123, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_author
            // 
            this.btn_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_author.Location = new System.Drawing.Point(123, 392);
            this.btn_author.Name = "btn_author";
            this.btn_author.Size = new System.Drawing.Size(170, 40);
            this.btn_author.TabIndex = 10;
            this.btn_author.Text = "Authors ";
            this.btn_author.UseVisualStyleBackColor = false;
            this.btn_author.Click += new System.EventHandler(this.btn_author_Click_1);
            // 
            // btn_add_book
            // 
            this.btn_add_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_add_book.Location = new System.Drawing.Point(123, 328);
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
            this.btn_own_approve.Location = new System.Drawing.Point(123, 267);
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
            this.btn_search_employee.Location = new System.Drawing.Point(123, 208);
            this.btn_search_employee.Name = "btn_search_employee";
            this.btn_search_employee.Size = new System.Drawing.Size(170, 40);
            this.btn_search_employee.TabIndex = 6;
            this.btn_search_employee.Text = "Employee Details";
            this.btn_search_employee.UseVisualStyleBackColor = false;
            this.btn_search_employee.Click += new System.EventHandler(this.btn_search_employee_Click);
            // 
            // txt_owner_uname
            // 
            this.txt_owner_uname.Location = new System.Drawing.Point(143, 151);
            this.txt_owner_uname.Name = "txt_owner_uname";
            this.txt_owner_uname.ReadOnly = true;
            this.txt_owner_uname.Size = new System.Drawing.Size(150, 32);
            this.txt_owner_uname.TabIndex = 4;
            this.txt_owner_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_owner_uname.TextChanged += new System.EventHandler(this.txt_d_uname_TextChanged);
            // 
            // lbl_owner_welcome
            // 
            this.lbl_owner_welcome.AutoSize = true;
            this.lbl_owner_welcome.Location = new System.Drawing.Point(3, 154);
            this.lbl_owner_welcome.Name = "lbl_owner_welcome";
            this.lbl_owner_welcome.Size = new System.Drawing.Size(138, 29);
            this.lbl_owner_welcome.TabIndex = 3;
            this.lbl_owner_welcome.Text = "Welcome Owner : ";
            // 
            // lbl_own_dash
            // 
            this.lbl_own_dash.AutoSize = true;
            this.lbl_own_dash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_own_dash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_own_dash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_own_dash.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_own_dash.Location = new System.Drawing.Point(56, 67);
            this.lbl_own_dash.Name = "lbl_own_dash";
            this.lbl_own_dash.Size = new System.Drawing.Size(227, 47);
            this.lbl_own_dash.TabIndex = 2;
            this.lbl_own_dash.Text = "Owner Dashboard";
            this.lbl_own_dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_submitted_reports
            // 
            this.btn_submitted_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_submitted_reports.Location = new System.Drawing.Point(123, 571);
            this.btn_submitted_reports.Name = "btn_submitted_reports";
            this.btn_submitted_reports.Size = new System.Drawing.Size(170, 40);
            this.btn_submitted_reports.TabIndex = 13;
            this.btn_submitted_reports.Text = "Submitted Reports";
            this.btn_submitted_reports.UseVisualStyleBackColor = false;
            this.btn_submitted_reports.Click += new System.EventHandler(this.btn_submitted_reports_Click);
            // 
            // owner_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 756);
            this.Controls.Add(this.pnl_owner_main);
            this.Controls.Add(this.pnl_owner_up);
            this.Controls.Add(this.pnl_owner_side);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "owner_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.owner_dashboard_Load);
            this.pnl_owner_up.ResumeLayout(false);
            this.pnl_owner_side.ResumeLayout(false);
            this.pnl_owner_side.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_owner_main;
        private System.Windows.Forms.Panel pnl_owner_up;
        private System.Windows.Forms.Button btncross;
        private System.Windows.Forms.Panel pnl_owner_side;
        private System.Windows.Forms.Button btn_search_employee;
        private System.Windows.Forms.TextBox txt_owner_uname;
        private System.Windows.Forms.Label lbl_owner_welcome;
        private System.Windows.Forms.Label lbl_own_dash;
        private System.Windows.Forms.Button btn_own_approve;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_author;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_purchase_history;
        private System.Windows.Forms.Button btn_submitted_reports;
    }
}