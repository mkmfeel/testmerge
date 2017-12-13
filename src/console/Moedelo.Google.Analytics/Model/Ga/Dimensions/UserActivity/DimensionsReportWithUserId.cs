namespace Moedelo.Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>moedelo_user_id.csv - отчет по пользователю</summary>
    public class DimensionsReportWithUserId : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithUserId()
        {
            DimensionsSet.Add("ga:dimension3"); // user_id
        }
    }
}