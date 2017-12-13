using System.Collections.Generic;

namespace Moedelo.Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>moedelo_page.csv - отчет со страницами</summary>
    public class DimensionsReportWithPages : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithPages()
        {
            var dimRange = new List<string>
                {
                    "ga:dimension11",    // N_view_page
                    "ga:dimension12",    // URL страницы
                    "ga:date"
                };

            var metricsRange = new List<string>
            {
                "ga:hits",              // количество хитов (везде будет равно 1) - правило для данного отчёта, остальные могут быть другие
                "ga:sessionDuration"    // длительность сессии
            };

            DimensionsSet.AddRange(dimRange);
            MetricsSet.AddRange(metricsRange);

            Filters = new List<string>
            {
                "ga:dimension11=~(^1$|^2$|^3$|^4$|^5$|^6$|^7$|^8$|^9$|^10$)"
            };

            Sort = new List<string>
            {
                "ga:dimension2",
                "ga:dimension12"
            };
        }
    }
}