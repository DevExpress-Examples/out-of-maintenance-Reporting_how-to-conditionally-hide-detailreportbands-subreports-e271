Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace Rep3
	Partial Public Class XtraReport2
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
			' Create the detail report 
			Dim reportProducts As SubReport = TryCast(xrSubreport1.ReportSource, SubReport)

			' Pass the CategoryID parameter from the master report.
			reportProducts.CategoryID = CInt(Fix(Me.GetCurrentColumnValue("CategoryID")))

			If reportProducts.CategoryID Mod 2 = 1 Then
				e.Cancel = True
			End If

		End Sub

	End Class
End Namespace
