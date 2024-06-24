using Microsoft.AspNetCore.Mvc;
using MovieHub.API.Models;

namespace MovieHub.API.Controllers;

[ApiController]
[Route("api/movies")]
public class MoviesController : ControllerBase
{
    [HttpGet("list")]
    public ActionResult<IEnumerable<MoviesDto>> MovieList(
        [FromQuery] string? title,
        [FromQuery] string? genre)
    {
        var filteredMovies = MoviesDataStore.Current.Movies
            .Where(movie => string.IsNullOrEmpty(title) ||
                            movie.Title.Contains(title, StringComparison.CurrentCultureIgnoreCase))
            .Where(movie => string.IsNullOrEmpty(genre) ||
                            movie.Genre.Equals(genre, StringComparison.CurrentCultureIgnoreCase))
            .Select(movie => movie.Title);

        return Ok(filteredMovies);
    }

    [HttpGet("details")]
    public ActionResult<MoviesDto> MovieDetails(
        [FromQuery] string title
    )
    {
        var movieDetails = MoviesDataStore.Current.Movies.Where(movie => movie.Title.Equals(title, StringComparison.CurrentCultureIgnoreCase));
        return Ok(movieDetails);
    }
}