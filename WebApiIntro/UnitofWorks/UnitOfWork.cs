using WebApiIntro.Reposiotries.Abstracts;

namespace WebApiIntro.UnitofWorks;

public class UnitOfWork
{
    public ICarRepository CarRepository { get; set; }
    public IUserRepository UserRepository { get; set; }
    public ICarGalleryRepository CarGalleryRepository { get; set; }

    public UnitOfWork(ICarRepository carRepository, IUserRepository userRepository, ICarGalleryRepository carGalleryRepository)
    {
        CarRepository = carRepository;
        UserRepository = userRepository;
        CarGalleryRepository = carGalleryRepository;
    }
}