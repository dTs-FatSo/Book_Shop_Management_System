namespace Book_Shop_Management_System
{
    partial class user_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_dashboard));
            this.pnl_user_up = new System.Windows.Forms.Panel();
            this.btncross = new System.Windows.Forms.Button();
            this.pnl_user_side = new System.Windows.Forms.Panel();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.btn_search_book = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txt_d_uname = new System.Windows.Forms.TextBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbl_u_dash = new System.Windows.Forms.Label();
            this.pnl_user_main = new System.Windows.Forms.Panel();
            this.pnl_user_up.SuspendLayout();
            this.pnl_user_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_user_up
            // 
            this.pnl_user_up.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_user_up.Controls.Add(this.btncross);
            this.pnl_user_up.Location = new System.Drawing.Point(0, 1);
            this.pnl_user_up.Name = "pnl_user_up";
            this.pnl_user_up.Size = new System.Drawing.Size(952, 39);
            this.pnl_user_up.TabIndex = 0;
            this.pnl_user_up.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_user_up_Paint);
            // 
            // btncross
            // 
            this.btncross.Location = new System.Drawing.Point(862, 0);
            this.btncross.Name = "btncross";
            this.btncross.Size = new System.Drawing.Size(90, 36);
            this.btncross.TabIndex = 0;
            this.btncross.Text = "Log out";
            this.btncross.UseVisualStyleBackColor = true;
            this.btncross.Click += new System.EventHandler(this.btncross_Click);
            // 
            // pnl_user_side
            // 
            this.pnl_user_side.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl_user_side.Controls.Add(this.btn_receipt);
            this.pnl_user_side.Controls.Add(this.btn_search_book);
            this.pnl_user_side.Controls.Add(this.btnedit);
            this.pnl_user_side.Controls.Add(this.txt_d_uname);
            this.pnl_user_side.Controls.Add(this.lblwelcome);
            this.pnl_user_side.Controls.Add(this.lbl_u_dash);
            this.pnl_user_side.Location = new System.Drawing.Point(0, 1);
            this.pnl_user_side.Name = "pnl_user_side";
            this.pnl_user_side.Size = new System.Drawing.Size(301, 698);
            this.pnl_user_side.TabIndex = 1;
            this.pnl_user_side.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_user_side_Paint);
            // 
            // btn_receipt
            // 
            this.btn_receipt.Location = new System.Drawing.Point(76, 373);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(170, 40);
            this.btn_receipt.TabIndex = 7;
            this.btn_receipt.Text = "Print Receipt";
            this.btn_receipt.UseVisualStyleBackColor = true;
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // btn_search_book
            // 
            this.btn_search_book.Location = new System.Drawing.Point(76, 311);
            this.btn_search_book.Name = "btn_search_book";
            this.btn_search_book.Size = new System.Drawing.Size(170, 40);
            this.btn_search_book.TabIndex = 6;
            this.btn_search_book.Text = "Search Books";
            this.btn_search_book.UseVisualStyleBackColor = true;
            this.btn_search_book.Click += new System.EventHandler(this.btn_search_book_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(76, 250);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(170, 40);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit your profile";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txt_d_uname
            // 
            this.txt_d_uname.Location = new System.Drawing.Point(123, 151);
            this.txt_d_uname.Name = "txt_d_uname";
            this.txt_d_uname.ReadOnly = true;
            this.txt_d_uname.Size = new System.Drawing.Size(170, 32);
            this.txt_d_uname.TabIndex = 4;
            this.txt_d_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_d_uname.TextChanged += new System.EventHandler(this.txtuname_TextChanged);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Location = new System.Drawing.Point(3, 154);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(122, 29);
            this.lblwelcome.TabIndex = 3;
            this.lblwelcome.Text = "Welcome User : ";
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // lbl_u_dash
            // 
            this.lbl_u_dash.AutoSize = true;
            this.lbl_u_dash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_u_dash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_u_dash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_u_dash.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_u_dash.Location = new System.Drawing.Point(56, 67);
            this.lbl_u_dash.Name = "lbl_u_dash";
            this.lbl_u_dash.Size = new System.Drawing.Size(201, 47);
            this.lbl_u_dash.TabIndex = 2;
            this.lbl_u_dash.Text = "User Dashboard";
            this.lbl_u_dash.Click += new System.EventHandler(this.lbl_u_dash_Click);
            // 
            // pnl_user_main
            // 
            this.pnl_user_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_user_main.Location = new System.Drawing.Point(300, 40);
            this.pnl_user_main.Name = "pnl_user_main";
            this.pnl_user_main.Size = new System.Drawing.Size(653, 663);
            this.pnl_user_main.TabIndex = 2;
            this.pnl_user_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_user_main_Paint);
            // 
            // user_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(953, 655);
            this.Controls.Add(this.pnl_user_main);
            this.Controls.Add(this.pnl_user_up);
            this.Controls.Add(this.pnl_user_side);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "user_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.user_dashboard_Load);
            this.pnl_user_up.ResumeLayout(false);
            this.pnl_user_side.ResumeLayout(false);
            this.pnl_user_side.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_user_up;
        private System.Windows.Forms.Panel pnl_user_side;
        private System.Windows.Forms.Label lbl_u_dash;
        private System.Windows.Forms.Panel pnl_user_main;
        private System.Windows.Forms.TextBox txt_d_uname;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btncross;
        private System.Windows.Forms.Button btn_search_book;
        private System.Windows.Forms.Button btn_receipt;
    }
}