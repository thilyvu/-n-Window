namespace ĐồÁnGiaiĐoạn1
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wordTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blueprintsDataSet = new ĐồÁnGiaiĐoạn1.blueprintsDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.wordTableTableAdapter = new ĐồÁnGiaiĐoạn1.blueprintsDataSetTableAdapters.WordTableTableAdapter();
            this.btArrange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btShowEmpoyee = new System.Windows.Forms.Button();
            this.btShowManager = new System.Windows.Forms.Button();
            this.btSW = new System.Windows.Forms.Button();
            this.btChangeShiftWork = new System.Windows.Forms.Button();
            this.btBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotalIncome = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.addEmployeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1393, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.changePassToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // changePassToolStripMenuItem
            // 
            this.changePassToolStripMenuItem.Name = "changePassToolStripMenuItem";
            this.changePassToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.changePassToolStripMenuItem.Text = "Change Pass";
            this.changePassToolStripMenuItem.Click += new System.EventHandler(this.changePassToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.addEmployeeToolStripMenuItem.Text = "Modify";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 490);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // wordTableBindingSource
            // 
            this.wordTableBindingSource.DataMember = "WordTable";
            this.wordTableBindingSource.DataSource = this.blueprintsDataSet;
            // 
            // blueprintsDataSet
            // 
            this.blueprintsDataSet.DataSetName = "blueprintsDataSet";
            this.blueprintsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Staff List :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(491, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // wordTableTableAdapter
            // 
            this.wordTableTableAdapter.ClearBeforeFill = true;
            // 
            // btArrange
            // 
            this.btArrange.Location = new System.Drawing.Point(105, 675);
            this.btArrange.Name = "btArrange";
            this.btArrange.Size = new System.Drawing.Size(108, 39);
            this.btArrange.TabIndex = 8;
            this.btArrange.Text = "Arrange";
            this.btArrange.UseVisualStyleBackColor = true;
            this.btArrange.Click += new System.EventHandler(this.btArrange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Employees :";
            // 
            // btShowEmpoyee
            // 
            this.btShowEmpoyee.Location = new System.Drawing.Point(686, 96);
            this.btShowEmpoyee.Name = "btShowEmpoyee";
            this.btShowEmpoyee.Size = new System.Drawing.Size(118, 45);
            this.btShowEmpoyee.TabIndex = 10;
            this.btShowEmpoyee.Text = "Show Employee ";
            this.btShowEmpoyee.UseVisualStyleBackColor = true;
            this.btShowEmpoyee.Click += new System.EventHandler(this.btShowEmpoyee_Click);
            // 
            // btShowManager
            // 
            this.btShowManager.Location = new System.Drawing.Point(886, 96);
            this.btShowManager.Name = "btShowManager";
            this.btShowManager.Size = new System.Drawing.Size(118, 45);
            this.btShowManager.TabIndex = 11;
            this.btShowManager.Text = "Show Manager";
            this.btShowManager.UseVisualStyleBackColor = true;
            this.btShowManager.Click += new System.EventHandler(this.btShowManager_Click);
            // 
            // btSW
            // 
            this.btSW.Location = new System.Drawing.Point(1064, 96);
            this.btSW.Name = "btSW";
            this.btSW.Size = new System.Drawing.Size(118, 45);
            this.btSW.TabIndex = 12;
            this.btSW.Text = "Show ShiftWork";
            this.btSW.UseVisualStyleBackColor = true;
            this.btSW.Click += new System.EventHandler(this.btSW_Click);
            // 
            // btChangeShiftWork
            // 
            this.btChangeShiftWork.Location = new System.Drawing.Point(264, 675);
            this.btChangeShiftWork.Name = "btChangeShiftWork";
            this.btChangeShiftWork.Size = new System.Drawing.Size(87, 39);
            this.btChangeShiftWork.TabIndex = 13;
            this.btChangeShiftWork.Text = "Next Day";
            this.btChangeShiftWork.UseVisualStyleBackColor = true;
            this.btChangeShiftWork.Click += new System.EventHandler(this.btChangeShiftWork_Click);
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(1230, 96);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(118, 45);
            this.btBook.TabIndex = 14;
            this.btBook.Text = "Booking ";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(951, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Revenue:";
            // 
            // tbTotalIncome
            // 
            this.tbTotalIncome.Location = new System.Drawing.Point(1064, 675);
            this.tbTotalIncome.Name = "tbTotalIncome";
            this.tbTotalIncome.Size = new System.Drawing.Size(193, 22);
            this.tbTotalIncome.TabIndex = 16;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 726);
            this.Controls.Add(this.tbTotalIncome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.btChangeShiftWork);
            this.Controls.Add(this.btSW);
            this.Controls.Add(this.btShowManager);
            this.Controls.Add(this.btShowEmpoyee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btArrange);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private blueprintsDataSet blueprintsDataSet;
        private System.Windows.Forms.BindingSource wordTableBindingSource;
        private blueprintsDataSetTableAdapters.WordTableTableAdapter wordTableTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button btArrange;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btShowEmpoyee;
        private System.Windows.Forms.Button btShowManager;
        private System.Windows.Forms.Button btSW;
        private System.Windows.Forms.Button btChangeShiftWork;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbTotalIncome;
    }
}