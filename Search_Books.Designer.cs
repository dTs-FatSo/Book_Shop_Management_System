namespace Book_Shop_Management_System
{
    partial class Search_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Books));
            this.dgv_book = new System.Windows.Forms.DataGridView();
            this.btn_pur_search = new System.Windows.Forms.Button();
            this.txt_pur_search = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_book
            // 
            this.dgv_book.AllowUserToAddRows = false;
            this.dgv_book.AllowUserToDeleteRows = false;
            this.dgv_book.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_book.Location = new System.Drawing.Point(55, 226);
            this.dgv_book.Name = "dgv_book";
            this.dgv_book.ReadOnly = true;
            this.dgv_book.RowHeadersWidth = 51;
            this.dgv_book.RowTemplate.Height = 24;
            this.dgv_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_book.Size = new System.Drawing.Size(574, 274);
            this.dgv_book.TabIndex = 5;
            // 
            // btn_pur_search
            // 
            this.btn_pur_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_pur_search.Location = new System.Drawing.Point(553, 171);
            this.btn_pur_search.Name = "btn_pur_search";
            this.btn_pur_search.Size = new System.Drawing.Size(75, 37);
            this.btn_pur_search.TabIndex = 4;
            this.btn_pur_search.Text = "Search";
            this.btn_pur_search.UseVisualStyleBackColor = false;
            this.btn_pur_search.Click += new System.EventHandler(this.btn_pur_search_Click);
            // 
            // txt_pur_search
            // 
            this.txt_pur_search.Font = new System.Drawing.Font("Monotxt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pur_search.Location = new System.Drawing.Point(55, 172);
            this.txt_pur_search.Name = "txt_pur_search";
            this.txt_pur_search.Size = new System.Drawing.Size(482, 36);
            this.txt_pur_search.TabIndex = 3;
            this.txt_pur_search.Text = "Book Name or Author Name";
            this.txt_pur_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pur_search.Click += new System.EventHandler(this.txt_pur_search_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(299, 530);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Search_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.register_background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_book);
            this.Controls.Add(this.btn_pur_search);
            this.Controls.Add(this.txt_pur_search);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search_Books";
            this.Text = "Search_Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_book;
        private System.Windows.Forms.Button btn_pur_search;
        private System.Windows.Forms.TextBox txt_pur_search;
        private System.Windows.Forms.Button btn_close;
    }
}