using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScientificReports.BLL.Models;
using ScientificReports.Domain.Entities;
using ScientificReports.Web.ViewModels;

namespace ScientificReports.Web.Mapping
{
    public class CathedraProfile : Profile
    {
        public CathedraProfile()
        {
            CreateMap<Cathedra, SelectListItem>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            ////////////////////////////////////////////////////
            CreateMap<CathedraViewModel, Cathedra>()
                .ReverseMap();
        }
    }
}
