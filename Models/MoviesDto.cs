namespace MovieHub.API.Models;

public class MoviesDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; }
    public int Runtime { get; set; }
    public string Synopsis { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }

    public IEnumerator<ShowingsDto> Showings { get; set; }
}