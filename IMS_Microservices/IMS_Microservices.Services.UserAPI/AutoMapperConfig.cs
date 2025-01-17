using AutoMapper;
using IMS_Microservices.Services.UserAPI.Models;
using IMS_Microservices.Services.UserAPI.Models.Dto;

namespace IMS_Microservices.Services.UserAPI
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<IMSEmployeeDto, IMSEmployee>();
                config.CreateMap<IMSEmployee, IMSEmployeeDto>();
            });
            return mappingConfig;
        }
    }
}
