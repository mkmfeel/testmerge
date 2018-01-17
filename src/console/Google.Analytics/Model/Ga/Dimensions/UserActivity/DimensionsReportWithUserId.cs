namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>_user_id.csv - отчет по пользователю</summary>
    public class DimensionsReportWithUserId : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithUserId()
        {
            DimensionsSet.Add("ga:dimension3"); // user_id
        }
    }
}