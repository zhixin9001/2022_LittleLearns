using GraphQL.Demo.Model;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace GraphQL.Demo.Data;

public class Mutation
{
    public string AddMovie(Movie movie)
    =>$"Movie created, title: {movie.Title}";

    public Movie UpdateMovie(string description, [Service] ApplicationDbContext context)
    {
        context.Movies.First().Description = description;
        context.SaveChanges();
        return context.Movies.First();
    }

    public async Task<string> AddMovieWithEvent(string movie, [Service] ITopicEventSender sender)
    {
        await sender.SendAsync(nameof(Subscription.MovieAdded), movie);
        return $"Movie created, title: {movie}, event sent";
    }
}