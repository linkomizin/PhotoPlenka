
using Microsoft.AspNetCore.Mvc;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models;
using PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;
using PhotoPlenka.Services.ProductAPI.Repository;

namespace PhotoPlenka.Services.ProductAPI.Controllers;

[Route("api/addresess")]
public class SiteAddressApiController : ControllerBase
{
    protected ResponseDto _response;

    private IAddressDataRepository _addressDataRepository;

    public SiteAddressApiController(IAddressDataRepository addressDataRepository)
    {
        this._response = new ResponseDto();
        _addressDataRepository = addressDataRepository;
    }
    // GET
    [HttpGet]
    public async Task<object> Get()
    {
        try
        {
            IEnumerable<SiteAddressDto> siteDatas = await _addressDataRepository.GetSiteDatas();
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
            SiteAddressDto siteAddressDto = await _addressDataRepository.GetSiteDataById(id);
            _response.Reuslt = siteAddressDto;
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() {ex.ToString()};
        }

        return _response;
    }
    [HttpPost]
    public async Task<object> Post([FromBody] SiteAddressDto siteAddress)
    {
        try
        {
            SiteAddressDto model = await _addressDataRepository.CreateUpdateSiteSata(siteAddress);
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
    public async Task<object> Put([FromBody] SiteAddressDto siteAddressDto)
    {
        try
        {
            SiteAddressDto model = await _addressDataRepository.CreateUpdateSiteSata(siteAddressDto);
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
            bool isSuccess = await _addressDataRepository.DeleteSiteData(id);
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