namespace Book_Shop_Management_System
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.lbl_rprt_submission = new System.Windows.Forms.Label();
            this.lbl_rprt_write = new System.Windows.Forms.Label();
            this.rtxt_rprt_write = new System.Windows.Forms.RichTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dgv_reports = new System.Windows.Forms.DataGridView();
            this.btn_previous_reports = new System.Windows.Forms.Button();
            this.lbl_rprt_against = new System.Windows.Forms.Label();
            this.cmbo_against = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rprt_submission
            // 
            this.lbl_rprt_submission.AutoSize = true;
            this.lbl_rprt_submission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_rprt_submission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_rprt_submission.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rprt_submission.Location = new System.Drawing.Point(201, 2);
            this.lbl_rprt_submission.Name = "lbl_rprt_submission";
            this.lbl_rprt_submission.Size = new System.Drawing.Size(249, 50);
            this.lbl_rprt_submission.TabIndex = 0;
            this.lbl_rprt_submission.Text = "Report Submission";
            // 
            // lbl_rprt_write
            // 
            this.lbl_rprt_write.AutoSize = true;
            this.lbl_rprt_write.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_rprt_write.Location = new System.Drawing.Point(21, 75);
            this.lbl_rprt_write.Name = "lbl_rprt_write";
            this.lbl_rprt_write.Size = new System.Drawing.Size(218, 29);
            this.lbl_rprt_write.TabIndex = 1;
            this.lbl_rprt_write.Text = "Write your Report in the box : ";
            // 
            // rtxt_rprt_write
            // 
            this.rtxt_rprt_write.BackColor = System.Drawing.Color.Ivory;
            this.rtxt_rprt_write.Location = new System.Drawing.Point(26, 122);
            this.rtxt_rprt_write.Name = "rtxt_rprt_write";
            this.rtxt_rprt_write.Size = new System.Drawing.Size(586, 157);
            this.rtxt_rprt_write.TabIndex = 2;
            this.rtxt_rprt_write.Text = "";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_submit.Location = new System.Drawing.Point(298, 288);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(81, 35);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dgv_reports
            // 
            this.dgv_reports.AllowUserToAddRows = false;
            this.dgv_reports.AllowUserToDeleteRows = false;
            this.dgv_reports.AllowUserToOrderColumns = true;
            this.dgv_reports.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgv_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reports.Location = new System.Drawing.Point(26, 374);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.ReadOnly = true;
            this.dgv_reports.RowHeadersWidth = 51;
            this.dgv_reports.RowTemplate.Height = 24;
            this.dgv_reports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reports.Size = new System.Drawing.Size(586, 207);
            this.dgv_reports.TabIndex = 4;
            this.dgv_reports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reports_CellContentClick);
            // 
            // btn_previous_reports
            // 
            this.btn_previous_reports.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_previous_reports.Location = new System.Drawing.Point(246, 330);
            this.btn_previous_reports.Name = "btn_previous_reports";
            this.btn_previous_reports.Size = new System.Drawing.Size(182, 35);
            this.btn_previous_reports.TabIndex = 5;
            this.btn_previous_reports.Text = "Previous Reports";
            this.btn_previous_reports.UseVisualStyleBackColor = false;
            this.btn_previous_reports.Click += new System.EventHandler(this.btn_previous_reports_Click);
            // 
            // lbl_rprt_against
            // 
            this.lbl_rprt_against.AutoSize = true;
            this.lbl_rprt_against.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_rprt_against.Location = new System.Drawing.Point(327, 75);
            this.lbl_rprt_against.Name = "lbl_rprt_against";
            this.lbl_rprt_against.Size = new System.Drawing.Size(123, 29);
            this.lbl_rprt_against.TabIndex = 6;
            this.lbl_rprt_against.Text = "Report Against: ";
            // 
            // cmbo_against
            // 
            this.cmbo_against.BackColor = System.Drawing.Color.Azure;
            this.cmbo_against.FormattingEnabled = true;
            this.cmbo_against.Items.AddRange(new object[] {
            "Owner",
            "Employee",
            "Book",
            "Author",
            "Decoration",
            "Management"});
            this.cmbo_against.Location = new System.Drawing.Point(491, 68);
            this.cmbo_against.Name = "cmbo_against";
            this.cmbo_against.Size = new System.Drawing.Size(121, 37);
            this.cmbo_against.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(365, 587);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.Location = new System.Drawing.Point(232, 587);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 38);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete Report";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(665, 663);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cmbo_against);
            this.Controls.Add(this.lbl_rprt_against);
            this.Controls.Add(this.btn_previous_reports);
            this.Controls.Add(this.dgv_reports);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rtxt_rprt_write);
            this.Controls.Add(this.lbl_rprt_write);
            this.Controls.Add(this.lbl_rprt_submission);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rprt_submission;
        private System.Windows.Forms.Label lbl_rprt_write;
        private System.Windows.Forms.RichTextBox rtxt_rprt_write;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView dgv_reports;
        private System.Windows.Forms.Button btn_previous_reports;
        private System.Windows.Forms.Label lbl_rprt_against;
        private System.Windows.Forms.ComboBox cmbo_against;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
    }
}