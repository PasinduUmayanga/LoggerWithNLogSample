namespace NLS.Common.LoggerServices.Interfaces
{
    public interface IErrorLogger
    {
        void LogError(Exception ex, string message);
        void LogWarning(string message);
        void LogDebug(string message);
    }
}
