<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061684/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3026)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication21/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication21/Form1.vb))
* [Program.cs](./CS/WindowsApplication21/Program.cs) (VB: [Program.vb](./VB/WindowsApplication21/Program.vb))
<!-- default file list end -->
# OBSOLETE - How to implement the Percent Of Grand Total summary display type.
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3026)**
<!-- run online end -->


<p>Update: Starting from version 11.2 it is possible to accomplish this task by setting the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_SummaryDisplayTypetopic"><u>PivotGridFieldBase.SummaryDisplayType</u></a> property to <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataPivotGridPivotSummaryDisplayTypeEnumtopic"><u>PercentOfGrandTotal</u></a>.</p><p>It is necessary to provide custom values manually, via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic"><u>PivotGridControl.CustomCellValue</u></a> event. To access a corresponding Grand Total cell, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetCellValuetopic"><u>object GetCellValue(Object[] columnValues, Object[] rowValues, PivotGridField dataField);</u></a> method is used.</p>

<br/>


