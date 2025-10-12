namespace Book_Shop_Management_System
{
    partial class Author_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author_update));
            this.btn_click_update = new System.Windows.Forms.Button();
            this.lbl_authr_name = new System.Windows.Forms.Label();
            this.txt_authr_name = new System.Windows.Forms.TextBox();
            this.lbl_authr_pass = new System.Windows.Forms.Label();
            this.txt_authr_pass = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_bks_you = new System.Windows.Forms.Button();
            this.dgv_bks_you = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bks_you)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_click_update
            // 
            this.btn_click_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_click_update.Location = new System.Drawing.Point(252, 21);
            this.btn_click_update.Name = "btn_click_update";
            this.btn_click_update.Size = new System.Drawing.Size(177, 44);
            this.btn_click_update.TabIndex = 0;
            this.btn_click_update.Text = "Click to update profile";
            this.btn_click_update.UseVisualStyleBackColor = false;
            this.btn_click_update.Click += new System.EventHandler(this.btn_click_update_Click);
            // 
            // lbl_authr_name
            // 
            this.lbl_authr_name.AutoSize = true;
            this.lbl_authr_name.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbl_authr_name.Location = new System.Drawing.Point(63, 100);
            this.lbl_authr_name.Name = "lbl_authr_name";
            this.lbl_authr_name.Size = new System.Drawing.Size(115, 29);
            this.lbl_authr_name.TabIndex = 1;
            this.lbl_authr_name.Text = "Author Name :";
            // 
            // txt_authr_name
            // 
            this.txt_authr_name.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_authr_name.Location = new System.Drawing.Point(208, 97);
            this.txt_authr_name.Name = "txt_authr_name";
            this.txt_authr_name.Size = new System.Drawing.Size(391, 32);
            this.txt_authr_name.TabIndex = 2;
            // 
            // lbl_authr_pass
            // 
            this.lbl_authr_pass.AutoSize = true;
            this.lbl_authr_pass.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbl_authr_pass.Location = new System.Drawing.Point(89, 170);
            this.lbl_authr_pass.Name = "lbl_authr_pass";
            this.lbl_authr_pass.Size = new System.Drawing.Size(89, 29);
            this.lbl_authr_pass.TabIndex = 3;
            this.lbl_authr_pass.Text = "Password : ";
            // 
            // txt_authr_pass
            // 
            this.txt_authr_pass.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_authr_pass.Location = new System.Drawing.Point(208, 167);
            this.txt_authr_pass.Name = "txt_authr_pass";
            this.txt_authr_pass.Size = new System.Drawing.Size(391, 32);
            this.txt_authr_pass.TabIndex = 4;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(299, 224);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 44);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_bks_you
            // 
            this.btn_bks_you.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_bks_you.Location = new System.Drawing.Point(282, 296);
            this.btn_bks_you.Name = "btn_bks_you";
            this.btn_bks_you.Size = new System.Drawing.Size(118, 44);
            this.btn_bks_you.TabIndex = 6;
            this.btn_bks_you.Text = "Books by you";
            this.btn_bks_you.UseVisualStyleBackColor = false;
            this.btn_bks_you.Click += new System.EventHandler(this.btn_bks_you_Click);
            // 
            // dgv_bks_you
            // 
            this.dgv_bks_you.AllowUserToAddRows = false;
            this.dgv_bks_you.AllowUserToDeleteRows = false;
            this.dgv_bks_you.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgv_bks_you.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bks_you.Location = new System.Drawing.Point(68, 355);
            this.dgv_bks_you.Name = "dgv_bks_you";
            this.dgv_bks_you.ReadOnly = true;
            this.dgv_bks_you.RowHeadersWidth = 51;
            this.dgv_bks_you.RowTemplate.Height = 24;
            this.dgv_bks_you.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bks_you.Size = new System.Drawing.Size(531, 233);
            this.dgv_bks_you.TabIndex = 7;
            this.dgv_bks_you.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bks_you_CellContentClick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(296, 613);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 38);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Author_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_bks_you);
            this.Controls.Add(this.btn_bks_you);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_authr_pass);
            this.Controls.Add(this.lbl_authr_pass);
            this.Controls.Add(this.txt_authr_name);
            this.Controls.Add(this.lbl_authr_name);
            this.Controls.Add(this.btn_click_update);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Author_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author_update";
            this.Load += new System.EventHandler(this.Author_update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bks_you)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_click_update;
        private System.Windows.Forms.Label lbl_authr_name;
        private System.Windows.Forms.TextBox txt_authr_name;
        private System.Windows.Forms.Label lbl_authr_pass;
        private System.Windows.Forms.TextBox txt_authr_pass;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_bks_you;
        private System.Windows.Forms.DataGridView dgv_bks_you;
        private System.Windows.Forms.Button btn_close;
    }
}