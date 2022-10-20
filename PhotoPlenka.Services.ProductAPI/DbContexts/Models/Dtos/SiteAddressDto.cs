namespace PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;

public class SiteAddressDto
{
    public int SiteAddressId { get; set; }
    
    public string AddressItem { get; set; }
    
    public SiteData SiteData { get; set; }
}