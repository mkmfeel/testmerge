using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Google.Analytics.Model.UserAcitivityAnalytics;

namespace Google.Analytics.Mapping
{
    public static class UserActivityMapper
    {
        public static List<ReportWithPages> MapReportiWithPageses(IList<IList<string>> analyticsReportWithPages)
        {
            return analyticsReportWithPages?.Select(gaEntity => new ReportWithPages
            {
                SessionId = gaEntity[0],
                NumberViewPage = int.Parse(gaEntity[1]),
                PageUrl = gaEntity[2],
                Date = ParseGoogleDate(gaEntity[3]),
                Sessions = int.Parse(gaEntity[4]),
                Hits = int.Parse(gaEntity[5]),
                SessionDuration = ParseIntWithDelimiter(gaEntity[6])
            }).ToList();
        }

        public static List<ReportWithConversions> MapReportWithConversions(IList<IList<string>> analyticsReportWithConversions)
        {
            return analyticsReportWithConversions?.Select(gaEntity => new ReportWithConversions
            {
                SessionId = gaEntity[0],
                Sessions = int.Parse(gaEntity[1]),
                SessionDuration = ParseIntWithDelimiter(gaEntity[2]),
                Goal1Completions = int.Parse(gaEntity[3]),
                Goal2Completions = int.Parse(gaEntity[4]),
                Goal3Completions = int.Parse(gaEntity[5]),
                PageviewsPerSession = ParseIntWithDelimiter(gaEntity[6])
            }).ToList();
        }

        public static List<ReportWithUserId> MapReportWithUserId(IList<IList<string>> analyticsReportWithUserId)
        {
            return analyticsReportWithUserId?.Select(gaEntity => new ReportWithUserId
            {
                SessionId = gaEntity[0],
                UserId = TryParseInt(gaEntity[1]),
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        public static List<ReportWithCompanyId> MapReportWithCompaynyId(IList<IList<string>> analyticsReportWithCompaynyId)
        {
            return analyticsReportWithCompaynyId?.Select(gaEntity => new ReportWithCompanyId
            {
                SessionId = gaEntity[0],
                CompanyId = TryParseInt(gaEntity[1]),
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        public static List<ReportWithAccountRegDate> MapReportWithAccountRegDate(IList<IList<string>> analyticsReportWithAccountRegDate)
        {
            return analyticsReportWithAccountRegDate?.Select(gaEntity => new ReportWithAccountRegDate
            {
                SessionId = gaEntity[0],
                AccountRegDate = ParseDate(gaEntity[1]),
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        public static List<ReportWithProduct> MapReportWithProduct(IList<IList<string>> analyticsReportWithProduct)
        {
            return analyticsReportWithProduct?.Select(gaEntity => new ReportWithProduct
            {
                SessionId = gaEntity[0],
                Product = gaEntity[1],
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        public static List<ReportWithTariff> MapReportWithTariff(IList<IList<string>> analyticsReportWithTariff)
        {
            return analyticsReportWithTariff?.Select(gaEntity => new ReportWithTariff
            {
                SessionId = gaEntity[0],
                TariffId = TryParseInt(gaEntity[1]),
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        public static List<ReportWithEmployees> MapReportWithEmployees(IList<IList<string>> analyticsReportWithEmployees)
        {
            return analyticsReportWithEmployees?.Select(gaEntity => new ReportWithEmployees
            {
                SessionId = gaEntity[0],
                Employyes = TryParseInt(gaEntity[1]),
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        public static List<ReportWithPaymentDate> MapReportWithPaymentDate(IList<IList<string>> analyticsReportWithPaymentDate)
        {
            return analyticsReportWithPaymentDate?.Select(gaEntity => new ReportWithPaymentDate
            {
                SessionId = gaEntity[0],
                PaymentDate = ParseDate(gaEntity[1]),
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        public static List<ReportWithSessionType> MapReportWithSessionType(IList<IList<string>> analyticsReportWithSessionType)
        {
            return analyticsReportWithSessionType?.Select(gaEntity => new ReportWithSessionType
            {
                SessionId = gaEntity[0],
                SessionType = gaEntity[1],
                Sessions = int.Parse(gaEntity[2])
            }).ToList();
        }

        private static DateTime ParseGoogleDate(string input)
        {
            try
            {
                return DateTime.ParseExact(input, "yyyyMMdd", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return new DateTime(1753, 1, 1);
            }
        }

        private static DateTime ParseDate(string input)
        {
            try
            {
                return DateTime.Parse(input);
            }
            catch (Exception)
            {
                return new DateTime(1753, 1, 1);
            }
        }

        /// <param name="input">Строка вида 718.0</param>
        private static int ParseIntWithDelimiter(string input)
        {
            try
            {
                var startIndex = input.IndexOf(".", StringComparison.InvariantCulture);
                return startIndex > -1 ? int.Parse(input.Substring(0, startIndex)) : int.Parse(input);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private static int TryParseInt(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}