using GraphQL.Demo.Model;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQL.Demo.Data;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Movie> GetMovies([Service] ApplicationDbContext context) =>
        context.Movies;
    
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
        context.Superheroes;
}