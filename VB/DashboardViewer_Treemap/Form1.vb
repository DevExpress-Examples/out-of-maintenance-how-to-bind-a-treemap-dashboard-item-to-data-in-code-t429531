Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors

Namespace DashboardViewer_Treemap
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()

			Dim dashboard As New Dashboard()
			Dim dataSource As New DashboardExtractDataSource()
			dataSource.FileName = "..\..\Data\SalesDataExtract.dat"
			dashboard.DataSources.Add(dataSource)

			Dim treeMap As New TreemapDashboardItem()
			treeMap.DataSource = dataSource
			treeMap.Values.Add(New Measure("Sales"))
			treeMap.Arguments.Add(New Dimension With {.DataMember = "Product Category", .GroupChildValues = True})
			treeMap.Arguments.Add(New Dimension("Product Sub-Category"))
			treeMap.LayoutAlgorithm = DashboardTreemapLayoutAlgorithm.Striped

			dashboard.Items.Add(treeMap)
			dashboardViewer1.Dashboard = dashboard
		End Sub
	End Class
End Namespace
