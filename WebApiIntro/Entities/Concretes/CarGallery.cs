using WebApiIntro.Entities.Abstracts;

namespace WebApiIntro.Entities.Concretes;

public class CarGallery : BaseEntity
{
    public string? Name { get; set; }
    

    //Navigation Property
    public ICollection<Car>? Cars { get; set; }
}