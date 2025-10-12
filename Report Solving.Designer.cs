namespace Book_Shop_Management_System
{
    partial class Report_Solving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Solving));
            this.btn_submit_reports = new System.Windows.Forms.Button();
            this.dgv_submitted_reports = new System.Windows.Forms.DataGridView();
            this.btn_resolved = new System.Windows.Forms.Button();
            this.btn_investigating = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_submitted_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit_reports
            // 
            this.btn_submit_reports.BackColor = System.Drawing.Color.Salmon;
            this.btn_submit_reports.Location = new System.Drawing.Point(255, 34);
            this.btn_submit_reports.Name = "btn_submit_reports";
            this.btn_submit_reports.Size = new System.Drawing.Size(162, 38);
            this.btn_submit_reports.TabIndex = 0;
            this.btn_submit_reports.Text = "Submitted Reports";
            this.btn_submit_reports.UseVisualStyleBackColor = false;
            this.btn_submit_reports.Click += new System.EventHandler(this.btn_submit_reports_Click);
            // 
            // dgv_submitted_reports
            // 
            this.dgv_submitted_reports.AllowUserToAddRows = false;
            this.dgv_submitted_reports.AllowUserToDeleteRows = false;
            this.dgv_submitted_reports.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgv_submitted_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_submitted_reports.Location = new System.Drawing.Point(26, 89);
            this.dgv_submitted_reports.Name = "dgv_submitted_reports";
            this.dgv_submitted_reports.ReadOnly = true;
            this.dgv_submitted_reports.RowHeadersWidth = 51;
            this.dgv_submitted_reports.RowTemplate.Height = 24;
            this.dgv_submitted_reports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_submitted_reports.Size = new System.Drawing.Size(634, 196);
            this.dgv_submitted_reports.TabIndex = 1;
            // 
            // btn_resolved
            // 
            this.btn_resolved.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_resolved.Location = new System.Drawing.Point(26, 324);
            this.btn_resolved.Name = "btn_resolved";
            this.btn_resolved.Size = new System.Drawing.Size(126, 38);
            this.btn_resolved.TabIndex = 2;
            this.btn_resolved.Text = "Resolved";
            this.btn_resolved.UseVisualStyleBackColor = false;
            this.btn_resolved.Click += new System.EventHandler(this.btn_resolved_Click);
            // 
            // btn_investigating
            // 
            this.btn_investigating.BackColor = System.Drawing.Color.Khaki;
            this.btn_investigating.Location = new System.Drawing.Point(194, 324);
            this.btn_investigating.Name = "btn_investigating";
            this.btn_investigating.Size = new System.Drawing.Size(126, 38);
            this.btn_investigating.TabIndex = 3;
            this.btn_investigating.Text = "Investigating";
            this.btn_investigating.UseVisualStyleBackColor = false;
            this.btn_investigating.Click += new System.EventHandler(this.btn_investigating_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.Location = new System.Drawing.Point(534, 324);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(126, 38);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete Report";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(288, 583);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 23;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Report_Solving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_investigating);
            this.Controls.Add(this.btn_resolved);
            this.Controls.Add(this.dgv_submitted_reports);
            this.Controls.Add(this.btn_submit_reports);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Report_Solving";
            this.Text = "Report_Solving";
            this.Load += new System.EventHandler(this.Report_Solving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_submitted_reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_submit_reports;
        private System.Windows.Forms.DataGridView dgv_submitted_reports;
        private System.Windows.Forms.Button btn_resolved;
        private System.Windows.Forms.Button btn_investigating;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_close;
    }
}