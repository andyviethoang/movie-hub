namespace MovieHub.API.Entities;

public class MovieCinema
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public int CinemaId { get; set; }
    public DateTime ShowTime { get; set; }
    public decimal TicketPrice { get; set; }
}