using Microsoft.EntityFrameworkCore;
using WebApiIntro.Entities.Concretes;

namespace WebApiIntro.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Car> Cars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<CarGallery> CarGalleries { get; set; }

}