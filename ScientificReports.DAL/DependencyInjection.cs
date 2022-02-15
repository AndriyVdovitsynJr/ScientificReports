using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScientificReports.DAL.Extensions;

namespace ScientificReports.DAL
{
    public static class DependencyInjection
    {
        public static void AddScientificReportsDAL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddContext(configuration);
            services.AddRepositories();
        }
    }
}
