namespace Moedelo.Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>moedelo_product.csv</summary>
    public class DimensionsReportWithProduct : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithProduct()
        {
            DimensionsSet.Add("ga:dimension7"); // product
        }
    }
}