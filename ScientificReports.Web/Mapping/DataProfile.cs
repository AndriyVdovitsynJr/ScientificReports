using AutoMapper;
using ScientificReports.BLL.Models;
using ScientificReports.Web.ViewModels;

namespace ScientificReports.Web.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<DataViewModel, DataModel>().ReverseMap();
        }
    }
}
