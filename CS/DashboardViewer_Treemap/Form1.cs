using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;

namespace DashboardViewer_Treemap {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();

            Dashboard dashboard = new Dashboard();
            DashboardExtractDataSource dataSource = new DashboardExtractDataSource();
            dataSource.FileName = @"..\..\Data\SalesDataExtract.dat";
            dashboard.DataSources.Add(dataSource);
            
            TreemapDashboardItem treeMap = new TreemapDashboardItem();
            treeMap.DataSource = dataSource;
            treeMap.Values.Add(new Measure("Sales"));            
            treeMap.Arguments.Add(new Dimension {
                DataMember = "Product Category",
                GroupChildValues = true });
            treeMap.Arguments.Add(new Dimension("Product Sub-Category"));
            treeMap.LayoutAlgorithm = DashboardTreemapLayoutAlgorithm.Striped;

            dashboard.Items.Add(treeMap);
            dashboardViewer1.Dashboard = dashboard;
        }
    }
}
