using WebApiIntro.Entities.Abstracts;

namespace WebApiIntro.Entities.Concretes;

public class Car : BaseEntity
{
    public string? Model{ get; set; }
    public string? Marka{ get; set; }
    public int? SeatCount{ get; set; }
    public int? Year{ get; set; }

    //Foreign Key
    public int UserId { get; set; }
    public int CarGalleryId { get; set; }

    //Navigation Property
    public User? User { get; set; }
    public CarGallery CarGallery { get; set; }
} 
