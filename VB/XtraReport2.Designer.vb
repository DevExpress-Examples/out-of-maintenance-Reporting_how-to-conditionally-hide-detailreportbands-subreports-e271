Imports Microsoft.VisualBasic
Imports System
Namespace Rep3
	Partial Public Class XtraReport2
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.nwindDataSet1 = New Rep3.nwindDataSet()
			Me.categoriesTableAdapter = New Rep3.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
			Me.subReport1 = New Rep3.SubReport()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.subReport1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrSubreport1, Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel2})
			Me.Detail.Height = 164
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLine1
			' 
			Me.xrLine1.Location = New System.Drawing.Point(42, 158)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.Size = New System.Drawing.Size(567, 2)
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
			Me.xrPictureBox1.Location = New System.Drawing.Point(475, 17)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.Size = New System.Drawing.Size(133, 58)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel3.Location = New System.Drawing.Point(42, 50)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.Size = New System.Drawing.Size(308, 25)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel2.ForeColor = System.Drawing.Color.Blue
			Me.xrLabel2.Location = New System.Drawing.Point(42, 17)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseForeColor = False
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.PageHeader.Height = 53
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
			Me.xrLabel1.ForeColor = System.Drawing.Color.Red
			Me.xrLabel1.Location = New System.Drawing.Point(242, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(175, 42)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.Text = "Fall catalog"
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' xrSubreport1
			' 
			Me.xrSubreport1.Location = New System.Drawing.Point(42, 92)
			Me.xrSubreport1.Name = "xrSubreport1"
			Me.xrSubreport1.ReportSource = Me.subReport1
			Me.xrSubreport1.Size = New System.Drawing.Size(375, 50)
'			Me.xrSubreport1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrSubreport1_BeforePrint);
			' 
			' XtraReport2
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "8.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.subReport1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As Rep3.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
		Private subReport1 As SubReport
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
	End Class
End Namespace
