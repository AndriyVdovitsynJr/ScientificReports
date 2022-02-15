using AutoMapper;
using ScientificReports.BLL.Models;
using ScientificReports.DAL.Repositories;
using ScientificReports.Domain.Entities;

namespace ScientificReports.BLL.Services
{
    public class BaseCrudService<TEntity, TModel> : IBaseCrudService<TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        protected readonly IGenericRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public BaseCrudService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            var res = await _repository.GetAll();
            return _mapper.Map<IEnumerable<TModel>>(res);
        }

        public TModel GetById(int id)
        {
            var res = _repository.GetById(id);
            return _mapper.Map<TModel>(res);
        }

        public void Add(TModel obj)
        {
            var dataViewModel = _mapper.Map<TEntity>(obj);
            _repository.Add(dataViewModel);
        }

        public void Update(TModel obj)
        {
            var dataViewModel = _mapper.Map<TEntity>(obj);
            _repository.Update(dataViewModel);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Save()
        {
            _repository.Save();
        }
    }
}
