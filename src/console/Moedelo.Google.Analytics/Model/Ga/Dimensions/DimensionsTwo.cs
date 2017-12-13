using System.Collections.Generic;

namespace Moedelo.Google.Analytics.Model.Ga.Dimensions
{
    public class DimensionsTwo : DimensionsBase
    {
        public DimensionsTwo()
        {
            DimensionsSet = new List<string>
                {
                    "ga:dimension2",     //session id
                    "ga:dimension1",    // client id
                    "ga:date" //dateHour
                };

            MetricsSet = new List<string>
            {
                "ga:visits",
                "ga:goal11Completions"
            };

        }
    }
}