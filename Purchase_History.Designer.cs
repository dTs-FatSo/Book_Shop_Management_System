namespace Book_Shop_Management_System
{
    partial class Purchase_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_History));
            this.btnclose = new System.Windows.Forms.Button();
            this.btn_p_history = new System.Windows.Forms.Button();
            this.dgv_purchase_history = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase_history)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(509, 35);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 47);
            this.btnclose.TabIndex = 37;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btn_p_history
            // 
            this.btn_p_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_p_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_p_history.Location = new System.Drawing.Point(33, 42);
            this.btn_p_history.Name = "btn_p_history";
            this.btn_p_history.Size = new System.Drawing.Size(155, 40);
            this.btn_p_history.TabIndex = 36;
            this.btn_p_history.Text = "Purchase History";
            this.btn_p_history.UseVisualStyleBackColor = false;
            this.btn_p_history.Click += new System.EventHandler(this.btn_p_history_Click);
            // 
            // dgv_purchase_history
            // 
            this.dgv_purchase_history.AllowUserToAddRows = false;
            this.dgv_purchase_history.AllowUserToDeleteRows = false;
            this.dgv_purchase_history.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_purchase_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_purchase_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchase_history.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_purchase_history.Location = new System.Drawing.Point(33, 97);
            this.dgv_purchase_history.Name = "dgv_purchase_history";
            this.dgv_purchase_history.ReadOnly = true;
            this.dgv_purchase_history.RowHeadersWidth = 51;
            this.dgv_purchase_history.RowTemplate.Height = 24;
            this.dgv_purchase_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_purchase_history.Size = new System.Drawing.Size(574, 475);
            this.dgv_purchase_history.TabIndex = 35;
            this.dgv_purchase_history.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_purchase_history_CellContentClick);
            // 
            // Purchase_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(686, 697);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btn_p_history);
            this.Controls.Add(this.dgv_purchase_history);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Purchase_History";
            this.Text = "Purchase_History";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btn_p_history;
        private System.Windows.Forms.DataGridView dgv_purchase_history;
    }
}