using Microsoft.EntityFrameworkCore;
using MovieHub.API.Entities;

namespace MovieHub.API.DbContexts;

public class MoviesContext(DbContextOptions<MoviesContext> dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Movie> Movie { get; set; }
    public DbSet<Cinema> Cinema { get; set; }
    public DbSet<MovieCinema> MovieCinema { get; set; }
}