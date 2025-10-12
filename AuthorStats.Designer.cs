namespace Book_Shop_Management_System
{
    partial class AuthorStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorStats));
            this.btn_sold_bks = new System.Windows.Forms.Button();
            this.lbl_authr_stats = new System.Windows.Forms.Label();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_gender = new System.Windows.Forms.Button();
            this.btn_Age_group = new System.Windows.Forms.Button();
            this.dgv_stats = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stats)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sold_bks
            // 
            this.btn_sold_bks.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_sold_bks.Location = new System.Drawing.Point(26, 72);
            this.btn_sold_bks.Name = "btn_sold_bks";
            this.btn_sold_bks.Size = new System.Drawing.Size(101, 39);
            this.btn_sold_bks.TabIndex = 0;
            this.btn_sold_bks.Text = "Top Books";
            this.btn_sold_bks.UseVisualStyleBackColor = false;
            this.btn_sold_bks.Click += new System.EventHandler(this.btn_sold_bks_Click);
            // 
            // lbl_authr_stats
            // 
            this.lbl_authr_stats.AutoSize = true;
            this.lbl_authr_stats.BackColor = System.Drawing.Color.Beige;
            this.lbl_authr_stats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_authr_stats.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_authr_stats.Location = new System.Drawing.Point(242, 9);
            this.lbl_authr_stats.Name = "lbl_authr_stats";
            this.lbl_authr_stats.Size = new System.Drawing.Size(149, 43);
            this.lbl_authr_stats.TabIndex = 1;
            this.lbl_authr_stats.Text = "Author Stats";
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_category.Location = new System.Drawing.Point(141, 72);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(146, 39);
            this.btn_category.TabIndex = 2;
            this.btn_category.Text = "Sales by Category";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_gender
            // 
            this.btn_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_gender.Location = new System.Drawing.Point(305, 72);
            this.btn_gender.Name = "btn_gender";
            this.btn_gender.Size = new System.Drawing.Size(157, 39);
            this.btn_gender.TabIndex = 3;
            this.btn_gender.Text = "Purchase by Gender";
            this.btn_gender.UseVisualStyleBackColor = false;
            this.btn_gender.Click += new System.EventHandler(this.btn_gender_Click);
            // 
            // btn_Age_group
            // 
            this.btn_Age_group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Age_group.Location = new System.Drawing.Point(479, 71);
            this.btn_Age_group.Name = "btn_Age_group";
            this.btn_Age_group.Size = new System.Drawing.Size(183, 39);
            this.btn_Age_group.TabIndex = 4;
            this.btn_Age_group.Text = "Purchase by AgeGroup";
            this.btn_Age_group.UseVisualStyleBackColor = false;
            this.btn_Age_group.Click += new System.EventHandler(this.btn_Age_group_Click);
            // 
            // dgv_stats
            // 
            this.dgv_stats.AllowUserToAddRows = false;
            this.dgv_stats.AllowUserToDeleteRows = false;
            this.dgv_stats.AllowUserToOrderColumns = true;
            this.dgv_stats.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stats.GridColor = System.Drawing.Color.MistyRose;
            this.dgv_stats.Location = new System.Drawing.Point(26, 158);
            this.dgv_stats.Name = "dgv_stats";
            this.dgv_stats.ReadOnly = true;
            this.dgv_stats.RowHeadersWidth = 51;
            this.dgv_stats.RowTemplate.Height = 24;
            this.dgv_stats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stats.Size = new System.Drawing.Size(628, 377);
            this.dgv_stats.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(294, 603);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 27;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // AuthorStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_stats);
            this.Controls.Add(this.btn_Age_group);
            this.Controls.Add(this.btn_gender);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.lbl_authr_stats);
            this.Controls.Add(this.btn_sold_bks);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthorStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorStats";
            this.Load += new System.EventHandler(this.AuthorStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sold_bks;
        private System.Windows.Forms.Label lbl_authr_stats;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_gender;
        private System.Windows.Forms.Button btn_Age_group;
        private System.Windows.Forms.DataGridView dgv_stats;
        private System.Windows.Forms.Button btn_close;
    }
}