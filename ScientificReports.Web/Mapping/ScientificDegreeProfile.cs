using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScientificReports.BLL.Models;
using ScientificReports.Web.ViewModels;

namespace ScientificReports.Web.Mapping
{
    public class ScientificDegreeProfile : Profile
    {
        public ScientificDegreeProfile()
        {
            CreateMap<ScientificDegree, SelectListItem>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            ////////////////////////////////////////////////////
            CreateMap<ScientificDegreeViewModel, ScientificDegree>()
                .ReverseMap();
        }
    }
}
