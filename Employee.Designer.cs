namespace Book_Shop_Management_System
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.txt_search_employee = new System.Windows.Forms.TextBox();
            this.btn_srch_employee = new System.Windows.Forms.Button();
            this.dgv_employee_search = new System.Windows.Forms.DataGridView();
            this.lbl_e_name = new System.Windows.Forms.Label();
            this.lbl_e_salary = new System.Windows.Forms.Label();
            this.lbl_join_date = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_e_pass = new System.Windows.Forms.Label();
            this.txt_e_name = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.dtp_e_joining = new System.Windows.Forms.DateTimePicker();
            this.cmbo_role_chose = new System.Windows.Forms.ComboBox();
            this.txt_e_pass = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add_employee = new System.Windows.Forms.Button();
            this.btn_add_new_emp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee_search)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search_employee
            // 
            this.txt_search_employee.Location = new System.Drawing.Point(48, 42);
            this.txt_search_employee.Name = "txt_search_employee";
            this.txt_search_employee.Size = new System.Drawing.Size(438, 32);
            this.txt_search_employee.TabIndex = 0;
            this.txt_search_employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_srch_employee
            // 
            this.btn_srch_employee.Location = new System.Drawing.Point(513, 39);
            this.btn_srch_employee.Name = "btn_srch_employee";
            this.btn_srch_employee.Size = new System.Drawing.Size(91, 40);
            this.btn_srch_employee.TabIndex = 1;
            this.btn_srch_employee.Text = "Search";
            this.btn_srch_employee.UseVisualStyleBackColor = true;
            this.btn_srch_employee.Click += new System.EventHandler(this.btn_srch_employee_Click);
            // 
            // dgv_employee_search
            // 
            this.dgv_employee_search.AllowUserToAddRows = false;
            this.dgv_employee_search.AllowUserToDeleteRows = false;
            this.dgv_employee_search.AllowUserToOrderColumns = true;
            this.dgv_employee_search.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_employee_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_employee_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee_search.Location = new System.Drawing.Point(48, 93);
            this.dgv_employee_search.Name = "dgv_employee_search";
            this.dgv_employee_search.ReadOnly = true;
            this.dgv_employee_search.RowHeadersWidth = 51;
            this.dgv_employee_search.RowTemplate.Height = 24;
            this.dgv_employee_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employee_search.Size = new System.Drawing.Size(556, 150);
            this.dgv_employee_search.TabIndex = 2;
            this.dgv_employee_search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_search_CellClick);
            // 
            // lbl_e_name
            // 
            this.lbl_e_name.AutoSize = true;
            this.lbl_e_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_e_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_e_name.Location = new System.Drawing.Point(43, 319);
            this.lbl_e_name.Name = "lbl_e_name";
            this.lbl_e_name.Size = new System.Drawing.Size(137, 31);
            this.lbl_e_name.TabIndex = 3;
            this.lbl_e_name.Text = "Employee Name: ";
            // 
            // lbl_e_salary
            // 
            this.lbl_e_salary.AutoSize = true;
            this.lbl_e_salary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_e_salary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_e_salary.Location = new System.Drawing.Point(43, 376);
            this.lbl_e_salary.Name = "lbl_e_salary";
            this.lbl_e_salary.Size = new System.Drawing.Size(66, 31);
            this.lbl_e_salary.TabIndex = 4;
            this.lbl_e_salary.Text = "Salary :";
            // 
            // lbl_join_date
            // 
            this.lbl_join_date.AutoSize = true;
            this.lbl_join_date.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_join_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_join_date.Location = new System.Drawing.Point(43, 435);
            this.lbl_join_date.Name = "lbl_join_date";
            this.lbl_join_date.Size = new System.Drawing.Size(111, 31);
            this.lbl_join_date.TabIndex = 5;
            this.lbl_join_date.Text = "Joining Date : ";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_role.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_role.Location = new System.Drawing.Point(43, 495);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(57, 31);
            this.lbl_role.TabIndex = 6;
            this.lbl_role.Text = "Role : ";
            // 
            // lbl_e_pass
            // 
            this.lbl_e_pass.AutoSize = true;
            this.lbl_e_pass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_e_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_e_pass.Location = new System.Drawing.Point(43, 559);
            this.lbl_e_pass.Name = "lbl_e_pass";
            this.lbl_e_pass.Size = new System.Drawing.Size(164, 31);
            this.lbl_e_pass.TabIndex = 7;
            this.lbl_e_pass.Text = "Employee Password : ";
            // 
            // txt_e_name
            // 
            this.txt_e_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_e_name.Location = new System.Drawing.Point(253, 319);
            this.txt_e_name.Name = "txt_e_name";
            this.txt_e_name.Size = new System.Drawing.Size(351, 32);
            this.txt_e_name.TabIndex = 8;
            // 
            // txt_salary
            // 
            this.txt_salary.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_salary.Location = new System.Drawing.Point(253, 376);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(351, 32);
            this.txt_salary.TabIndex = 9;
            // 
            // dtp_e_joining
            // 
            this.dtp_e_joining.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_e_joining.Location = new System.Drawing.Point(253, 435);
            this.dtp_e_joining.Name = "dtp_e_joining";
            this.dtp_e_joining.Size = new System.Drawing.Size(351, 32);
            this.dtp_e_joining.TabIndex = 10;
            // 
            // cmbo_role_chose
            // 
            this.cmbo_role_chose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbo_role_chose.FormattingEnabled = true;
            this.cmbo_role_chose.Items.AddRange(new object[] {
            "Owner",
            "Seller"});
            this.cmbo_role_chose.Location = new System.Drawing.Point(253, 489);
            this.cmbo_role_chose.Name = "cmbo_role_chose";
            this.cmbo_role_chose.Size = new System.Drawing.Size(351, 37);
            this.cmbo_role_chose.TabIndex = 11;
            // 
            // txt_e_pass
            // 
            this.txt_e_pass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_e_pass.Location = new System.Drawing.Point(253, 556);
            this.txt_e_pass.Name = "txt_e_pass";
            this.txt_e_pass.Size = new System.Drawing.Size(351, 32);
            this.txt_e_pass.TabIndex = 12;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(121, 631);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(85, 38);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_close.Location = new System.Drawing.Point(253, 631);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.Location = new System.Drawing.Point(519, 631);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 38);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add_employee
            // 
            this.btn_add_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add_employee.Location = new System.Drawing.Point(365, 631);
            this.btn_add_employee.Name = "btn_add_employee";
            this.btn_add_employee.Size = new System.Drawing.Size(128, 38);
            this.btn_add_employee.TabIndex = 16;
            this.btn_add_employee.Text = "Add Employee";
            this.btn_add_employee.UseVisualStyleBackColor = false;
            this.btn_add_employee.Click += new System.EventHandler(this.btn_add_employee_Click);
            // 
            // btn_add_new_emp
            // 
            this.btn_add_new_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_new_emp.Location = new System.Drawing.Point(223, 260);
            this.btn_add_new_emp.Name = "btn_add_new_emp";
            this.btn_add_new_emp.Size = new System.Drawing.Size(204, 38);
            this.btn_add_new_emp.TabIndex = 17;
            this.btn_add_new_emp.Text = "Add New Employee";
            this.btn_add_new_emp.UseVisualStyleBackColor = false;
            this.btn_add_new_emp.Click += new System.EventHandler(this.btn_add_new_emp_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(684, 697);
            this.Controls.Add(this.btn_add_new_emp);
            this.Controls.Add(this.btn_add_employee);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_e_pass);
            this.Controls.Add(this.cmbo_role_chose);
            this.Controls.Add(this.dtp_e_joining);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_e_name);
            this.Controls.Add(this.lbl_e_pass);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_join_date);
            this.Controls.Add(this.lbl_e_salary);
            this.Controls.Add(this.lbl_e_name);
            this.Controls.Add(this.dgv_employee_search);
            this.Controls.Add(this.btn_srch_employee);
            this.Controls.Add(this.txt_search_employee);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search_employee;
        private System.Windows.Forms.Button btn_srch_employee;
        private System.Windows.Forms.DataGridView dgv_employee_search;
        private System.Windows.Forms.Label lbl_e_name;
        private System.Windows.Forms.Label lbl_e_salary;
        private System.Windows.Forms.Label lbl_join_date;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_e_pass;
        private System.Windows.Forms.TextBox txt_e_name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.DateTimePicker dtp_e_joining;
        private System.Windows.Forms.ComboBox cmbo_role_chose;
        private System.Windows.Forms.TextBox txt_e_pass;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add_employee;
        private System.Windows.Forms.Button btn_add_new_emp;
    }
}