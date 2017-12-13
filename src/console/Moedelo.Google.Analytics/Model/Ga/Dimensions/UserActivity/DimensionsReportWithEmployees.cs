namespace Moedelo.Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>moedelo_employees.csv</summary>
    public class DimensionsReportWithEmployees : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithEmployees()
        {
            DimensionsSet.Add("ga:dimension9"); // employees
        }
    }
}