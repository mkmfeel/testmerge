using System.Collections.Generic;

namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    public class DimensionsBaseWithSessionMetrics : DimensionsBase
    {
        public DimensionsBaseWithSessionMetrics()
        {
            DimensionsSet = new List<string>
            {
                "ga:dimension2",     // session id
            };

            MetricsSet = new List<string>
            {
                "ga:sessions"       // сессии
            };
        } 
    }
}