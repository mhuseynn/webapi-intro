using WebApiIntro.Contexts;
using WebApiIntro.Entities.Concretes;
using WebApiIntro.Reposiotries.Abstracts;

namespace WebApiIntro.Reposiotries.Concretes;

public class CarReposiotry : GenericRepository<Car>, ICarRepository
{
    public CarReposiotry(AppDbContext context) : base(context)
    {
    }
}
