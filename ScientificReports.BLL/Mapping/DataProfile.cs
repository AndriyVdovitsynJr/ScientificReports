using AutoMapper;
using ScientificReports.BLL.Models;
using ScientificReports.Domain.Entities;

namespace ScientificReports.BLL.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<DataModel, DataEntity>().ReverseMap();
        }
    }
}
