using System.Collections.Generic;

namespace Google.Analytics.Model.Ga.Dimensions
{
    public class DimensionsOne : DimensionsBase
    {
        public DimensionsOne()
        {
            DimensionsSet = new List<string>
                {
                    "ga:dimension1",    // client id
                    "ga:region",
                    "ga:browser",

                    //"ga:userGender",    //- не сопоставимы с конкретным пользователем из-за политики безопасности.
                    //"ga:userAgeBracket" //- не сопоставимы с конкретным пользователем из-за политики безопасности.
                };
        }
    }
}