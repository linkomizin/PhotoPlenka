using System.ComponentModel.DataAnnotations;

namespace PhotoPlenka.Services.ProductAPI.DbContexts.Models;

public class SiteAddress
{
    [Key] 
    public int SiteAddressId { get; set; }
    public SiteData SiteData { get; set; }
    public string AddressItem { get; set; }
}