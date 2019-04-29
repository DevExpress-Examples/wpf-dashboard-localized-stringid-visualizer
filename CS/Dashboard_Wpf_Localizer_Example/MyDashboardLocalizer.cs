using DevExpress.DashboardCommon.Localization;
using System;

namespace Dashboard_Wpf_Localizer_Example
{
    public class MyDashboardLocalizer : DashboardLocalizer
    {
        public override string GetLocalizedString(DashboardStringId id)
        {
            return Enum.GetName(typeof(DashboardStringId), id);
        }
    }
}