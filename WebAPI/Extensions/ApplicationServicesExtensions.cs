using Application.Interfaces;
using Infrastructure.Respositories;

namespace WebAPI.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUsageTracker, UsageTracker>();
            services.AddScoped<IValidateRequest, ValidateRequest>();
            services.AddScoped<ITracker, Tracker>();

            return services;
        }
    }
}
