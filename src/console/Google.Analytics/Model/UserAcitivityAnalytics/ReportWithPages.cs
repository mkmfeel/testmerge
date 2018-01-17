using System;

namespace Google.Analytics.Model.UserAcitivityAnalytics
{
    public class ReportWithPages : BaseUserActivityReport
    {
        private const int MaxUrlLength = 2500;
        private string _pageUrl;
        
        //Dimensions
        public int NumberViewPage { get; set; }

        public string PageUrl {
            get
            {
                return _pageUrl;
            }
            set { _pageUrl = value != null && value.Length > MaxUrlLength ? value.Substring(0, MaxUrlLength) : value ?? string.Empty; }
        }

        public DateTime Date { get; set; }

        //Metrics
        public int Hits { get; set; }

        public int SessionDuration { get; set; }
    }
}