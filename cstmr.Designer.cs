namespace Book_Shop_Management_System
{
    partial class cstmr
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
            this.dtp_p_dob_user = new System.Windows.Forms.DateTimePicker();
            this.txt_p_phone = new System.Windows.Forms.TextBox();
            this.txt_p_email = new System.Windows.Forms.TextBox();
            this.txt_p_upass = new System.Windows.Forms.TextBox();
            this.txt_p_uname = new System.Windows.Forms.TextBox();
            this.lbl_p_phone = new System.Windows.Forms.Label();
            this.lbl_p_dob = new System.Windows.Forms.Label();
            this.lbl_p_email = new System.Windows.Forms.Label();
            this.lbl_p_upass = new System.Windows.Forms.Label();
            this.lbl_p_uname = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_p_dob_user
            // 
            this.dtp_p_dob_user.Location = new System.Drawing.Point(215, 251);
            this.dtp_p_dob_user.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtp_p_dob_user.Name = "dtp_p_dob_user";
            this.dtp_p_dob_user.Size = new System.Drawing.Size(373, 32);
            this.dtp_p_dob_user.TabIndex = 27;
            // 
            // txt_p_phone
            // 
            this.txt_p_phone.Location = new System.Drawing.Point(215, 316);
            this.txt_p_phone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_p_phone.Name = "txt_p_phone";
            this.txt_p_phone.Size = new System.Drawing.Size(373, 32);
            this.txt_p_phone.TabIndex = 26;
            // 
            // txt_p_email
            // 
            this.txt_p_email.Location = new System.Drawing.Point(215, 180);
            this.txt_p_email.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_p_email.Name = "txt_p_email";
            this.txt_p_email.Size = new System.Drawing.Size(373, 32);
            this.txt_p_email.TabIndex = 25;
            // 
            // txt_p_upass
            // 
            this.txt_p_upass.Location = new System.Drawing.Point(215, 106);
            this.txt_p_upass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_p_upass.Name = "txt_p_upass";
            this.txt_p_upass.Size = new System.Drawing.Size(373, 32);
            this.txt_p_upass.TabIndex = 24;
            // 
            // txt_p_uname
            // 
            this.txt_p_uname.Location = new System.Drawing.Point(215, 33);
            this.txt_p_uname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_p_uname.Name = "txt_p_uname";
            this.txt_p_uname.ReadOnly = true;
            this.txt_p_uname.Size = new System.Drawing.Size(373, 32);
            this.txt_p_uname.TabIndex = 23;
            this.txt_p_uname.TextChanged += new System.EventHandler(this.txt_p_uname_TextChanged);
            // 
            // lbl_p_phone
            // 
            this.lbl_p_phone.AutoSize = true;
            this.lbl_p_phone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_p_phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_p_phone.Location = new System.Drawing.Point(98, 319);
            this.lbl_p_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_phone.Name = "lbl_p_phone";
            this.lbl_p_phone.Size = new System.Drawing.Size(88, 31);
            this.lbl_p_phone.TabIndex = 21;
            this.lbl_p_phone.Text = "Phone No:";
            // 
            // lbl_p_dob
            // 
            this.lbl_p_dob.AutoSize = true;
            this.lbl_p_dob.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_p_dob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_p_dob.Location = new System.Drawing.Point(76, 251);
            this.lbl_p_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_dob.Name = "lbl_p_dob";
            this.lbl_p_dob.Size = new System.Drawing.Size(110, 31);
            this.lbl_p_dob.TabIndex = 20;
            this.lbl_p_dob.Text = "Date of Birth :";
            // 
            // lbl_p_email
            // 
            this.lbl_p_email.AutoSize = true;
            this.lbl_p_email.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_p_email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_p_email.Location = new System.Drawing.Point(122, 181);
            this.lbl_p_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_email.Name = "lbl_p_email";
            this.lbl_p_email.Size = new System.Drawing.Size(64, 31);
            this.lbl_p_email.TabIndex = 19;
            this.lbl_p_email.Text = "Email :";
            // 
            // lbl_p_upass
            // 
            this.lbl_p_upass.AutoSize = true;
            this.lbl_p_upass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_p_upass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_p_upass.Location = new System.Drawing.Point(95, 106);
            this.lbl_p_upass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_upass.Name = "lbl_p_upass";
            this.lbl_p_upass.Size = new System.Drawing.Size(91, 31);
            this.lbl_p_upass.TabIndex = 18;
            this.lbl_p_upass.Text = "Password : ";
            // 
            // lbl_p_uname
            // 
            this.lbl_p_uname.AutoSize = true;
            this.lbl_p_uname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_p_uname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_p_uname.Location = new System.Drawing.Point(85, 37);
            this.lbl_p_uname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_uname.Name = "lbl_p_uname";
            this.lbl_p_uname.Size = new System.Drawing.Size(101, 31);
            this.lbl_p_uname.TabIndex = 17;
            this.lbl_p_uname.Text = "User Name : ";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(235, 389);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 47);
            this.btnupdate.TabIndex = 32;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(375, 389);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 47);
            this.btnclose.TabIndex = 33;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cstmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(635, 616);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dtp_p_dob_user);
            this.Controls.Add(this.txt_p_phone);
            this.Controls.Add(this.txt_p_email);
            this.Controls.Add(this.txt_p_upass);
            this.Controls.Add(this.txt_p_uname);
            this.Controls.Add(this.lbl_p_phone);
            this.Controls.Add(this.lbl_p_dob);
            this.Controls.Add(this.lbl_p_email);
            this.Controls.Add(this.lbl_p_upass);
            this.Controls.Add(this.lbl_p_uname);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "cstmr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.cstmr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_p_dob_user;
        private System.Windows.Forms.TextBox txt_p_phone;
        private System.Windows.Forms.TextBox txt_p_email;
        private System.Windows.Forms.TextBox txt_p_upass;
        private System.Windows.Forms.TextBox txt_p_uname;
        private System.Windows.Forms.Label lbl_p_phone;
        private System.Windows.Forms.Label lbl_p_dob;
        private System.Windows.Forms.Label lbl_p_email;
        private System.Windows.Forms.Label lbl_p_upass;
        private System.Windows.Forms.Label lbl_p_uname;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclose;
    }
}