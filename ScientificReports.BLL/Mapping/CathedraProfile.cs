using AutoMapper;
using ScientificReports.BLL.Models;
using ScientificReports.Domain.Entities;

namespace ScientificReports.BLL.Mapping
{
    public class CathedraProfile : Profile
    {
        public CathedraProfile()
        {
            CreateMap<CathedraEntity, Cathedra>()
                .ReverseMap();
        }
    }
}
