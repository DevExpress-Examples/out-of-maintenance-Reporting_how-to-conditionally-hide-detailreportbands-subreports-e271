Imports Microsoft.VisualBasic
Imports System
Namespace Rep3
	Partial Public Class XtraReport1
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
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.nwindDataSet1 = New Rep3.nwindDataSet()
			Me.categoriesTableAdapter = New Rep3.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.productsTableAdapter = New Rep3.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel2})
			Me.Detail.Height = 92
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
			Me.xrPictureBox1.Location = New System.Drawing.Point(500, 0)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.Size = New System.Drawing.Size(133, 58)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel3.Location = New System.Drawing.Point(67, 33)
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
			Me.xrLabel2.Location = New System.Drawing.Point(67, 0)
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
			Me.PageHeader.Height = 65
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
			Me.xrLabel1.ForeColor = System.Drawing.Color.Red
			Me.xrLabel1.Location = New System.Drawing.Point(258, 17)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(175, 42)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.Text = "Fall catalog"
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.PageFooter.Height = 58
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.Format = "Page {0} of {1}"
			Me.xrPageInfo1.Location = New System.Drawing.Point(550, 17)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.Size = New System.Drawing.Size(100, 25)
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
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1})
			Me.DetailReport.DataAdapter = Me.productsTableAdapter
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.nwindDataSet1
			Me.DetailReport.Name = "DetailReport"
'			Me.DetailReport.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.DetailReport_BeforePrint);
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail1.Height = 67
			Me.Detail1.Name = "Detail1"
			' 
			' xrTable2
			' 
			Me.xrTable2.Location = New System.Drawing.Point(50, 0)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.Size = New System.Drawing.Size(575, 67)
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell7, Me.xrTableCell6})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Size = New System.Drawing.Size(575, 67)
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName", "")})
			Me.xrTableCell4.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell4.Size = New System.Drawing.Size(150, 67)
			Me.xrTableCell4.Text = "xrTableCell4"
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.QuantityPerUnit", "")})
			Me.xrTableCell5.Location = New System.Drawing.Point(150, 0)
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell5.Size = New System.Drawing.Size(159, 67)
			Me.xrTableCell5.Text = "xrTableCell5"
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock", "")})
			Me.xrTableCell7.Location = New System.Drawing.Point(309, 0)
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell7.Size = New System.Drawing.Size(151, 67)
			Me.xrTableCell7.Text = "xrTableCell7"
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "")})
			Me.xrTableCell6.Location = New System.Drawing.Point(460, 0)
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell6.Size = New System.Drawing.Size(115, 67)
			Me.xrTableCell6.Text = "xrTableCell6"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.Height = 42
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.RepeatEveryPage = True
			' 
			' xrTable1
			' 
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 16F)
			Me.xrTable1.Location = New System.Drawing.Point(50, 0)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.Size = New System.Drawing.Size(575, 42)
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseFont = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell8, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Size = New System.Drawing.Size(575, 42)
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell1.Size = New System.Drawing.Size(149, 42)
			Me.xrTableCell1.Text = "Product name"
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Location = New System.Drawing.Point(149, 0)
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell2.Size = New System.Drawing.Size(159, 42)
			Me.xrTableCell2.Text = "Quantint per unit"
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Location = New System.Drawing.Point(308, 0)
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell8.Size = New System.Drawing.Size(150, 42)
			Me.xrTableCell8.Text = "Units in stock"
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Location = New System.Drawing.Point(458, 0)
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell3.Size = New System.Drawing.Size(117, 42)
			Me.xrTableCell3.Text = "Unit price"
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' xrLine1
			' 
			Me.xrLine1.Location = New System.Drawing.Point(67, 67)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.Size = New System.Drawing.Size(567, 25)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.DetailReport})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "8.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As Rep3.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private productsTableAdapter As Rep3.nwindDataSetTableAdapters.ProductsTableAdapter
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
	End Class
End Namespace
