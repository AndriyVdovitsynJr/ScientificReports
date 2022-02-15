using AutoMapper;
using ScientificReports.BLL.Models;
using ScientificReports.Domain.Entities;

namespace ScientificReports.BLL.Mapping
{
    public class FacultyProfile : Profile
    {
        public FacultyProfile()
        {
            CreateMap<FacultyEntity, Faculty>()
                .ReverseMap();
        }
    }
}
