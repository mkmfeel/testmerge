namespace Moedelo.Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>moedelo_company_id.csv - отчет по кампании</summary>
    public class DimensionsReportWithCompanyId : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithCompanyId()
        {
            DimensionsSet.Add("ga:dimension4"); // company_id
        }
    }
}