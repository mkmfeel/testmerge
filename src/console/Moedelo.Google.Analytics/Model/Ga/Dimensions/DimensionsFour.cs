using System.Collections.Generic;

namespace Moedelo.Google.Analytics.Model.Ga.Dimensions
{
    public class DimensionsFour : DimensionsBase
    {
        public DimensionsFour()
        {
            DimensionsSet = new List<string>
                {
                    "ga:dimension2",     //session id
                    "ga:landingPagePath",
                    "ga:exitPagePath",
                    "ga:eventAction"
                };
        }
    }
}