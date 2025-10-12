namespace Book_Shop_Management_System
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.lbl_book_page = new System.Windows.Forms.Label();
            this.lbl_bk_name = new System.Windows.Forms.Label();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_bk_name = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cmbo_category = new System.Windows.Forms.ComboBox();
            this.btn_add_bk = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_book_page
            // 
            this.lbl_book_page.AutoSize = true;
            this.lbl_book_page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_book_page.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_page.Location = new System.Drawing.Point(188, 41);
            this.lbl_book_page.Name = "lbl_book_page";
            this.lbl_book_page.Size = new System.Drawing.Size(271, 50);
            this.lbl_book_page.TabIndex = 0;
            this.lbl_book_page.Text = "Add New Book Page";
            // 
            // lbl_bk_name
            // 
            this.lbl_bk_name.AutoSize = true;
            this.lbl_bk_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_bk_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_bk_name.Location = new System.Drawing.Point(53, 181);
            this.lbl_bk_name.Name = "lbl_bk_name";
            this.lbl_bk_name.Size = new System.Drawing.Size(104, 31);
            this.lbl_bk_name.TabIndex = 1;
            this.lbl_bk_name.Text = "Book Name :";
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_isbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_isbn.Location = new System.Drawing.Point(53, 252);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(62, 31);
            this.lbl_isbn.TabIndex = 2;
            this.lbl_isbn.Text = "ISBN : ";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_price.Location = new System.Drawing.Point(53, 326);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(60, 31);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Price : ";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_category.Location = new System.Drawing.Point(53, 403);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(88, 31);
            this.lbl_category.TabIndex = 4;
            this.lbl_category.Text = "Category : ";
            // 
            // txt_bk_name
            // 
            this.txt_bk_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_bk_name.Location = new System.Drawing.Point(188, 181);
            this.txt_bk_name.Name = "txt_bk_name";
            this.txt_bk_name.Size = new System.Drawing.Size(401, 32);
            this.txt_bk_name.TabIndex = 5;
            // 
            // txt_isbn
            // 
            this.txt_isbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_isbn.Location = new System.Drawing.Point(188, 249);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(401, 32);
            this.txt_isbn.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_price.Location = new System.Drawing.Point(188, 326);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(401, 32);
            this.txt_price.TabIndex = 7;
            // 
            // cmbo_category
            // 
            this.cmbo_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbo_category.FormattingEnabled = true;
            this.cmbo_category.Items.AddRange(new object[] {
            "Story",
            "Drama",
            "Travel",
            "Adventure",
            "Novel",
            "Horror",
            "Mystery"});
            this.cmbo_category.Location = new System.Drawing.Point(188, 397);
            this.cmbo_category.Name = "cmbo_category";
            this.cmbo_category.Size = new System.Drawing.Size(257, 37);
            this.cmbo_category.TabIndex = 8;
            // 
            // btn_add_bk
            // 
            this.btn_add_bk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add_bk.Location = new System.Drawing.Point(276, 476);
            this.btn_add_bk.Name = "btn_add_bk";
            this.btn_add_bk.Size = new System.Drawing.Size(141, 48);
            this.btn_add_bk.TabIndex = 9;
            this.btn_add_bk.Text = "Add Book";
            this.btn_add_bk.UseVisualStyleBackColor = false;
            this.btn_add_bk.Click += new System.EventHandler(this.btn_add_bk_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(303, 557);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 26;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.register_background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add_bk);
            this.Controls.Add(this.cmbo_category);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_bk_name);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_isbn);
            this.Controls.Add(this.lbl_bk_name);
            this.Controls.Add(this.lbl_book_page);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_book_page;
        private System.Windows.Forms.Label lbl_bk_name;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txt_bk_name;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox cmbo_category;
        private System.Windows.Forms.Button btn_add_bk;
        private System.Windows.Forms.Button btn_close;
    }
}