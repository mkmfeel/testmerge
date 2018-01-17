using System.Collections.Generic;

namespace Google.Analytics.Model.Ga.Dimensions.UserActivity
{
    /// <summary>_conversions.csv - отчет с конверсиями</summary>
    public class DimensionsReportWithConversions : DimensionsBaseWithSessionMetrics
    {
        public DimensionsReportWithConversions()
        {
            var rangeMetrics = new List<string>
            {
                "ga:sessionDuration",       // длительность сессии
                "ga:goal1Completions",      // Заполнение реквизитов
                "ga:goal2Completions",      // Переход на страницу оплаты
                "ga:goal3Completions",      // Оплата
                "ga:pageviewsPerSession"    // Количество просмотренных страниц на сессию
            };
            MetricsSet.AddRange(rangeMetrics); 
        }
    }
}