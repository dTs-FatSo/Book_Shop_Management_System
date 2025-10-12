namespace Book_Shop_Management_System
{
    partial class Author_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author_Dashboard));
            this.pnl_author_main = new System.Windows.Forms.Panel();
            this.pnl_emp_up = new System.Windows.Forms.Panel();
            this.btncross = new System.Windows.Forms.Button();
            this.pnl_author_side = new System.Windows.Forms.Panel();
            this.btn_sold_bks = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_author_search_bk = new System.Windows.Forms.Button();
            this.btn_authr_profile = new System.Windows.Forms.Button();
            this.txt_author_name = new System.Windows.Forms.TextBox();
            this.lbl_author_welcome = new System.Windows.Forms.Label();
            this.lbl_Author_dash = new System.Windows.Forms.Label();
            this.btn_stats = new System.Windows.Forms.Button();
            this.pnl_emp_up.SuspendLayout();
            this.pnl_author_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_author_main
            // 
            this.pnl_author_main.BackColor = System.Drawing.Color.Beige;
            this.pnl_author_main.Location = new System.Drawing.Point(299, 39);
            this.pnl_author_main.Name = "pnl_author_main";
            this.pnl_author_main.Size = new System.Drawing.Size(702, 774);
            this.pnl_author_main.TabIndex = 11;
            // 
            // pnl_emp_up
            // 
            this.pnl_emp_up.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_emp_up.Controls.Add(this.btncross);
            this.pnl_emp_up.Location = new System.Drawing.Point(0, 0);
            this.pnl_emp_up.Name = "pnl_emp_up";
            this.pnl_emp_up.Size = new System.Drawing.Size(1001, 39);
            this.pnl_emp_up.TabIndex = 9;
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
            // pnl_author_side
            // 
            this.pnl_author_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnl_author_side.Controls.Add(this.btn_stats);
            this.pnl_author_side.Controls.Add(this.btn_sold_bks);
            this.pnl_author_side.Controls.Add(this.btn_report);
            this.pnl_author_side.Controls.Add(this.btn_add_book);
            this.pnl_author_side.Controls.Add(this.btn_author_search_bk);
            this.pnl_author_side.Controls.Add(this.btn_authr_profile);
            this.pnl_author_side.Controls.Add(this.txt_author_name);
            this.pnl_author_side.Controls.Add(this.lbl_author_welcome);
            this.pnl_author_side.Controls.Add(this.lbl_Author_dash);
            this.pnl_author_side.Location = new System.Drawing.Point(0, 36);
            this.pnl_author_side.Name = "pnl_author_side";
            this.pnl_author_side.Size = new System.Drawing.Size(301, 780);
            this.pnl_author_side.TabIndex = 10;
            this.pnl_author_side.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_author_side_Paint);
            // 
            // btn_sold_bks
            // 
            this.btn_sold_bks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sold_bks.Location = new System.Drawing.Point(123, 405);
            this.btn_sold_bks.Name = "btn_sold_bks";
            this.btn_sold_bks.Size = new System.Drawing.Size(170, 40);
            this.btn_sold_bks.TabIndex = 11;
            this.btn_sold_bks.Text = "Sold Books";
            this.btn_sold_bks.UseVisualStyleBackColor = false;
            this.btn_sold_bks.Click += new System.EventHandler(this.btn_sold_bks_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_report.Location = new System.Drawing.Point(123, 344);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(170, 40);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "Reports";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
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
            // btn_author_search_bk
            // 
            this.btn_author_search_bk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_author_search_bk.Location = new System.Drawing.Point(123, 221);
            this.btn_author_search_bk.Name = "btn_author_search_bk";
            this.btn_author_search_bk.Size = new System.Drawing.Size(170, 40);
            this.btn_author_search_bk.TabIndex = 7;
            this.btn_author_search_bk.Text = "Search Books";
            this.btn_author_search_bk.UseVisualStyleBackColor = false;
            this.btn_author_search_bk.Click += new System.EventHandler(this.btn_own_approve_Click);
            // 
            // btn_authr_profile
            // 
            this.btn_authr_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_authr_profile.Location = new System.Drawing.Point(123, 162);
            this.btn_authr_profile.Name = "btn_authr_profile";
            this.btn_authr_profile.Size = new System.Drawing.Size(170, 40);
            this.btn_authr_profile.TabIndex = 6;
            this.btn_authr_profile.Text = "Profile";
            this.btn_authr_profile.UseVisualStyleBackColor = false;
            this.btn_authr_profile.Click += new System.EventHandler(this.btn_authr_profile_Click);
            // 
            // txt_author_name
            // 
            this.txt_author_name.Location = new System.Drawing.Point(143, 113);
            this.txt_author_name.Name = "txt_author_name";
            this.txt_author_name.ReadOnly = true;
            this.txt_author_name.Size = new System.Drawing.Size(150, 32);
            this.txt_author_name.TabIndex = 4;
            this.txt_author_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_author_welcome
            // 
            this.lbl_author_welcome.AutoSize = true;
            this.lbl_author_welcome.Location = new System.Drawing.Point(3, 81);
            this.lbl_author_welcome.Name = "lbl_author_welcome";
            this.lbl_author_welcome.Size = new System.Drawing.Size(138, 29);
            this.lbl_author_welcome.TabIndex = 3;
            this.lbl_author_welcome.Text = "Welcome Author: ";
            // 
            // lbl_Author_dash
            // 
            this.lbl_Author_dash.AutoSize = true;
            this.lbl_Author_dash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Author_dash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Author_dash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Author_dash.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author_dash.Location = new System.Drawing.Point(37, 21);
            this.lbl_Author_dash.Name = "lbl_Author_dash";
            this.lbl_Author_dash.Size = new System.Drawing.Size(231, 47);
            this.lbl_Author_dash.TabIndex = 2;
            this.lbl_Author_dash.Text = "Author Dashboard";
            this.lbl_Author_dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stats.Location = new System.Drawing.Point(123, 465);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(170, 40);
            this.btn_stats.TabIndex = 12;
            this.btn_stats.Text = "Author Stats";
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // Author_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 816);
            this.Controls.Add(this.pnl_author_main);
            this.Controls.Add(this.pnl_emp_up);
            this.Controls.Add(this.pnl_author_side);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Author_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author_Dashboard";
            this.Load += new System.EventHandler(this.Author_Dashboard_Load);
            this.pnl_emp_up.ResumeLayout(false);
            this.pnl_author_side.ResumeLayout(false);
            this.pnl_author_side.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_author_main;
        private System.Windows.Forms.Panel pnl_emp_up;
        private System.Windows.Forms.Button btncross;
        private System.Windows.Forms.Panel pnl_author_side;
        private System.Windows.Forms.Button btn_sold_bks;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_author_search_bk;
        private System.Windows.Forms.Button btn_authr_profile;
        private System.Windows.Forms.TextBox txt_author_name;
        private System.Windows.Forms.Label lbl_author_welcome;
        private System.Windows.Forms.Label lbl_Author_dash;
        private System.Windows.Forms.Button btn_stats;
    }
}