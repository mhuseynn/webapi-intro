namespace WebApiIntro.Models.DTOs;

public class AddCarDto
{
    public string? Model { get; set; }
    public string? Marka { get; set; }
    public int? SeatCount { get; set; }
    public int? Year { get; set; }
}
