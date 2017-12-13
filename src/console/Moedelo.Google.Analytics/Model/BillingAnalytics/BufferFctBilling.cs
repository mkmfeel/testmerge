using System;

namespace Moedelo.Google.Analytics.Model.BillingAnalytics
{
    public class BufferFctBilling
    {
        private DateTime? _svcRegDate;
        private DateTime? _sfLoadDate;
        private DateTime? _payDate;

        public string GoogleAnalyticId { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmTerm { get; set; }
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public int QualityGroup { get; set; }
        public int IsLiquid { get; set; }
        public int Liquidity { get; set; }
        public string RegStatus { get; set; }
        public string Region { get; set; }
        public string TrialTariff { get; set; }
        public string PaidTariff { get; set; }
        public int? PaySum { get; set; }
        public string PromoCode { get; set; }
        public string TrialCard { get; set; }
        public int? PaymentHistoryId { get; set; }
        public string Login { get; set; }

        public string SvcRegDate
        {
            get { return _svcRegDate.HasValue ? _svcRegDate.Value.ToShortDateString() : null; }

            set { _svcRegDate = DateTime.Parse(value); }
        }

        public string SfLoadDate
        {
            get { return _sfLoadDate.HasValue ? _sfLoadDate.Value.ToShortDateString() : null; }
            set { _sfLoadDate = DateTime.Parse(value); }
        }

        public string PayDate
        {
            get { return _payDate.HasValue ? _payDate.Value.ToShortDateString() : null; }
            set { _payDate = DateTime.Parse(value); }
        }
    }
}