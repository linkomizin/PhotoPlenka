using AutoMapper;
using Mango.Services.ProductAPI.Repository;
using PhotoPlenka.Services.ProductAPI;
using Microsoft.EntityFrameworkCore;
using PhotoPlenka.Services.ProductAPI.DbContexts;
using PhotoPlenka.Services.ProductAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MariaDbServerVersion(new MariaDbServerVersion(new Version(10, 11, 0)))));

//mapper
IMapper mapper = MappingConfig.RegisterMap().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//repository
builder.Services.AddScoped<ISiteDatatRepository, SiteDataRepository>();
builder.Services.AddScoped<IAddressDataRepository, SiteAdressRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();