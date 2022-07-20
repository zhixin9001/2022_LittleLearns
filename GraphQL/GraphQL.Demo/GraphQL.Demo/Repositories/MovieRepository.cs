using GraphQL.Demo.Data;
using GraphQL.Demo.Interfaces;

namespace GraphQL.Demo.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public MovieRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}