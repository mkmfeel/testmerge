using System;

namespace Google.Analytics.Model.UserAcitivityAnalytics
{
    public class ReportWithAccountRegDate: BaseUserActivityReport
    {
        //Dimensions
        public DateTime AccountRegDate { get; set; }
    }
}