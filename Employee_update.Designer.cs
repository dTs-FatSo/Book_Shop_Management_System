namespace Book_Shop_Management_System
{
    partial class Employee_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_update));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_e_pass = new System.Windows.Forms.TextBox();
            this.txt_e_name = new System.Windows.Forms.TextBox();
            this.lbl_e_pass = new System.Windows.Forms.Label();
            this.lbl_e_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_close.Location = new System.Drawing.Point(412, 307);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(273, 307);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(85, 38);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_e_pass
            // 
            this.txt_e_pass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_e_pass.Location = new System.Drawing.Point(273, 232);
            this.txt_e_pass.Name = "txt_e_pass";
            this.txt_e_pass.Size = new System.Drawing.Size(351, 32);
            this.txt_e_pass.TabIndex = 18;
            // 
            // txt_e_name
            // 
            this.txt_e_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_e_name.Location = new System.Drawing.Point(273, 173);
            this.txt_e_name.Name = "txt_e_name";
            this.txt_e_name.Size = new System.Drawing.Size(351, 32);
            this.txt_e_name.TabIndex = 17;
            // 
            // lbl_e_pass
            // 
            this.lbl_e_pass.AutoSize = true;
            this.lbl_e_pass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_e_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_e_pass.Location = new System.Drawing.Point(37, 233);
            this.lbl_e_pass.Name = "lbl_e_pass";
            this.lbl_e_pass.Size = new System.Drawing.Size(164, 31);
            this.lbl_e_pass.TabIndex = 16;
            this.lbl_e_pass.Text = "Employee Password : ";
            // 
            // lbl_e_name
            // 
            this.lbl_e_name.AutoSize = true;
            this.lbl_e_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_e_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_e_name.Location = new System.Drawing.Point(63, 173);
            this.lbl_e_name.Name = "lbl_e_name";
            this.lbl_e_name.Size = new System.Drawing.Size(137, 31);
            this.lbl_e_name.TabIndex = 15;
            this.lbl_e_name.Text = "Employee Name: ";
            // 
            // Employee_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.userprofile;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_e_pass);
            this.Controls.Add(this.txt_e_name);
            this.Controls.Add(this.lbl_e_pass);
            this.Controls.Add(this.lbl_e_name);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee_update";
            this.Text = "Employee_update";
            this.Load += new System.EventHandler(this.Employee_update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_e_pass;
        private System.Windows.Forms.TextBox txt_e_name;
        private System.Windows.Forms.Label lbl_e_pass;
        private System.Windows.Forms.Label lbl_e_name;
    }
}