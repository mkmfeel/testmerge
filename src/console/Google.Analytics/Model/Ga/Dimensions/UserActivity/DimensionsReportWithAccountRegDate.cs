namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>_account_reg_date.csv</summary>
    public class DimensionsReportWithAccountRegDate : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithAccountRegDate()
        {
            DimensionsSet.Add("ga:dimension5"); // account_reg_date
        }
    }
}