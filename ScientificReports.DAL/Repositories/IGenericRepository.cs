using ScientificReports.Domain.Entities;

namespace ScientificReports.DAL.Repositories
{
    public interface IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAll();

        TEntity GetById(int id);

        void Add(TEntity obj);

        void Update(TEntity obj);

        void Delete(int id);

        void Save();
    }
}
