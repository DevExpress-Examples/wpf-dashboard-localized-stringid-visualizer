Imports DevExpress.DashboardCommon.Localization
Imports System

Namespace Dashboard_Wpf_Localizer_Example
	Public Class MyDashboardLocalizer
		Inherits DashboardLocalizer

		Public Overrides Function GetLocalizedString(ByVal id As DashboardStringId) As String
			Return System.Enum.GetName(GetType(DashboardStringId), id)
		End Function
	End Class
End Namespace