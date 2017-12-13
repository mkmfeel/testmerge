using System;

namespace Moedelo.Google.Analytics.Model.UserAcitivityAnalytics
{
    public class ReportWithAccountRegDate: BaseUserActivityReport
    {
        //Dimensions
        public DateTime AccountRegDate { get; set; }
    }
}