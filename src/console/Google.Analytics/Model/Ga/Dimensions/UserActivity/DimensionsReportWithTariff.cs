﻿namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>_tariff_id.csv</summary>
    public class DimensionsReportWithTariff : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithTariff()
        {
            DimensionsSet.Add("ga:dimension8"); // tariff_id
        } 
    }
}