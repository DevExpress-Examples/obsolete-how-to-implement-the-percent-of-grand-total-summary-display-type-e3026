# OBSOLETE - How to implement the Percent Of Grand Total summary display type.


<p>Update: Starting from version 11.2 it is possible to accomplish this task by setting the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_SummaryDisplayTypetopic"><u>PivotGridFieldBase.SummaryDisplayType</u></a> property to <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataPivotGridPivotSummaryDisplayTypeEnumtopic"><u>PercentOfGrandTotal</u></a>.</p><p>It is necessary to provide custom values manually, via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic"><u>PivotGridControl.CustomCellValue</u></a> event. To access a corresponding Grand Total cell, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetCellValuetopic"><u>object GetCellValue(Object[] columnValues, Object[] rowValues, PivotGridField dataField);</u></a> method is used.</p>

<br/>


