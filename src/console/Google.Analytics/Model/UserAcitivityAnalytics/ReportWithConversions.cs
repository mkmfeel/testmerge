namespace Google.Analytics.Model.UserAcitivityAnalytics
{
    public class ReportWithConversions : BaseUserActivityReport
    {
        //Metrics
        public int SessionDuration { get; set; }

        /// <summary>Заполнение реквизитов</summary>
        public int Goal1Completions { get; set; }

        /// <summary>Переход на страницу оплаты</summary>
        public int Goal2Completions { get; set; }

        /// <summary>Оплата</summary>
        public int Goal3Completions { get; set; }

        /// <summary>Количество просмотренных страниц на сессию</summary>
        public int PageviewsPerSession { get; set; }

    }
}