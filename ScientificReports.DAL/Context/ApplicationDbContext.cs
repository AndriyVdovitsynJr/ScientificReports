using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScientificReports.DAL.Models;
using ScientificReports.Domain.Entities;

namespace ScientificReports.DAL.Context
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<DataEntity> Datas { get; set; }

        public DbSet<CathedraEntity> Cathedras { get; set; }

        public DbSet<FacultyEntity> Faculties { get; set; }

        public DbSet<ScientificDegreeEntity> ScientificDegrees { get; set; }

        public DbSet<AcademicStatusEntity> AcademicStatuses { get; set; }
    }
}
