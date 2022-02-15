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

        public DbSet<ScientificDegreeEntity> ScientificDegreeEntity { get; set; }

        public DbSet<AcademicStatusEntity> AcademicStatusEntity { get; set; }
    }
}
