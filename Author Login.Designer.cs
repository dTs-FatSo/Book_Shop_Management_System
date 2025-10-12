namespace Book_Shop_Management_System
{
    partial class Author_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author_Login));
            this.btn_authr_logout = new System.Windows.Forms.Button();
            this.lbl_author_name = new System.Windows.Forms.Label();
            this.lbl_author_pass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.txt_author_pass = new System.Windows.Forms.TextBox();
            this.txt_author_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_authr_logout
            // 
            this.btn_authr_logout.BackColor = System.Drawing.Color.Red;
            this.btn_authr_logout.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_authr_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_authr_logout.Location = new System.Drawing.Point(219, 350);
            this.btn_authr_logout.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.btn_authr_logout.Name = "btn_authr_logout";
            this.btn_authr_logout.Size = new System.Drawing.Size(93, 47);
            this.btn_authr_logout.TabIndex = 35;
            this.btn_authr_logout.Text = "Logout";
            this.btn_authr_logout.UseVisualStyleBackColor = false;
            this.btn_authr_logout.Click += new System.EventHandler(this.btn_authr_logout_Click);
            // 
            // lbl_author_name
            // 
            this.lbl_author_name.AutoSize = true;
            this.lbl_author_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_author_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_author_name.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author_name.Location = new System.Drawing.Point(66, 146);
            this.lbl_author_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_author_name.Name = "lbl_author_name";
            this.lbl_author_name.Size = new System.Drawing.Size(110, 31);
            this.lbl_author_name.TabIndex = 34;
            this.lbl_author_name.Text = "Author Name";
            // 
            // lbl_author_pass
            // 
            this.lbl_author_pass.AutoSize = true;
            this.lbl_author_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_author_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_author_pass.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author_pass.Location = new System.Drawing.Point(95, 260);
            this.lbl_author_pass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_author_pass.Name = "lbl_author_pass";
            this.lbl_author_pass.Size = new System.Drawing.Size(81, 31);
            this.lbl_author_pass.TabIndex = 33;
            this.lbl_author_pass.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(95, 350);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(81, 47);
            this.btnlogin.TabIndex = 32;
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
            this.lblerrorpass.Location = new System.Drawing.Point(214, 306);
            this.lblerrorpass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(0, 29);
            this.lblerrorpass.TabIndex = 31;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.White;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(214, 197);
            this.lblerror.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 29);
            this.lblerror.TabIndex = 30;
            // 
            // txt_author_pass
            // 
            this.txt_author_pass.Location = new System.Drawing.Point(219, 255);
            this.txt_author_pass.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.txt_author_pass.Name = "txt_author_pass";
            this.txt_author_pass.PasswordChar = '*';
            this.txt_author_pass.Size = new System.Drawing.Size(243, 32);
            this.txt_author_pass.TabIndex = 29;
            // 
            // txt_author_name
            // 
            this.txt_author_name.Location = new System.Drawing.Point(219, 143);
            this.txt_author_name.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.txt_author_name.Name = "txt_author_name";
            this.txt_author_name.Size = new System.Drawing.Size(243, 32);
            this.txt_author_name.TabIndex = 28;
            // 
            // Author_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.register_background;
            this.ClientSize = new System.Drawing.Size(508, 470);
            this.Controls.Add(this.btn_authr_logout);
            this.Controls.Add(this.lbl_author_name);
            this.Controls.Add(this.lbl_author_pass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblerrorpass);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txt_author_pass);
            this.Controls.Add(this.txt_author_name);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Author_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_authr_logout;
        private System.Windows.Forms.Label lbl_author_name;
        private System.Windows.Forms.Label lbl_author_pass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblerrorpass;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txt_author_pass;
        private System.Windows.Forms.TextBox txt_author_name;
    }
}