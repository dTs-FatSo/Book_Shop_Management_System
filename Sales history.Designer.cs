namespace Book_Shop_Management_System
{
    partial class Sales_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_history));
            this.dgv_sales_history = new System.Windows.Forms.DataGridView();
            this.lbl_made_By = new System.Windows.Forms.Label();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_history)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sales_history
            // 
            this.dgv_sales_history.AllowUserToAddRows = false;
            this.dgv_sales_history.AllowUserToDeleteRows = false;
            this.dgv_sales_history.AllowUserToOrderColumns = true;
            this.dgv_sales_history.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv_sales_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_sales_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales_history.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_sales_history.Location = new System.Drawing.Point(16, 165);
            this.dgv_sales_history.Name = "dgv_sales_history";
            this.dgv_sales_history.ReadOnly = true;
            this.dgv_sales_history.RowHeadersWidth = 51;
            this.dgv_sales_history.RowTemplate.Height = 24;
            this.dgv_sales_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sales_history.Size = new System.Drawing.Size(654, 367);
            this.dgv_sales_history.TabIndex = 1;
            // 
            // lbl_made_By
            // 
            this.lbl_made_By.AutoSize = true;
            this.lbl_made_By.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_made_By.Location = new System.Drawing.Point(12, 80);
            this.lbl_made_By.Name = "lbl_made_By";
            this.lbl_made_By.Size = new System.Drawing.Size(175, 41);
            this.lbl_made_By.TabIndex = 2;
            this.lbl_made_By.Text = "Sales made by : ";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.BackColor = System.Drawing.Color.Ivory;
            this.txt_emp_name.Location = new System.Drawing.Point(213, 89);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.ReadOnly = true;
            this.txt_emp_name.Size = new System.Drawing.Size(330, 32);
            this.txt_emp_name.TabIndex = 3;
            this.txt_emp_name.TextChanged += new System.EventHandler(this.txt_emp_name_TextChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(278, 587);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Sales_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_emp_name);
            this.Controls.Add(this.lbl_made_By);
            this.Controls.Add(this.dgv_sales_history);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sales_history";
            this.Text = "Sales_history";
            this.Load += new System.EventHandler(this.Sales_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sales_history;
        private System.Windows.Forms.Label lbl_made_By;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.Button btn_close;
    }
}