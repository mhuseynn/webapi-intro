using WebApiIntro.Contexts;
using WebApiIntro.Entities.Concretes;
using WebApiIntro.Reposiotries.Abstracts;

namespace WebApiIntro.Reposiotries.Concretes;

public class CarGalleryRepository : GenericRepository<CarGallery>, ICarGalleryRepository
{
    public CarGalleryRepository(AppDbContext context) : base(context)
    {
    }
}