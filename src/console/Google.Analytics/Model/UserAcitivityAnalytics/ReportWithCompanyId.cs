namespace Google.Analytics.Model.UserAcitivityAnalytics
{
    public class ReportWithCompanyId : BaseUserActivityReport
    {
        //Dimensions
        public int CompanyId { get; set; } // отчёт может возвращать значение def для CompanyId
    }
}