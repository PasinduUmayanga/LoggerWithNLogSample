using NLog;
using NLS.Common.LoggerServices.Interfaces;

namespace NLS.Common.LoggerServices
{
    public class ErrorLogger : IErrorLogger
    {
        private ILogger _logger = LogManager.GetLogger("ErrorLogger");
        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(Exception ex, string message = "")
        {
            LogEventInfo nlogEvent = LogEventInfo.Create(LogLevel.Error, _logger.Name.ToString(), ex, null, message, null);
            _logger.Log(typeof(ErrorLogger), nlogEvent);
        }

        public void LogWarning(string message)
        {
            _logger.Warn(message);
        }
    }
}
