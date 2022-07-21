using GraphQL.Demo.Model;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQL.Demo.Data;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
        context.Superheroes;

    // public Superhero GetSuperheroes => new Superhero
    // {
    //     Name = "abc"
    // };
    
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
}