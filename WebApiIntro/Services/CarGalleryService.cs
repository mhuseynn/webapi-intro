using WebApiIntro.Entities.Concretes;
using WebApiIntro.Reposiotries.Abstracts;

namespace WebApiIntro.Services;

public class CarGalleryService
{
    private readonly ICarGalleryRepository _carGalleryRepository;

    public CarGalleryService(ICarGalleryRepository carGalleryRepository)
    {
        _carGalleryRepository = carGalleryRepository;
    }

    public async Task AddCarGallery(CarGallery carGallery)
    {
        await _carGalleryRepository.AddAsync(carGallery);
        await _carGalleryRepository.SaveAllChangesAsync();
    }

    public async Task UpdateCarGallery(CarGallery carGallery)
    {
        await _carGalleryRepository.UpdateAsync(carGallery);
        await _carGalleryRepository.SaveAllChangesAsync();
    }

    public async Task DeleteCarGallery(int id)
    {
        await _carGalleryRepository.DeleteAsync(id);
        await _carGalleryRepository.SaveAllChangesAsync();
    }

    public async Task<CarGallery?> GetCarGallery(int id)
    {
        return await _carGalleryRepository.GetAsync(id);
    }

    public async Task<IQueryable<CarGallery>> GetAllCarGalleries()
    {
        return await _carGalleryRepository.GetAllAsync();
    }
}