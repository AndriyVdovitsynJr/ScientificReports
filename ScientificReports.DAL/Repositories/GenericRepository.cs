using Microsoft.EntityFrameworkCore;
using ScientificReports.DAL.Context;
using ScientificReports.Domain.Entities;

namespace ScientificReports.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> table;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            table = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await table.ToListAsync();
        }

        public TEntity GetById(int id)
        {
            return table.Find(id);
        }

        public void Add(TEntity obj)
        {
            table.Add(obj);
        }

        public void Update(TEntity obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            TEntity existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
