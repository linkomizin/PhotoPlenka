using System.Collections;
using AutoMapper;
using PhotoPlenka.Services.ProductAPI.DbContexts;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using PhotoPlenka.Services.ProductAPI.DbContexts;
using PhotoPlenka.Services.ProductAPI.Repository;

namespace Mango.Services.ProductAPI.Repository;

public class SiteAdressRepository: IAddressDataRepository
{
    private readonly ApplicationDbContext _db;
    private IMapper _mapper;

    public SiteAdressRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    public async Task<IEnumerable<SiteAddressDto>> GetSiteDatas()
    {
        IEnumerable < SiteAddress > productsList = await _db.Addresses.ToListAsync();
        return _mapper.Map<List<SiteAddressDto>>(productsList);
    }

    public async Task<SiteAddressDto> GetSiteDataById(int addresSiteId)
    {
        var  siteAddress = await _db.Addresses.
                Where(x=>x.SiteAddressId == addresSiteId).FirstOrDefaultAsync();
        return _mapper.Map<SiteAddressDto>(siteAddress);
    }

    public async Task<SiteAddressDto> CreateUpdateSiteSata(SiteAddressDto siteAddressDto)
    {
        var siteData = _mapper.Map<SiteAddressDto, SiteAddress>(siteAddressDto);
        if (siteData.SiteAddressId > 0)
        {
            _db.Addresses.Update(siteData);
        }
        else
        {
            _db.Addresses.Add(siteData);
        }

        await _db.SaveChangesAsync();
        return _mapper.Map<SiteAddress, SiteAddressDto>(siteData);
    }

    public async Task<bool> DeleteSiteData(int addresSiteId)
    {
        try
        {
            var address = await _db.Addresses.FirstOrDefaultAsync(u => u.SiteAddressId == addresSiteId);
            if (address == null)
            {
                return false;
            }
            _db.Addresses.Remove(address);
            await _db.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}