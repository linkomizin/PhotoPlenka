
using Microsoft.AspNetCore.Mvc;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;
using PhotoPlenka.Services.ProductAPI.Repository;

namespace PhotoPlenka.Services.ProductAPI.Controllers;

[Route("api/sites")]
public class ProductApiController : ControllerBase
{
    protected ResponseDto _response;

    private ISiteDatatRepository _siteDatatRepository;

    public ProductApiController(ISiteDatatRepository siteDatatRepository)
    {
        this._response = new ResponseDto();
        _siteDatatRepository = siteDatatRepository;
    }
    // GET
    [HttpGet]
    public async Task<object> Get()
    {
        try
        {
            IEnumerable<SiteDataDto> siteDatas = await _siteDatatRepository.GetSiteDatas();
            _response.Reuslt = siteDatas;
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() {ex.ToString()};
        }

        return _response;
    }
    [HttpGet]
    [Route("{id}")]
    public async Task<object> Get(int id)
    {
        try
        {
            SiteDataDto siteDataDto = await _siteDatatRepository.GetSiteDataById(id);
            _response.Reuslt = siteDataDto;
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() {ex.ToString()};
        }

        return _response;
    }
    [HttpPost]
    public async Task<object> Post([FromBody] SiteDataDto siteDataDto)
    {
        try
        {
            SiteDataDto model = await _siteDatatRepository.CreateUpdateSiteSata(siteDataDto);
            _response.Reuslt = model;
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() {ex.ToString()};
        }

        return _response;
    }
    [HttpPut]
    public async Task<object> Put([FromBody] SiteDataDto productDto)
    {
        try
        {
            SiteDataDto model = await _siteDatatRepository.CreateUpdateSiteSata(productDto);
            _response.Reuslt = model;
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() {ex.ToString()};
        }

        return _response;
    }
    [HttpDelete]
    public async Task<object> Delete(int id)
    {
        try
        {
            bool isSuccess = await _siteDatatRepository.DeleteSiteData(id);
            _response.Reuslt = isSuccess;
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() {ex.ToString()};
        }

        return _response;
    }
}