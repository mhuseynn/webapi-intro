using WebApiIntro.Entities.Abstracts;

namespace WebApiIntro.Entities.Concretes;

public class User : BaseEntity
{
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }


    //Navigation Property
    public ICollection<Car>? Cars { get; set; }
}