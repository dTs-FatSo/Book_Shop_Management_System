namespace Book_Shop_Management_System
{
    partial class User_receipt
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
            this.dgv_receipt = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_show_receipt = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receipt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_receipt
            // 
            this.dgv_receipt.AllowUserToAddRows = false;
            this.dgv_receipt.AllowUserToDeleteRows = false;
            this.dgv_receipt.AllowUserToOrderColumns = true;
            this.dgv_receipt.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receipt.Location = new System.Drawing.Point(28, 122);
            this.dgv_receipt.Name = "dgv_receipt";
            this.dgv_receipt.ReadOnly = true;
            this.dgv_receipt.RowHeadersWidth = 51;
            this.dgv_receipt.RowTemplate.Height = 24;
            this.dgv_receipt.Size = new System.Drawing.Size(453, 240);
            this.dgv_receipt.TabIndex = 1;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_total.Location = new System.Drawing.Point(72, 403);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(53, 31);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total";
            // 
            // btn_show_receipt
            // 
            this.btn_show_receipt.BackColor = System.Drawing.Color.SeaShell;
            this.btn_show_receipt.Location = new System.Drawing.Point(172, 35);
            this.btn_show_receipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_show_receipt.Name = "btn_show_receipt";
            this.btn_show_receipt.Size = new System.Drawing.Size(151, 56);
            this.btn_show_receipt.TabIndex = 3;
            this.btn_show_receipt.Text = "Show Receipt";
            this.btn_show_receipt.UseVisualStyleBackColor = false;
            this.btn_show_receipt.Click += new System.EventHandler(this.btn_show_receipt_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnclose.Location = new System.Drawing.Point(324, 399);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(74, 41);
            this.btnclose.TabIndex = 34;
            this.btnclose.Text = "Close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // User_receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(546, 816);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btn_show_receipt);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dgv_receipt);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User_receipt";
            this.Text = "User_receipt";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_receipt;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_show_receipt;
        private System.Windows.Forms.Button btnclose;
    }
}