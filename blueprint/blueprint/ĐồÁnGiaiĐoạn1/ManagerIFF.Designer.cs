namespace ĐồÁnGiaiĐoạn1
{
    partial class ManagerIFF
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRHDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANAGERADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTWORKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blueprintsDataSet2 = new ĐồÁnGiaiĐoạn1.blueprintsDataSet2();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blueprintsDataSet1 = new ĐồÁnGiaiĐoạn1.blueprintsDataSet1();
            this.employeeTableAdapter = new ĐồÁnGiaiĐoạn1.blueprintsDataSet1TableAdapters.employeeTableAdapter();
            this.managerTableAdapter = new ĐồÁnGiaiĐoạn1.blueprintsDataSet2TableAdapters.managerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.bIRHDAYDataGridViewTextBoxColumn,
            this.mANAGERADDRESSDataGridViewTextBoxColumn,
            this.iDNUMBERDataGridViewTextBoxColumn,
            this.sHIFTWORKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.managerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1612, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            this.lASTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // bIRHDAYDataGridViewTextBoxColumn
            // 
            this.bIRHDAYDataGridViewTextBoxColumn.DataPropertyName = "BIRHDAY";
            this.bIRHDAYDataGridViewTextBoxColumn.HeaderText = "BIRHDAY";
            this.bIRHDAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIRHDAYDataGridViewTextBoxColumn.Name = "bIRHDAYDataGridViewTextBoxColumn";
            this.bIRHDAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // mANAGERADDRESSDataGridViewTextBoxColumn
            // 
            this.mANAGERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "MANAGERADDRESS";
            this.mANAGERADDRESSDataGridViewTextBoxColumn.HeaderText = "MANAGERADDRESS";
            this.mANAGERADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANAGERADDRESSDataGridViewTextBoxColumn.Name = "mANAGERADDRESSDataGridViewTextBoxColumn";
            this.mANAGERADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNUMBERDataGridViewTextBoxColumn
            // 
            this.iDNUMBERDataGridViewTextBoxColumn.DataPropertyName = "IDNUMBER";
            this.iDNUMBERDataGridViewTextBoxColumn.HeaderText = "IDNUMBER";
            this.iDNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNUMBERDataGridViewTextBoxColumn.Name = "iDNUMBERDataGridViewTextBoxColumn";
            this.iDNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // sHIFTWORKDataGridViewTextBoxColumn
            // 
            this.sHIFTWORKDataGridViewTextBoxColumn.DataPropertyName = "SHIFTWORK";
            this.sHIFTWORKDataGridViewTextBoxColumn.HeaderText = "SHIFTWORK";
            this.sHIFTWORKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHIFTWORKDataGridViewTextBoxColumn.Name = "sHIFTWORKDataGridViewTextBoxColumn";
            this.sHIFTWORKDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "manager";
            this.managerBindingSource.DataSource = this.blueprintsDataSet2;
            // 
            // blueprintsDataSet2
            // 
            this.blueprintsDataSet2.DataSetName = "blueprintsDataSet2";
            this.blueprintsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.blueprintsDataSet1;
            // 
            // blueprintsDataSet1
            // 
            this.blueprintsDataSet1.DataSetName = "blueprintsDataSet1";
            this.blueprintsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerIFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 666);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerIFF";
            this.Text = "Manager Infomation";
            this.Load += new System.EventHandler(this.AddEditRemoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintsDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private blueprintsDataSet1 blueprintsDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private blueprintsDataSet1TableAdapters.employeeTableAdapter employeeTableAdapter;
        private blueprintsDataSet2 blueprintsDataSet2;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private blueprintsDataSet2TableAdapters.managerTableAdapter managerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRHDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANAGERADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTWORKDataGridViewTextBoxColumn;
    }
}