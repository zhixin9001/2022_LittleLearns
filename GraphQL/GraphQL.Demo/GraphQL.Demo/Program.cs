using GraphQL.Demo.Data;
using GraphQL.Demo.Interfaces;
using GraphQL.Demo.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
builder.Services.AddScoped<ISuperpowerRepository, SuperpowerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>().AddProjections().AddFiltering().AddSorting()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>();
    // .InitializeOnStartup();
builder.Services.AddInMemorySubscriptions();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

app.UseWebSockets();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();