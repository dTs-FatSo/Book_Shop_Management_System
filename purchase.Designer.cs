namespace Book_Shop_Management_System
{
    partial class purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase));
            this.txt_pur_search = new System.Windows.Forms.TextBox();
            this.btn_pur_search = new System.Windows.Forms.Button();
            this.dgv_book = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pur_search
            // 
            this.txt_pur_search.Location = new System.Drawing.Point(45, 41);
            this.txt_pur_search.Name = "txt_pur_search";
            this.txt_pur_search.Size = new System.Drawing.Size(329, 32);
            this.txt_pur_search.TabIndex = 0;
            // 
            // btn_pur_search
            // 
            this.btn_pur_search.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.btn_pur_search.Location = new System.Drawing.Point(401, 40);
            this.btn_pur_search.Name = "btn_pur_search";
            this.btn_pur_search.Size = new System.Drawing.Size(75, 37);
            this.btn_pur_search.TabIndex = 1;
            this.btn_pur_search.Text = "Search";
            this.btn_pur_search.UseVisualStyleBackColor = true;
            this.btn_pur_search.Click += new System.EventHandler(this.btn_pur_search_Click);
            // 
            // dgv_book
            // 
            this.dgv_book.AllowUserToAddRows = false;
            this.dgv_book.AllowUserToDeleteRows = false;
            this.dgv_book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_book.Location = new System.Drawing.Point(21, 95);
            this.dgv_book.Name = "dgv_book";
            this.dgv_book.RowHeadersWidth = 51;
            this.dgv_book.RowTemplate.Height = 24;
            this.dgv_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_book.Size = new System.Drawing.Size(588, 150);
            this.dgv_book.TabIndex = 2;
            this.dgv_book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(635, 616);
            this.Controls.Add(this.dgv_book);
            this.Controls.Add(this.btn_pur_search);
            this.Controls.Add(this.txt_pur_search);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pur_search;
        private System.Windows.Forms.Button btn_pur_search;
        private System.Windows.Forms.DataGridView dgv_book;
    }
}