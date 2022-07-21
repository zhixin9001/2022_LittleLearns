using GraphQL.Demo.Model;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQL.Demo.Data;

public class Subscription
{
    [Subscribe]
    public string MovieAdded([EventMessage] string movie) => movie;
}