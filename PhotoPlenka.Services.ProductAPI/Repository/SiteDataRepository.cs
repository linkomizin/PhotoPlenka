using System.Collections;
using AutoMapper;
using PhotoPlenka.Services.ProductAPI.DbContexts;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using PhotoPlenka.Services.ProductAPI.DbContexts;
using PhotoPlenka.Services.ProductAPI.Repository;

namespace Mango.Services.ProductAPI.Repository;

public class SiteDataRepository: ISiteDatatRepository
{
    private readonly ApplicationDbContext _db;
    private IMapper _mapper;

    public SiteDataRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    public async Task<IEnumerable<SiteDataDto>> GetSiteDatas()
    {
        IEnumerable < SiteData > productsList = await _db.SiteDatas.ToListAsync();
        return _mapper.Map<List<SiteDataDto>>(productsList);
    }

    public async Task<SiteDataDto> GetSiteDataById(int siteId)
    {
        SiteData  siteData = await _db.SiteDatas.
                Where(x=>x.SiteId == siteId).FirstOrDefaultAsync();
        return _mapper.Map<SiteDataDto>(siteData);
    }

    public async Task<SiteDataDto> CreateUpdateSiteSata(SiteDataDto productDto)
    {
        SiteData siteData = _mapper.Map<SiteDataDto, SiteData>(productDto);
        if (siteData.SiteId > 0)
        {
            _db.SiteDatas.Update(siteData);
        }
        else
        {
            _db.SiteDatas.Add(siteData);
        }

        await _db.SaveChangesAsync();
        return _mapper.Map<SiteData, SiteDataDto>(siteData);
    }

    public async Task<bool> DeleteSiteData(int siteId)
    {
        try
        {
            SiteData product = await _db.SiteDatas.FirstOrDefaultAsync(u => u.SiteId == siteId);
            if (product == null)
            {
                return false;
            }
            _db.SiteDatas.Remove(product);
            await _db.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}