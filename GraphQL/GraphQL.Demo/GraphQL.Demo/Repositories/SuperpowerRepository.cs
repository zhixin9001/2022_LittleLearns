using GraphQL.Demo.Data;
using GraphQL.Demo.Interfaces;

namespace GraphQL.Demo.Repositories;

public class SuperpowerRepository : ISuperpowerRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public SuperpowerRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}