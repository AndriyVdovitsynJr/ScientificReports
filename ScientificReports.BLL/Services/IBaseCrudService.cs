using ScientificReports.BLL.Models;

namespace ScientificReports.BLL.Services
{
    public interface IBaseCrudService<TModel>
        where TModel : BaseModel
    {
        Task<IEnumerable<TModel>> GetAll();

        TModel GetById(int id);

        void Add(TModel obj);

        void Update(TModel obj);

        void Delete(int id);

        void Save();
    }
}
