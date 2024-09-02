namespace WebApiIntro.Entities.Abstracts;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool? IsDelete { get; set; }
}
