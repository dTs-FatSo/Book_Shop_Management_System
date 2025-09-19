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
            this.btn_own_approve = new System.Windows.Forms.Button();
            this.btn_search_employee = new System.Windows.Forms.Button();
            this.txt_owner_uname = new System.Windows.Forms.TextBox();
            this.lbl_owner_welcome = new System.Windows.Forms.Label();
            this.lbl_own_dash = new System.Windows.Forms.Label();
            this.pnl_owner_up.SuspendLayout();
            this.pnl_owner_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_owner_main
            // 
            this.pnl_owner_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_owner_main.Location = new System.Drawing.Point(300, 39);
            this.pnl_owner_main.Name = "pnl_owner_main";
            this.pnl_owner_main.Size = new System.Drawing.Size(702, 774);
            this.pnl_owner_main.TabIndex = 5;
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
            this.pnl_owner_side.BackColor = System.Drawing.Color.Gainsboro;
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
            // btn_own_approve
            // 
            this.btn_own_approve.Location = new System.Drawing.Point(123, 273);
            this.btn_own_approve.Name = "btn_own_approve";
            this.btn_own_approve.Size = new System.Drawing.Size(170, 40);
            this.btn_own_approve.TabIndex = 7;
            this.btn_own_approve.Text = "Approve Order";
            this.btn_own_approve.UseVisualStyleBackColor = true;
            this.btn_own_approve.Click += new System.EventHandler(this.btn_own_approve_Click);
            // 
            // btn_search_employee
            // 
            this.btn_search_employee.Location = new System.Drawing.Point(123, 208);
            this.btn_search_employee.Name = "btn_search_employee";
            this.btn_search_employee.Size = new System.Drawing.Size(170, 40);
            this.btn_search_employee.TabIndex = 6;
            this.btn_search_employee.Text = "Search Employee";
            this.btn_search_employee.UseVisualStyleBackColor = true;
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
            // owner_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 816);
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
    }
}