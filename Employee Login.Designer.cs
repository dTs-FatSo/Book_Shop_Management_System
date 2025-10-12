namespace Book_Shop_Management_System
{
    partial class Employee_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Login));
            this.btn_emp_logout = new System.Windows.Forms.Button();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.lblupass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.txt_emp_pass = new System.Windows.Forms.TextBox();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_emp_logout
            // 
            this.btn_emp_logout.BackColor = System.Drawing.Color.Red;
            this.btn_emp_logout.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_emp_logout.Location = new System.Drawing.Point(251, 375);
            this.btn_emp_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_emp_logout.Name = "btn_emp_logout";
            this.btn_emp_logout.Size = new System.Drawing.Size(96, 41);
            this.btn_emp_logout.TabIndex = 27;
            this.btn_emp_logout.Text = "Logout";
            this.btn_emp_logout.UseVisualStyleBackColor = false;
            this.btn_emp_logout.Click += new System.EventHandler(this.btn_emp_logout_Click);
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_emp_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_emp_name.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_name.Location = new System.Drawing.Point(56, 164);
            this.lbl_emp_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(130, 31);
            this.lbl_emp_name.TabIndex = 26;
            this.lbl_emp_name.Text = "Employee Name";
            // 
            // lblupass
            // 
            this.lblupass.AutoSize = true;
            this.lblupass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblupass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblupass.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupass.Location = new System.Drawing.Point(105, 265);
            this.lblupass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblupass.Name = "lblupass";
            this.lblupass.Size = new System.Drawing.Size(81, 31);
            this.lblupass.TabIndex = 25;
            this.lblupass.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(105, 375);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(81, 41);
            this.btnlogin.TabIndex = 24;
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
            this.lblerrorpass.Location = new System.Drawing.Point(220, 315);
            this.lblerrorpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(0, 29);
            this.lblerrorpass.TabIndex = 23;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.White;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(220, 208);
            this.lblerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 29);
            this.lblerror.TabIndex = 22;
            // 
            // txt_emp_pass
            // 
            this.txt_emp_pass.Location = new System.Drawing.Point(219, 262);
            this.txt_emp_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_emp_pass.Name = "txt_emp_pass";
            this.txt_emp_pass.PasswordChar = '*';
            this.txt_emp_pass.Size = new System.Drawing.Size(195, 32);
            this.txt_emp_pass.TabIndex = 21;
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Location = new System.Drawing.Point(219, 161);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(195, 32);
            this.txt_emp_name.TabIndex = 20;
            // 
            // Employee_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.register_background;
            this.ClientSize = new System.Drawing.Size(508, 470);
            this.Controls.Add(this.btn_emp_logout);
            this.Controls.Add(this.lbl_emp_name);
            this.Controls.Add(this.lblupass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblerrorpass);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txt_emp_pass);
            this.Controls.Add(this.txt_emp_name);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emp_logout;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.Label lblupass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblerrorpass;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txt_emp_pass;
        private System.Windows.Forms.TextBox txt_emp_name;
    }
}