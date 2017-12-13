using System;
using Moedelo.Infrastructure.Common.Extensions;
using Moedelo.Infrastructure.Logging;

namespace Moedelo.Google.Analytics.Infrastructure
{
    internal static class ConsoleConfigurations
    {
        static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        internal static DateTime DateRequest { get; set; }

        internal static int DaysBefore { get; set; } = -3;

        internal static bool EnableDefaultMethods { get; set; }

        internal static bool EnableUserActivity { get; set; }

        public static void Initialize(string[] args)
        {
            try
            {
                if (args.Length > 0 && args[0].Equals("userActivity", StringComparison.CurrentCultureIgnoreCase))
                {
                    EnableUserActivity = true;
                    DaysBefore = -2;
                }
                else
                {
                    EnableDefaultMethods = true;
                }

                DateRequest = args.Length == 2 ? DateTime.Parse(args[1]) : DateTime.Now;
            }
            catch (Exception ex)
            {
                Logger.Error($"Bad args:{args.ToJsonString()}, ex:{ex.Message}", null, ex);
                throw;
            }
        }
    }
}