using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using NLS.Common.LoggerServices;
using NLS.Common.LoggerServices.Interfaces;

namespace NLS.Common
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddCommonApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            try
            {
                LogManager.LoadConfiguration(string.Concat(AppDomain.CurrentDomain.BaseDirectory, "/nLog.config"));
                services.AddSingleton<IErrorLogger, ErrorLogger>();
                services.AddSingleton<IOperationalLogger, OperationalLogger>();
                return services;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
