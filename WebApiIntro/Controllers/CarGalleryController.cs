using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiIntro.Entities.Concretes;
using WebApiIntro.Services;

namespace WebApiIntro.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarGalleryController : ControllerBase
{
    private readonly CarGalleryService _carGalleryService;

    public CarGalleryController(CarGalleryService carGalleryService)
    {
        _carGalleryService = carGalleryService;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetCarGallery(int id)
    {
        var carGallery = await _carGalleryService.GetCarGallery(id);
        return Ok(carGallery);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllCarGalleries()
    {
        return Ok(await _carGalleryService.GetAllCarGalleries());
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddCarGallery([FromBody] CarGallery carGallery)
    {
        await _carGalleryService.AddCarGallery(carGallery);
        return Ok("CarGallery added");
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateCarGallery([FromBody] CarGallery carGallery)
    {
        await _carGalleryService.UpdateCarGallery(carGallery);
        return Ok("CarGallery guncellendi");
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteCarGallery(int id)
    {
        await _carGalleryService.DeleteCarGallery(id);
        return Ok("CarGallery Silindi");
    }
}