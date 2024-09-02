using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiIntro.Entities.Concretes;
using WebApiIntro.Models.DTOs;
using WebApiIntro.UnitofWorks;

namespace WebApiIntro.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarController : ControllerBase
{
    private readonly UnitOfWork _unitOfWork;

    public CarController(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }



    [HttpGet("[action]")]
    public async Task<IActionResult> GetCar(int id)
    {
        var car = await _unitOfWork.CarRepository.GetAsync(id);
        return Ok(car);
    }


    [HttpGet("ButunMasinlariGotur")]
    public async Task<IActionResult> GetAllCars()
    {
        return Ok(await _unitOfWork.CarRepository.GetAllAsync());
    }

    // GetCarbyYear
    [HttpGet("[action]")]
    public async Task<IActionResult> GetCarByYear(int year)
    {
        var cars = (await _unitOfWork.CarRepository.GetAllAsync()).Where(x => x.Year == year).ToList();
        return Ok(cars);
    }

    // Add Car
    [HttpPost("[action]")]
    public async Task<IActionResult> AddCar([FromBody] AddCarDto car)
    {
        Car newCar = new Car()
        {
            CreatedAt = DateTime.Now,
            Year = car.Year,
            Model = car.Model,
            Marka = car.Marka,
            IsDelete = false,
            SeatCount = car.SeatCount
        };

        await _unitOfWork.CarRepository.AddAsync(newCar);
        await _unitOfWork.CarRepository.SaveAllChangesAsync();
        return Ok("Masin Ugurla elave edildi");
    }

    // Delete Car
    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteCar(int id)
    {
        await _unitOfWork.CarRepository.DeleteAsync(id);
        await _unitOfWork.CarRepository.SaveAllChangesAsync();
        return Ok("Ugurla silindi");
    }

    // UpdateCar
    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateCar([FromBody] UpdateCarDto model)
    {
        var car = await _unitOfWork.CarRepository.GetAsync(model.Id);
        if (car is not null)
        {
            car.UpdatedAt = DateTime.Now;
            car.Marka = model.Marka;
            car.Model = model.Model;

            await _unitOfWork.CarRepository.UpdateAsync(car);
            await _unitOfWork.CarRepository.SaveAllChangesAsync();
            return Ok("Ugurla update edildi");
        }
        return Ok("Masin tapilmadi");
    }
}
