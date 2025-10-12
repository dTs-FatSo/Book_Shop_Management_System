namespace Book_Shop_Management_System
{
    partial class top_sold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(top_sold));
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_top_sold_bks = new System.Windows.Forms.DataGridView();
            this.btn_top_bks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top_sold_bks)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(298, 475);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 29;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dgv_top_sold_bks
            // 
            this.dgv_top_sold_bks.AllowUserToAddRows = false;
            this.dgv_top_sold_bks.AllowUserToDeleteRows = false;
            this.dgv_top_sold_bks.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgv_top_sold_bks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_top_sold_bks.Location = new System.Drawing.Point(33, 245);
            this.dgv_top_sold_bks.Name = "dgv_top_sold_bks";
            this.dgv_top_sold_bks.ReadOnly = true;
            this.dgv_top_sold_bks.RowHeadersWidth = 51;
            this.dgv_top_sold_bks.RowTemplate.Height = 24;
            this.dgv_top_sold_bks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_top_sold_bks.Size = new System.Drawing.Size(579, 205);
            this.dgv_top_sold_bks.TabIndex = 28;
            // 
            // btn_top_bks
            // 
            this.btn_top_bks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_top_bks.Location = new System.Drawing.Point(265, 183);
            this.btn_top_bks.Name = "btn_top_bks";
            this.btn_top_bks.Size = new System.Drawing.Size(156, 39);
            this.btn_top_bks.TabIndex = 27;
            this.btn_top_bks.Text = "Top Books sold";
            this.btn_top_bks.UseVisualStyleBackColor = false;
            this.btn_top_bks.Click += new System.EventHandler(this.btn_top_bks_Click);
            // 
            // top_sold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.register_background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_top_sold_bks);
            this.Controls.Add(this.btn_top_bks);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "top_sold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "top_sold";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top_sold_bks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_top_sold_bks;
        private System.Windows.Forms.Button btn_top_bks;
    }
}