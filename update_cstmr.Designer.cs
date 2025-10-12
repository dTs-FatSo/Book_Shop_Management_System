namespace Book_Shop_Management_System
{
    partial class update_cstmr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_cstmr));
            this.btn_add_new_cstmr = new System.Windows.Forms.Button();
            this.btn_add_cstmr = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_cstmr_name = new System.Windows.Forms.TextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_cstmr_name = new System.Windows.Forms.Label();
            this.dgv_cstmr_search = new System.Windows.Forms.DataGridView();
            this.btn_srch_cstmr = new System.Windows.Forms.Button();
            this.txt_search_cstmr = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.rdbother = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmr_search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_new_cstmr
            // 
            this.btn_add_new_cstmr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_new_cstmr.Location = new System.Drawing.Point(231, 241);
            this.btn_add_new_cstmr.Name = "btn_add_new_cstmr";
            this.btn_add_new_cstmr.Size = new System.Drawing.Size(204, 38);
            this.btn_add_new_cstmr.TabIndex = 32;
            this.btn_add_new_cstmr.Text = "Add New Customer";
            this.btn_add_new_cstmr.UseVisualStyleBackColor = false;
            this.btn_add_new_cstmr.Click += new System.EventHandler(this.btn_add_new_cstmr_Click);
            // 
            // btn_add_cstmr
            // 
            this.btn_add_cstmr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add_cstmr.Location = new System.Drawing.Point(376, 630);
            this.btn_add_cstmr.Name = "btn_add_cstmr";
            this.btn_add_cstmr.Size = new System.Drawing.Size(128, 38);
            this.btn_add_cstmr.TabIndex = 31;
            this.btn_add_cstmr.Text = "Add Customer";
            this.btn_add_cstmr.UseVisualStyleBackColor = false;
            this.btn_add_cstmr.Click += new System.EventHandler(this.btn_add_cstmr_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.Location = new System.Drawing.Point(530, 630);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 38);
            this.btn_delete.TabIndex = 30;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_close.Location = new System.Drawing.Point(264, 630);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 29;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(108, 630);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(85, 38);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dtp_dob
            // 
            this.dtp_dob.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_dob.Location = new System.Drawing.Point(264, 541);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(351, 32);
            this.dtp_dob.TabIndex = 25;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_phone.Location = new System.Drawing.Point(264, 350);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(351, 32);
            this.txt_phone.TabIndex = 24;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // txt_cstmr_name
            // 
            this.txt_cstmr_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_cstmr_name.Location = new System.Drawing.Point(264, 293);
            this.txt_cstmr_name.Name = "txt_cstmr_name";
            this.txt_cstmr_name.Size = new System.Drawing.Size(351, 32);
            this.txt_cstmr_name.TabIndex = 23;
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dob.Location = new System.Drawing.Point(54, 541);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(139, 31);
            this.lbl_dob.TabIndex = 20;
            this.lbl_dob.Text = "Date of Birthday : ";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_phone.Location = new System.Drawing.Point(54, 350);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(127, 31);
            this.lbl_phone.TabIndex = 19;
            this.lbl_phone.Text = "Phone Number :";
            // 
            // lbl_cstmr_name
            // 
            this.lbl_cstmr_name.AutoSize = true;
            this.lbl_cstmr_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cstmr_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cstmr_name.Location = new System.Drawing.Point(54, 293);
            this.lbl_cstmr_name.Name = "lbl_cstmr_name";
            this.lbl_cstmr_name.Size = new System.Drawing.Size(134, 31);
            this.lbl_cstmr_name.TabIndex = 18;
            this.lbl_cstmr_name.Text = "Customer Name: ";
            // 
            // dgv_cstmr_search
            // 
            this.dgv_cstmr_search.AllowUserToAddRows = false;
            this.dgv_cstmr_search.AllowUserToDeleteRows = false;
            this.dgv_cstmr_search.AllowUserToOrderColumns = true;
            this.dgv_cstmr_search.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_cstmr_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_cstmr_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cstmr_search.Location = new System.Drawing.Point(54, 82);
            this.dgv_cstmr_search.Name = "dgv_cstmr_search";
            this.dgv_cstmr_search.ReadOnly = true;
            this.dgv_cstmr_search.RowHeadersWidth = 51;
            this.dgv_cstmr_search.RowTemplate.Height = 24;
            this.dgv_cstmr_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cstmr_search.Size = new System.Drawing.Size(556, 150);
            this.dgv_cstmr_search.TabIndex = 35;
            this.dgv_cstmr_search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cstmr_search_CellClick);
            // 
            // btn_srch_cstmr
            // 
            this.btn_srch_cstmr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_srch_cstmr.Location = new System.Drawing.Point(519, 28);
            this.btn_srch_cstmr.Name = "btn_srch_cstmr";
            this.btn_srch_cstmr.Size = new System.Drawing.Size(91, 40);
            this.btn_srch_cstmr.TabIndex = 34;
            this.btn_srch_cstmr.Text = "Search";
            this.btn_srch_cstmr.UseVisualStyleBackColor = false;
            this.btn_srch_cstmr.Click += new System.EventHandler(this.btn_srch_cstmr_Click);
            // 
            // txt_search_cstmr
            // 
            this.txt_search_cstmr.Location = new System.Drawing.Point(54, 31);
            this.txt_search_cstmr.Name = "txt_search_cstmr";
            this.txt_search_cstmr.Size = new System.Drawing.Size(438, 32);
            this.txt_search_cstmr.TabIndex = 33;
            this.txt_search_cstmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_email.Location = new System.Drawing.Point(54, 397);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(64, 31);
            this.lbl_email.TabIndex = 36;
            this.lbl_email.Text = "Email :";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_email.Location = new System.Drawing.Point(264, 396);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(351, 32);
            this.txt_email.TabIndex = 37;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pass.Location = new System.Drawing.Point(54, 448);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(91, 31);
            this.lbl_pass.TabIndex = 38;
            this.lbl_pass.Text = "Password : ";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pass.Location = new System.Drawing.Point(264, 447);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(351, 32);
            this.txt_pass.TabIndex = 39;
            // 
            // rdbother
            // 
            this.rdbother.AutoSize = true;
            this.rdbother.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbother.Location = new System.Drawing.Point(540, 491);
            this.rdbother.Name = "rdbother";
            this.rdbother.Size = new System.Drawing.Size(74, 33);
            this.rdbother.TabIndex = 43;
            this.rdbother.TabStop = true;
            this.rdbother.Text = "Other";
            this.rdbother.UseVisualStyleBackColor = false;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbfemale.Location = new System.Drawing.Point(398, 491);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(84, 33);
            this.rdbfemale.TabIndex = 42;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = false;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbmale.Location = new System.Drawing.Point(264, 491);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(69, 33);
            this.rdbmale.TabIndex = 41;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = false;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblgender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblgender.Location = new System.Drawing.Point(54, 491);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(72, 31);
            this.lblgender.TabIndex = 40;
            this.lblgender.Text = "Gender :";
            // 
            // update_cstmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.rdbother);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.dgv_cstmr_search);
            this.Controls.Add(this.btn_srch_cstmr);
            this.Controls.Add(this.txt_search_cstmr);
            this.Controls.Add(this.btn_add_new_cstmr);
            this.Controls.Add(this.btn_add_cstmr);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_cstmr_name);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_cstmr_name);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "update_cstmr";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.update_cstmr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cstmr_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_new_cstmr;
        private System.Windows.Forms.Button btn_add_cstmr;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_cstmr_name;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_cstmr_name;
        private System.Windows.Forms.DataGridView dgv_cstmr_search;
        private System.Windows.Forms.Button btn_srch_cstmr;
        private System.Windows.Forms.TextBox txt_search_cstmr;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.RadioButton rdbother;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.Label lblgender;
    }
}