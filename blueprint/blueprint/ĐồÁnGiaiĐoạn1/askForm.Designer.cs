namespace ĐồÁnGiaiĐoạn1
{
    partial class askForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btStaff = new System.Windows.Forms.Button();
            this.btManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Are";
            // 
            // btStaff
            // 
            this.btStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btStaff.Location = new System.Drawing.Point(97, 140);
            this.btStaff.Name = "btStaff";
            this.btStaff.Size = new System.Drawing.Size(125, 33);
            this.btStaff.TabIndex = 1;
            this.btStaff.Text = "Staff ?";
            this.btStaff.UseVisualStyleBackColor = false;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // btManager
            // 
            this.btManager.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btManager.Location = new System.Drawing.Point(269, 140);
            this.btManager.Name = "btManager";
            this.btManager.Size = new System.Drawing.Size(125, 33);
            this.btManager.TabIndex = 2;
            this.btManager.Text = "Manager ?";
            this.btManager.UseVisualStyleBackColor = false;
            this.btManager.Click += new System.EventHandler(this.btManager_Click);
            // 
            // askForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 225);
            this.Controls.Add(this.btManager);
            this.Controls.Add(this.btStaff);
            this.Controls.Add(this.label1);
            this.Name = "askForm";
            this.Text = "LOGIN QUESTION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStaff;
        private System.Windows.Forms.Button btManager;
    }
}