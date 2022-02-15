using Microsoft.Extensions.DependencyInjection;
using ScientificReports.BLL.Extensions;

namespace ScientificReports.BLL
{
    public static class DependencyInjection
    {
        public static void AddScientificReportsBLL(this IServiceCollection services)
        {
            services.AddBaseCrudServices();
            services.AddMapping();
        }
    }
}
