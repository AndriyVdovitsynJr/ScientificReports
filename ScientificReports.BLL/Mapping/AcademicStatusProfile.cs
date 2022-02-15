using AutoMapper;
using ScientificReports.BLL.Models;
using ScientificReports.Domain.Entities;

namespace ScientificReports.BLL.Mapping
{
    public class AcademicStatusProfile : Profile
    {
        public AcademicStatusProfile()
        {
            CreateMap<AcademicStatusEntity, AcademicStatus>()
                .ReverseMap();
        }
    }
}
