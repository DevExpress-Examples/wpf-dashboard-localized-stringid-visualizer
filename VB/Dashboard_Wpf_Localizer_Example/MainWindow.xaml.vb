Imports DevExpress.DashboardCommon.Localization
Imports DevExpress.Xpf.Core

Namespace Dashboard_Wpf_Localizer_Example
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits ThemedWindow

		Public Sub New()
			DashboardLocalizer.Active = New MyDashboardLocalizer()
			InitializeComponent()
		End Sub
	End Class
End Namespace
