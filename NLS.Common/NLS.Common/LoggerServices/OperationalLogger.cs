using NLog;
using NLS.Common.LoggerServices.Interfaces;

namespace NLS.Common.LoggerServices
{
    public class OperationalLogger : IOperationalLogger
    {
        private ILogger _logger = LogManager.GetLogger("OperationalLogger");

        public void LogInfo(string message = "")
        {
            LogEventInfo nlogEvent = LogEventInfo.Create(LogLevel.Info, _logger.Name.ToString(), message);
            _logger.Log(typeof(OperationalLogger), nlogEvent);
        }
    }
}
