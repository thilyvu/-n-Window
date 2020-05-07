namespace ĐồÁnGiaiĐoạn1
{
    partial class loginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUSER = new System.Windows.Forms.TextBox();
            this.tbPASS = new System.Windows.Forms.TextBox();
            this.btLOGIN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbforgot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD :";
            // 
            // tbUSER
            // 
            this.tbUSER.Location = new System.Drawing.Point(188, 111);
            this.tbUSER.Name = "tbUSER";
            this.tbUSER.Size = new System.Drawing.Size(191, 22);
            this.tbUSER.TabIndex = 3;
            this.tbUSER.Text = "titanium";
            // 
            // tbPASS
            // 
            this.tbPASS.Location = new System.Drawing.Point(188, 167);
            this.tbPASS.Name = "tbPASS";
            this.tbPASS.PasswordChar = '*';
            this.tbPASS.Size = new System.Drawing.Size(191, 22);
            this.tbPASS.TabIndex = 4;
            this.tbPASS.Text = "0";
            // 
            // btLOGIN
            // 
            this.btLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLOGIN.Location = new System.Drawing.Point(128, 255);
            this.btLOGIN.Name = "btLOGIN";
            this.btLOGIN.Size = new System.Drawing.Size(105, 40);
            this.btLOGIN.TabIndex = 5;
            this.btLOGIN.Text = "LOGIN";
            this.btLOGIN.UseVisualStyleBackColor = false;
            this.btLOGIN.Click += new System.EventHandler(this.btLOGIN_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(275, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbforgot
            // 
            this.lbforgot.AutoSize = true;
            this.lbforgot.BackColor = System.Drawing.SystemColors.Control;
            this.lbforgot.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbforgot.Location = new System.Drawing.Point(337, 328);
            this.lbforgot.Name = "lbforgot";
            this.lbforgot.Size = new System.Drawing.Size(163, 17);
            this.lbforgot.TabIndex = 7;
            this.lbforgot.Text = "forgot your\'s password ?";
            this.lbforgot.Click += new System.EventHandler(this.lbforgot_Click);
            this.lbforgot.MouseLeave += new System.EventHandler(this.lbforgot_MouseLeave);
            this.lbforgot.MouseHover += new System.EventHandler(this.lbforgot_MouseHover);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 371);
            this.Controls.Add(this.lbforgot);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLOGIN);
            this.Controls.Add(this.tbPASS);
            this.Controls.Add(this.tbUSER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUSER;
        private System.Windows.Forms.TextBox tbPASS;
        private System.Windows.Forms.Button btLOGIN;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbforgot;
    }
}

