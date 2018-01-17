namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>_company_id.csv - отчет по кампании</summary>
    public class DimensionsReportWithCompanyId : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithCompanyId()
        {
            DimensionsSet.Add("ga:dimension4"); // company_id
        }
    }
}