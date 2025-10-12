namespace Book_Shop_Management_System
{
    partial class owner_approve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_approve));
            this.btn_pending = new System.Windows.Forms.Button();
            this.dgv_pendingorders = new System.Windows.Forms.DataGridView();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendingorders)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pending
            // 
            this.btn_pending.BackColor = System.Drawing.Color.MistyRose;
            this.btn_pending.Location = new System.Drawing.Point(79, 46);
            this.btn_pending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pending.Name = "btn_pending";
            this.btn_pending.Size = new System.Drawing.Size(140, 45);
            this.btn_pending.TabIndex = 0;
            this.btn_pending.Text = "Pending Orders";
            this.btn_pending.UseVisualStyleBackColor = false;
            this.btn_pending.Click += new System.EventHandler(this.btn_pending_Click);
            // 
            // dgv_pendingorders
            // 
            this.dgv_pendingorders.AllowUserToAddRows = false;
            this.dgv_pendingorders.AllowUserToDeleteRows = false;
            this.dgv_pendingorders.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgv_pendingorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pendingorders.Location = new System.Drawing.Point(12, 122);
            this.dgv_pendingorders.Name = "dgv_pendingorders";
            this.dgv_pendingorders.ReadOnly = true;
            this.dgv_pendingorders.RowHeadersWidth = 51;
            this.dgv_pendingorders.RowTemplate.Height = 24;
            this.dgv_pendingorders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pendingorders.Size = new System.Drawing.Size(642, 367);
            this.dgv_pendingorders.TabIndex = 1;
            this.dgv_pendingorders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pendingorders_CellClick);
            this.dgv_pendingorders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pendingorders_CellContentClick);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_confirm.Location = new System.Drawing.Point(281, 46);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(140, 45);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Salmon;
            this.btn_cancel.Location = new System.Drawing.Point(429, 46);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(140, 45);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_close.Location = new System.Drawing.Point(243, 515);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(140, 45);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // owner_approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Shop_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(680, 727);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dgv_pendingorders);
            this.Controls.Add(this.btn_pending);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "owner_approve";
            this.Text = "owner_approve";
            this.Load += new System.EventHandler(this.owner_approve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendingorders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pending;
        private System.Windows.Forms.DataGridView dgv_pendingorders;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_close;
    }
}