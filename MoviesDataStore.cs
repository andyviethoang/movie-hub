using MovieHub.API.Models;

namespace MovieHub.API;

public class MoviesDataStore
{
    public List<MoviesDto> Movies { get; set; }

    public static MoviesDataStore Current { get; } = new MoviesDataStore();

    public MoviesDataStore()
    {
        Movies = new List<MoviesDto>()
        {
            new MoviesDto()
            {
                Id = 1,
                Title = "Finding Nemo",
                Director = "Michael Bay",
                Genre = "Action",
                Rating = "PG",
                ReleaseDate = DateTime.Today,
            },
            new MoviesDto()
            {
                Id = 2,
                Title = "Finding Nemo 2",
                Director = "Michael Bay",
                Genre = "Action",
                Rating = "PG",
                ReleaseDate = DateTime.Today,
            },
            new MoviesDto()
            {
                Id = 3,
                Title = "Intersteller",
                Director = "Steve Jobs",
                Genre = "Horror",
                Rating = "M",
                ReleaseDate = DateTime.Today,
            }
        };
    }
}