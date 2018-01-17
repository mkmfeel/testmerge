using System;

namespace Google.Analytics.Model.UserAcitivityAnalytics
{
    public class ReportWithPaymentDate : BaseUserActivityReport
    {
        public DateTime PaymentDate { get; set; } // возможно значение def
    }
}