Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace Rep3
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DetailReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DetailReport.BeforePrint
			Dim i As Integer = Convert.ToInt32(Me.GetCurrentColumnValue("CategoryID"))
			If i Mod 2 = 1 Then
				e.Cancel = True
			End If
		End Sub

	End Class
End Namespace
