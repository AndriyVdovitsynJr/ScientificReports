using AutoMapper;
using ScientificReports.BLL.Models;
using ScientificReports.Domain.Entities;

namespace ScientificReports.BLL.Mapping
{
    public class ScientificDegreeProfile : Profile
    {
        public ScientificDegreeProfile()
        {
            CreateMap<ScientificDegreeEntity, ScientificDegree>()
                .ReverseMap();
        }
    }
}
