using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScientificReports.BLL.Models;
using ScientificReports.Web.ViewModels;

namespace ScientificReports.Web.Mapping
{
    public class AcademicStatusProfile : Profile
    {
        public AcademicStatusProfile()
        {
            CreateMap<AcademicStatus, SelectListItem>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<AcademicStatusViewModel, AcademicStatus>()
                .ReverseMap();
        }
    }
}
