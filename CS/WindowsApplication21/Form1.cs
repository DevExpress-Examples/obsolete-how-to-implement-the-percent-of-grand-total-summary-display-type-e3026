using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillDataSource(new DateTime(2010, 1, 1), new DateTime(2011, 12, 31));
            
        }

        private void FillDataSource(DateTime beginDate, DateTime endDate)
        {
            DataTable dt = dataSet1.Tables["Data"];
            int i = 0;
            for (DateTime d = beginDate ; d <= endDate; d = d.AddDays(3))
            {
                dt.Rows.Add(new object[] { "Name " + i % 3, "Type " + i % 2, d, i });
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pivotGridControl1.BestFit();
        }

        private void pivotGridControl1_CustomCellValue(object sender, DevExpress.XtraPivotGrid.PivotCellValueEventArgs e)
        {
            if (ReferenceEquals(e.DataField, fieldValueP))
            {
                if (!ShouldCalculatePercentage())
                {
                    e.Value = string.Empty;
                    return;
                }
                object[] rowFieldValues;
                if (ShouldCollectRowValues())
                    rowFieldValues = GetRowFieldValues(e);
                else
                    rowFieldValues = new object[0];
                object[] columnFieldValues;
                if (ShouldCollectColumnValues())
                    columnFieldValues = GetColumnFieldValues(e);
                else
                    columnFieldValues = new object[0];
                decimal currentValue = Convert.ToDecimal(e.Value);
                decimal grandTotalValue = Convert.ToDecimal(e.GetCellValue( columnFieldValues, rowFieldValues, e.DataField ));

                e.Value = currentValue / grandTotalValue ; 
            }

        }



        private object[] GetRowFieldValues(DevExpress.XtraPivotGrid.PivotCellValueEventArgs e)
        {
            List<object> values = new List<object>();
            foreach (PivotGridField field in e.GetRowFields() )
            {
                values.Add(e.GetFieldValue(field));
            }
            return values.ToArray();
        }

        private object[] GetColumnFieldValues(DevExpress.XtraPivotGrid.PivotCellValueEventArgs e)
        {
            List<object> values = new List<object>();
            foreach (PivotGridField field in e.GetColumnFields()  )
            {
                values.Add(e.GetFieldValue(field));
            }
            return values.ToArray();
        }

        private bool ShouldCollectRowValues()
        {
            if (radioGroup1.SelectedIndex == 2)
                return true;
            return false;
        }

        private bool ShouldCollectColumnValues()
        {
            if (radioGroup1.SelectedIndex == 1)
                return true;
            return false;
        }

        private bool ShouldCalculatePercentage()
        {
            if (radioGroup1.SelectedIndex == 0) 
                return false;
            return true;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
        }





    }
}