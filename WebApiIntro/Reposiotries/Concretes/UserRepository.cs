using WebApiIntro.Contexts;
using WebApiIntro.Entities.Concretes;
using WebApiIntro.Reposiotries.Abstracts;

namespace WebApiIntro.Reposiotries.Concretes;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}