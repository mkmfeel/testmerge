namespace Moedelo.Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>moedelo_payment_date.csv</summary>
    public class DimensionsReportWithPaymentDate : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithPaymentDate()
        {
            DimensionsSet.Add("ga:dimension10"); // payment_date
        }
    }
}