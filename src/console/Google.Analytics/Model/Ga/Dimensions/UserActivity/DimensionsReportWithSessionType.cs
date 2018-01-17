namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>_session_type.csv</summary>
    public class DimensionsReportWithSessionType : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithSessionType()
        {
            DimensionsSet.Add("ga:dimension6"); // session_type
        }
    }
}