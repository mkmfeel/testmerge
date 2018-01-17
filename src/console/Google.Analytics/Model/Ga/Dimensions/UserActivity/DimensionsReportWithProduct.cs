namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>_product.csv</summary>
    public class DimensionsReportWithProduct : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithProduct()
        {
            DimensionsSet.Add("ga:dimension7"); // product
        }
    }
}