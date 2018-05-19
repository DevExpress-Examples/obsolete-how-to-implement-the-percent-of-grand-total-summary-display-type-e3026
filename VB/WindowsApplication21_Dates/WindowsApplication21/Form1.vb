Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication21
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			FillDataSource(New DateTime(2010, 1, 1), New DateTime(2011, 12, 31))

		End Sub

		Private Sub FillDataSource(ByVal beginDate As DateTime, ByVal endDate As DateTime)
			Dim dt As DataTable = dataSet1.Tables("Data")
			Dim i As Integer = 0
			Dim d As DateTime = beginDate
			Do While d <= endDate
				dt.Rows.Add(New Object() { "Name " & i Mod 3, "Type " & i Mod 2, d, i })
				i += 1
				d = d.AddDays(3)
			Loop
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pivotGridControl1.BestFit()
		End Sub

		Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) Handles pivotGridControl1.CustomCellValue
			If ReferenceEquals(e.DataField, fieldValueP) Then
				If (Not ShouldCalculatePercentage()) Then
					e.Value = String.Empty
					Return
				End If
				Dim rowFieldValues() As Object
				If ShouldCollectRowValues() Then
					rowFieldValues = GetRowFieldValues(e)
				Else
					rowFieldValues = New Object(){}
				End If
				Dim columnFieldValues() As Object
				If ShouldCollectColumnValues() Then
					columnFieldValues = GetColumnFieldValues(e)
				Else
					columnFieldValues = New Object(){}
				End If
				Dim currentValue As Decimal = Convert.ToDecimal(e.Value)
				Dim grandTotalValue As Decimal = Convert.ToDecimal(e.GetCellValue(columnFieldValues, rowFieldValues, e.DataField))

				e.Value = currentValue / grandTotalValue
			End If

		End Sub



		Private Function GetRowFieldValues(ByVal e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) As Object()
			Dim values As New List(Of Object)()
			For Each field As PivotGridField In e.GetRowFields()
				values.Add(e.GetFieldValue(field))
			Next field
			Return values.ToArray()
		End Function

		Private Function GetColumnFieldValues(ByVal e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) As Object()
			Dim values As New List(Of Object)()
			For Each field As PivotGridField In e.GetColumnFields()
				values.Add(e.GetFieldValue(field))
			Next field
			Return values.ToArray()
		End Function

		Private Function ShouldCollectRowValues() As Boolean
			If radioGroup1.SelectedIndex = 2 Then
				Return True
			End If
			Return False
		End Function

		Private Function ShouldCollectColumnValues() As Boolean
			If radioGroup1.SelectedIndex = 1 Then
				Return True
			End If
			Return False
		End Function

		Private Function ShouldCalculatePercentage() As Boolean
			If radioGroup1.SelectedIndex = 0 Then
				Return False
			End If
			Return True
		End Function

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()
		End Sub





	End Class
End Namespace