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
            this.btn_purchase = new System.Windows.Forms.Button();
            this.dgv_purchase_history = new System.Windows.Forms.DataGridView();
            this.btn_p_history = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase_history)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pur_search
            // 
            this.txt_pur_search.Font = new System.Drawing.Font("Monotxt", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pur_search.Location = new System.Drawing.Point(21, 41);
            this.txt_pur_search.Name = "txt_pur_search";
            this.txt_pur_search.Size = new System.Drawing.Size(482, 36);
            this.txt_pur_search.TabIndex = 0;
            this.txt_pur_search.Text = "Book Name or Author Name";
            this.txt_pur_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pur_search.Click += new System.EventHandler(this.txt_pur_search_Click);
            this.txt_pur_search.TextChanged += new System.EventHandler(this.txt_pur_search_TextChanged);
            // 
            // btn_pur_search
            // 
            this.btn_pur_search.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.btn_pur_search.Location = new System.Drawing.Point(519, 40);
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
            this.dgv_book.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_book.Location = new System.Drawing.Point(21, 95);
            this.dgv_book.Name = "dgv_book";
            this.dgv_book.ReadOnly = true;
            this.dgv_book.RowHeadersWidth = 51;
            this.dgv_book.RowTemplate.Height = 24;
            this.dgv_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_book.Size = new System.Drawing.Size(574, 150);
            this.dgv_book.TabIndex = 2;
            this.dgv_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_book_CellClick);
            this.dgv_book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_purchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchase.Location = new System.Drawing.Point(21, 275);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(123, 40);
            this.btn_purchase.TabIndex = 3;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // dgv_purchase_history
            // 
            this.dgv_purchase_history.AllowUserToAddRows = false;
            this.dgv_purchase_history.AllowUserToDeleteRows = false;
            this.dgv_purchase_history.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_purchase_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_purchase_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchase_history.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_purchase_history.Location = new System.Drawing.Point(21, 334);
            this.dgv_purchase_history.Name = "dgv_purchase_history";
            this.dgv_purchase_history.ReadOnly = true;
            this.dgv_purchase_history.RowHeadersWidth = 51;
            this.dgv_purchase_history.RowTemplate.Height = 24;
            this.dgv_purchase_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_purchase_history.Size = new System.Drawing.Size(574, 150);
            this.dgv_purchase_history.TabIndex = 4;
            this.dgv_purchase_history.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btn_p_history
            // 
            this.btn_p_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_p_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_p_history.Location = new System.Drawing.Point(440, 275);
            this.btn_p_history.Name = "btn_p_history";
            this.btn_p_history.Size = new System.Drawing.Size(155, 40);
            this.btn_p_history.TabIndex = 5;
            this.btn_p_history.Text = "Purchase History";
            this.btn_p_history.UseVisualStyleBackColor = false;
            this.btn_p_history.Click += new System.EventHandler(this.btn_p_history_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(272, 507);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 47);
            this.btnclose.TabIndex = 34;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cart.Location = new System.Drawing.Point(247, 275);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(123, 40);
            this.btn_cart.TabIndex = 35;
            this.btn_cart.Text = "Show Cart";
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(635, 616);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btn_p_history);
            this.Controls.Add(this.dgv_purchase_history);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.dgv_book);
            this.Controls.Add(this.btn_pur_search);
            this.Controls.Add(this.txt_pur_search);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pur_search;
        private System.Windows.Forms.Button btn_pur_search;
        private System.Windows.Forms.DataGridView dgv_book;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.DataGridView dgv_purchase_history;
        private System.Windows.Forms.Button btn_p_history;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btn_cart;
    }
}