using GraphQL.Demo.Data;
using GraphQL.Demo.Interfaces;

namespace GraphQL.Demo.Repositories;

public class SuperheroRepository : ISuperheroRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public SuperheroRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}