Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace Rep3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim rp1 As New XtraReport1()

			CType(New ReportPrintTool(rp1), ReportPrintTool).ShowPreviewDialog()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Dim rp2 As New XtraReport2()

			CType(New ReportPrintTool(rp2), ReportPrintTool).ShowPreviewDialog()
		End Sub
	End Class
End Namespace