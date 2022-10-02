using PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;

namespace PhotoPlenka.Services.ProductAPI.Repository;

public interface ISiteDatatRepository
{

    Task<IEnumerable<SiteDataDto>> GetSiteDatas();
    Task<SiteDataDto> GetSiteDataById(int siteId);
    Task<SiteDataDto> CreateUpdateSiteSata(SiteDataDto siteDataDto);
    Task<bool> DeleteSiteData(int siteId);

}