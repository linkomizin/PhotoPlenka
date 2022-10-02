using PhotoPlenka.Services.ProductAPI.DbContexts.Models;
using Microsoft.EntityFrameworkCore;

namespace PhotoPlenka.Services.ProductAPI.DbContexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<SiteData> SiteDatas { get; set; }
    public DbSet<SiteAddress> Addresses { get; set; }


   //  protected override void OnModelCreating(ModelBuilder modelBuilder)
   //  {
   //      base.OnModelCreating(modelBuilder);
   //      modelBuilder.Entity<Product>().HasData(
   //          new Product
   //          {
   //              ProductId = 1,
   //              Name = "Petrovich",
   //              Price = 10,
   //              CategoryName = "Coooll!",
   //              ImageUrl = "https://kartinkin.net/uploads/posts/2021-07/1627425767_37-kartinkin-com-p-raznaya-yeda-yeda-krasivo-foto-45.jpg",
   //              Description = "Praesend scelerisque, mi sed ulrices condimentum, lacus bla bla bla"
   //          }
   //      );
   //      modelBuilder.Entity<Product>().HasData(
   //          new Product
   //          {
   //              ProductId = 2,
   //              Name = "Samosa",
   //              Price = 100,
   //              CategoryName = "Appetizer",
   //              ImageUrl = "https://kartinkin.net/uploads/posts/2021-08/thumbs/1629689301_28-kartinkin-com-p-samaya-krasivaya-yeda-yeda-krasivo-foto-28.jpg",
   //              Description = "Praesend scelerisque, mi sed ulrices condimentum, lacus bla bla bla"
   //          }
   //      );
   //      modelBuilder.Entity<Product>().HasData(
   //          new Product
   //          {
   //              ProductId = 3,
   //              Name = "Sweet Pie",
   //              Price = 100,
   //              CategoryName = "Appetizer",
   //              ImageUrl = "https://s1.1zoom.ru/big3/504/The_second_dishes_Vienna_sausage_Potato_Wood_520555_5506x3671.jpg",
   //              Description = "Praesend scelerisque, mi sed ulrices condimentum, lacus bla bla bla"
   //          }
   //      );
   //      modelBuilder.Entity<Product>().HasData(
   //          new Product
   //          {
   //              ProductId = 4,
   //              Name = "Bobris",
   //              Price = 15,
   //              CategoryName = "Dessert",
   //              ImageUrl = "https://i.artfile.ru/3407x2267_926133_[www.ArtFile.ru].jpg",
   //              Description = "Praesend scelerisque, mi sed ulrices condimentum, lacus bla bla bla"
   //          }
   //      );
   //      modelBuilder.Entity<Product>().HasData(
   //          new Product
   //          {
   //              ProductId = 5,
   //              Name = "Pah Bhaji",
   //              Price = 15,
   //              CategoryName = "Entree",
   //              ImageUrl = "https://colorpict.com/wp-content/gallery/vkusnaya_yeda/vkusnaya_yeda-33.jpg",
   //              Description = "Praesend scelerisque, mi sed ulrices condimentum, lacus bla bla bla"
   //          }
   //      );
   // }
}