using DevExpress.DashboardCommon.Localization;
using DevExpress.Xpf.Core;

namespace Dashboard_Wpf_Localizer_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            DashboardLocalizer.Active = new MyDashboardLocalizer();
            InitializeComponent();
        }
    }
}
