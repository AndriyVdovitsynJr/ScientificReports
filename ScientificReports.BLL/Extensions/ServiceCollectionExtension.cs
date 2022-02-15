using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ScientificReports.BLL.Models;
using ScientificReports.BLL.Services;
using ScientificReports.Domain.Entities;

namespace ScientificReports.BLL.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddBaseCrudServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseCrudService<Cathedra>, BaseCrudService<CathedraEntity, Cathedra>>();
            services.AddScoped<IBaseCrudService<Faculty>, BaseCrudService<FacultyEntity, Faculty>>();
            services.AddScoped<IBaseCrudService<ScientificDegree>, BaseCrudService<ScientificDegreeEntity, ScientificDegree>>();
            services.AddScoped<IBaseCrudService<AcademicStatus>, BaseCrudService<AcademicStatusEntity, AcademicStatus>>();
        }

        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(DependencyInjection)));
        }
    }
}
