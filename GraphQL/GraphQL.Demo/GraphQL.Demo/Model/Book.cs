using HotChocolate;
using HotChocolate.Types;

namespace GraphQL.Demo.Model;

public class Book
{
    public string Title { get; set; }

    public Author Author { get; set; }
}

[GraphQLName("BookAuthor")]
public class Author
{
    [GraphQLName("fullName")]
    public string Name { get; set; }
}

public class Product
{
    [GraphQLType(typeof(IdType))]
    public int Id { get; set; }
}