namespace ĐồÁnGiaiĐoạn1
{
    partial class Booking
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddTabel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(13, 13);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(860, 678);
            this.flp.TabIndex = 3;
            // 
            // btAddTabel
            // 
            this.btAddTabel.BackColor = System.Drawing.Color.PeachPuff;
            this.btAddTabel.Location = new System.Drawing.Point(913, 13);
            this.btAddTabel.Name = "btAddTabel";
            this.btAddTabel.Size = new System.Drawing.Size(110, 36);
            this.btAddTabel.TabIndex = 4;
            this.btAddTabel.Text = "Add Table";
            this.btAddTabel.UseVisualStyleBackColor = false;
            this.btAddTabel.Click += new System.EventHandler(this.btAddTabel_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelete.Location = new System.Drawing.Point(913, 103);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(110, 36);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete Table ";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(913, 187);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(110, 36);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(913, 290);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(110, 41);
            this.btCheck.TabIndex = 7;
            this.btCheck.Text = "Check Dish";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 709);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddTabel);
            this.Controls.Add(this.flp);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Button btAddTabel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btCheck;
    }
}