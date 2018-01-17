namespace Google.Analytics.Model.UserAcitivityAnalytics
{
    public class ReportWithUserId : BaseUserActivityReport
    {
        //Dimensions
        public int UserId { get; set; } // отчёт может возвращать значение def для UserId
    }
}