namespace WindowsApplication21
{
    partial class Form1
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
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValueP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Data";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Type";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Date";
            this.dataColumn3.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Value";
            this.dataColumn4.DataType = typeof(decimal);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.dataBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldName1,
            this.fieldType1,
            this.fieldYear,
            this.fieldValue1,
            this.fieldMonth,
            this.fieldQuarter,
            this.fieldValueP});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 33);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1074, 496);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.pivotGridControl1_CustomCellValue);
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.dataSet1;
            // 
            // fieldName1
            // 
            this.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldName1.AreaIndex = 1;
            this.fieldName1.Caption = "Name";
            this.fieldName1.FieldName = "Name";
            this.fieldName1.Name = "fieldName1";
            // 
            // fieldType1
            // 
            this.fieldType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldType1.AreaIndex = 0;
            this.fieldType1.Caption = "Type";
            this.fieldType1.FieldName = "Type";
            this.fieldType1.Name = "fieldType1";
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "Date";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldValue1
            // 
            this.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValue1.AreaIndex = 0;
            this.fieldValue1.Caption = "Value";
            this.fieldValue1.FieldName = "Value";
            this.fieldValue1.Name = "fieldValue1";
            // 
            // fieldMonth
            // 
            this.fieldMonth.AreaIndex = 0;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "Date";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.UnboundFieldName = "fieldMonth";
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "Date";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            // 
            // fieldValueP
            // 
            this.fieldValueP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValueP.AreaIndex = 1;
            this.fieldValueP.Caption = "%";
            this.fieldValueP.CellFormat.FormatString = "P";
            this.fieldValueP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldValueP.FieldName = "Value";
            this.fieldValueP.Name = "fieldValueP";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroup1.Location = new System.Drawing.Point(0, 0);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "None"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "% of Grand Total Row"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "% of Grand Total Column"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "% of Grand Total Cell")});
            this.radioGroup1.Size = new System.Drawing.Size(1074, 33);
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 529);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.radioGroup1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuarter;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValueP;
    }
}

