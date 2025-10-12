namespace Book_Shop_Management_System
{
    partial class Sells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sells));
            this.btn_sold_books = new System.Windows.Forms.Button();
            this.dgv_sold_bks = new System.Windows.Forms.DataGridView();
            this.btn_top_bks = new System.Windows.Forms.Button();
            this.dgv_top_sold_bks = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sold_bks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top_sold_bks)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sold_books
            // 
            this.btn_sold_books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_sold_books.Location = new System.Drawing.Point(255, 35);
            this.btn_sold_books.Name = "btn_sold_books";
            this.btn_sold_books.Size = new System.Drawing.Size(156, 39);
            this.btn_sold_books.TabIndex = 0;
            this.btn_sold_books.Text = "Sold books of your";
            this.btn_sold_books.UseVisualStyleBackColor = false;
            this.btn_sold_books.Click += new System.EventHandler(this.btn_sold_books_Click);
            // 
            // dgv_sold_bks
            // 
            this.dgv_sold_bks.AllowUserToAddRows = false;
            this.dgv_sold_bks.AllowUserToDeleteRows = false;
            this.dgv_sold_bks.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_sold_bks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sold_bks.Location = new System.Drawing.Point(33, 97);
            this.dgv_sold_bks.Name = "dgv_sold_bks";
            this.dgv_sold_bks.ReadOnly = true;
            this.dgv_sold_bks.RowHeadersWidth = 51;
            this.dgv_sold_bks.RowTemplate.Height = 24;
            this.dgv_sold_bks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sold_bks.Size = new System.Drawing.Size(621, 205);
            this.dgv_sold_bks.TabIndex = 1;
            // 
            // btn_top_bks
            // 
            this.btn_top_bks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_top_bks.Location = new System.Drawing.Point(265, 329);
            this.btn_top_bks.Name = "btn_top_bks";
            this.btn_top_bks.Size = new System.Drawing.Size(156, 39);
            this.btn_top_bks.TabIndex = 2;
            this.btn_top_bks.Text = "Top Books sold";
            this.btn_top_bks.UseVisualStyleBackColor = false;
            this.btn_top_bks.Click += new System.EventHandler(this.btn_top_bks_Click);
            // 
            // dgv_top_sold_bks
            // 
            this.dgv_top_sold_bks.AllowUserToAddRows = false;
            this.dgv_top_sold_bks.AllowUserToDeleteRows = false;
            this.dgv_top_sold_bks.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgv_top_sold_bks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_top_sold_bks.Location = new System.Drawing.Point(33, 391);
            this.dgv_top_sold_bks.Name = "dgv_top_sold_bks";
            this.dgv_top_sold_bks.ReadOnly = true;
            this.dgv_top_sold_bks.RowHeadersWidth = 51;
            this.dgv_top_sold_bks.RowTemplate.Height = 24;
            this.dgv_top_sold_bks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_top_sold_bks.Size = new System.Drawing.Size(621, 205);
            this.dgv_top_sold_bks.TabIndex = 3;
            this.dgv_top_sold_bks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_top_sold_bks_CellContentClick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(298, 621);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 26;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Sells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_top_sold_bks);
            this.Controls.Add(this.btn_top_bks);
            this.Controls.Add(this.dgv_sold_bks);
            this.Controls.Add(this.btn_sold_books);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sells";
            this.Load += new System.EventHandler(this.Sells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sold_bks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top_sold_bks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sold_books;
        private System.Windows.Forms.DataGridView dgv_sold_bks;
        private System.Windows.Forms.Button btn_top_bks;
        private System.Windows.Forms.DataGridView dgv_top_sold_bks;
        private System.Windows.Forms.Button btn_close;
    }
}