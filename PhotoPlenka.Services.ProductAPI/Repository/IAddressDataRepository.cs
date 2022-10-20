using PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;

namespace PhotoPlenka.Services.ProductAPI.Repository;

public interface IAddressDataRepository
{
    Task<IEnumerable< SiteAddressDto>> GetSiteDatas();
    Task<SiteAddressDto> GetSiteDataById(int addresSiteId);
    Task<SiteAddressDto> CreateUpdateSiteSata(SiteAddressDto siteDataDto);
    Task<bool> DeleteSiteData(int siteId);
}