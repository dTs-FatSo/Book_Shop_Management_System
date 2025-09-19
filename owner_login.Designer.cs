namespace Book_Shop_Management_System
{
    partial class owner_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_login));
            this.lbl_own_name = new System.Windows.Forms.Label();
            this.lblupass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.txt_own_pass = new System.Windows.Forms.TextBox();
            this.txt_own_name = new System.Windows.Forms.TextBox();
            this.btn_owner_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_own_name
            // 
            this.lbl_own_name.AutoSize = true;
            this.lbl_own_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_own_name.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_own_name.Location = new System.Drawing.Point(38, 74);
            this.lbl_own_name.Name = "lbl_own_name";
            this.lbl_own_name.Size = new System.Drawing.Size(107, 31);
            this.lbl_own_name.TabIndex = 18;
            this.lbl_own_name.Text = "Owner Name";
            // 
            // lblupass
            // 
            this.lblupass.AutoSize = true;
            this.lblupass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblupass.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupass.Location = new System.Drawing.Point(64, 166);
            this.lblupass.Name = "lblupass";
            this.lblupass.Size = new System.Drawing.Size(81, 31);
            this.lblupass.TabIndex = 17;
            this.lblupass.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(86, 240);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(89, 44);
            this.btnlogin.TabIndex = 16;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblerrorpass
            // 
            this.lblerrorpass.AutoSize = true;
            this.lblerrorpass.BackColor = System.Drawing.Color.White;
            this.lblerrorpass.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpass.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpass.Location = new System.Drawing.Point(176, 207);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(0, 29);
            this.lblerrorpass.TabIndex = 15;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.White;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(175, 118);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 29);
            this.lblerror.TabIndex = 14;
            this.lblerror.Click += new System.EventHandler(this.lblerror_Click);
            // 
            // txt_own_pass
            // 
            this.txt_own_pass.Location = new System.Drawing.Point(170, 166);
            this.txt_own_pass.Name = "txt_own_pass";
            this.txt_own_pass.PasswordChar = '*';
            this.txt_own_pass.Size = new System.Drawing.Size(157, 32);
            this.txt_own_pass.TabIndex = 13;
            // 
            // txt_own_name
            // 
            this.txt_own_name.Location = new System.Drawing.Point(170, 74);
            this.txt_own_name.Name = "txt_own_name";
            this.txt_own_name.Size = new System.Drawing.Size(157, 32);
            this.txt_own_name.TabIndex = 12;
            this.txt_own_name.TextChanged += new System.EventHandler(this.txt_own_name_TextChanged);
            // 
            // btn_owner_logout
            // 
            this.btn_owner_logout.BackColor = System.Drawing.Color.Red;
            this.btn_owner_logout.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_owner_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_owner_logout.Location = new System.Drawing.Point(204, 240);
            this.btn_owner_logout.Name = "btn_owner_logout";
            this.btn_owner_logout.Size = new System.Drawing.Size(89, 44);
            this.btn_owner_logout.TabIndex = 19;
            this.btn_owner_logout.Text = "Logout";
            this.btn_owner_logout.UseVisualStyleBackColor = false;
            this.btn_owner_logout.Click += new System.EventHandler(this.btn_owner_logout_Click);
            // 
            // owner_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(378, 371);
            this.Controls.Add(this.btn_owner_logout);
            this.Controls.Add(this.lbl_own_name);
            this.Controls.Add(this.lblupass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblerrorpass);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txt_own_pass);
            this.Controls.Add(this.txt_own_name);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "owner_login";
            this.Text = "Owner Login";
            this.Load += new System.EventHandler(this.owner_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_own_name;
        private System.Windows.Forms.Label lblupass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblerrorpass;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txt_own_pass;
        private System.Windows.Forms.TextBox txt_own_name;
        private System.Windows.Forms.Button btn_owner_logout;
    }
}