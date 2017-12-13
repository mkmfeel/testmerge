using System;
using System.Configuration;
using System.IO;

namespace Google.Analytics.Utils
{
    internal static class FileLogger
    {
        static readonly string PathFileLogger = ConfigurationManager.AppSettings["PathFileLogger"];

        internal static void WriteExceptionLine(Exception ex)
        {
            var exLine = ex.ToString();
            exLine = string.Concat("ErrorException: ", exLine);

            WriteLine(exLine);
        }

        internal static void WriteLine(string line)
        {
            File.AppendAllText(PathFileLogger, PatchTimeAndNewLine(line));
        }

        private static string PatchTimeAndNewLine(string line)
        {
            return string.Format("{0} {1}{2}", line, DateTime.Now.ToString("s"), Environment.NewLine);
        }
    }
}