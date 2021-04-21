using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // CreateMap<City, CityDto>();
            CreateMap<City, CityDto>().ReverseMap(); //add reverse map to support two way mapping
            CreateMap<City, CityUpdateDto>().ReverseMap(); 
        }
    }
}