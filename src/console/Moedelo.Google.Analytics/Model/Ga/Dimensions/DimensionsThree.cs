using System.Collections.Generic;

namespace Moedelo.Google.Analytics.Model.Ga.Dimensions
{
    public class DimensionsThree : DimensionsBase
    {
        public DimensionsThree()
        {
            DimensionsSet = new List<string>
                {
                    "ga:dimension2",     //session id
                    "ga:source",
                    "ga:medium",
                    "ga:campaign",
                    "ga:keyword"
                };
        }
    }
}