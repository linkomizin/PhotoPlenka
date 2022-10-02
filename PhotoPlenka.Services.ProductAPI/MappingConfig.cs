using AutoMapper;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dto;

namespace PhotoPlenka.Services.ProductAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMap()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<SiteDataDto, SiteData>();
            config.CreateMap<SiteData, SiteDataDto>();
        });
        return mappingConfig;
    }
}