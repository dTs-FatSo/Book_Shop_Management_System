namespace Book_Shop_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblloginname = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblupass = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtupass = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblnewuser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblloginname
            // 
            this.lblloginname.AutoSize = true;
            this.lblloginname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblloginname.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginname.Location = new System.Drawing.Point(104, 142);
            this.lblloginname.Name = "lblloginname";
            this.lblloginname.Size = new System.Drawing.Size(229, 47);
            this.lblloginname.TabIndex = 0;
            this.lblloginname.Text = "JIBS BOOK SHOP";
            this.lblloginname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(89, 255);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(91, 31);
            this.lbluname.TabIndex = 1;
            this.lbluname.Text = "User Name";
            this.lbluname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblupass
            // 
            this.lblupass.AutoSize = true;
            this.lblupass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblupass.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupass.Location = new System.Drawing.Point(89, 347);
            this.lblupass.Name = "lblupass";
            this.lblupass.Size = new System.Drawing.Size(81, 31);
            this.lblupass.TabIndex = 2;
            this.lblupass.Text = "Password";
            this.lblupass.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(195, 249);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(157, 37);
            this.txtUname.TabIndex = 3;
            this.txtUname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtupass
            // 
            this.txtupass.Location = new System.Drawing.Point(195, 341);
            this.txtupass.Name = "txtupass";
            this.txtupass.PasswordChar = '*';
            this.txtupass.Size = new System.Drawing.Size(157, 37);
            this.txtupass.TabIndex = 4;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.White;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(200, 299);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 29);
            this.lblerror.TabIndex = 5;
            this.lblerror.Click += new System.EventHandler(this.lblerror_Click);
            // 
            // lblerrorpass
            // 
            this.lblerrorpass.AutoSize = true;
            this.lblerrorpass.BackColor = System.Drawing.Color.White;
            this.lblerrorpass.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpass.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpass.Location = new System.Drawing.Point(201, 388);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(0, 29);
            this.lblerrorpass.TabIndex = 6;
            this.lblerrorpass.Click += new System.EventHandler(this.lblerrorpass_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(173, 454);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(89, 44);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblnewuser
            // 
            this.lblnewuser.AutoSize = true;
            this.lblnewuser.BackColor = System.Drawing.Color.White;
            this.lblnewuser.ForeColor = System.Drawing.Color.Red;
            this.lblnewuser.Location = new System.Drawing.Point(128, 519);
            this.lblnewuser.Name = "lblnewuser";
            this.lblnewuser.Size = new System.Drawing.Size(211, 34);
            this.lblnewuser.TabIndex = 8;
            this.lblnewuser.Text = "New user? Sign in Now.";
            this.lblnewuser.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.blue_black_minimalist_vintage_door_logo2;
            this.ClientSize = new System.Drawing.Size(632, 653);
            this.Controls.Add(this.lblnewuser);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblerrorpass);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txtupass);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblupass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.lblloginname);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloginname;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblupass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblerrorpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblnewuser;
    }
}

