Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace Rep3
	Partial Public Class SubReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private catid As Integer

		Public Property CategoryID() As Integer
			Get
				Return catid
			End Get
			Set(ByVal value As Integer)
				catid= value
			End Set
		End Property

		Private Sub SubReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
			Me.productsTableAdapter.FillBy(nwindDataSet1.Products, CType(CategoryID, Integer?))
		End Sub

	End Class
End Namespace
