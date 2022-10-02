using System.ComponentModel.DataAnnotations;

namespace PhotoPlenka.Services.ProductAPI.DbContexts.Models;

public class SiteData
{
    [Key]
    public int  SiteId { get; set; }
    [Required]
    public string NameSite { get; set; }
    [Required]
    public string XpathName { get; set; }
    [Required]
    public string XpathPrice { get; set; }
    [Required]
    public string XpathOnSale { get; set; }
    [Required]
    public string AddresSite { get; set; }
    
    public List<SiteAddress> Addresses { get; set; }

}