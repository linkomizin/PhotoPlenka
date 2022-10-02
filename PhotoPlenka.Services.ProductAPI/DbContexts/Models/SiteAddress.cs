using System.ComponentModel.DataAnnotations;

namespace PhotoPlenka.Services.ProductAPI.DbContexts.Models;

public class SiteAddress
{
    [Key] 
    public int SiteAddressId { get; set; }

    [Required] 
    public string AddressItem { get; set; }
    
    [Required] 
    public SiteData SiteData { get; set; }
}