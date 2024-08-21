using GraphQL.Books.Data;
using GraphQL.Books.Data.Repositories;
using GraphQL.Books.GraphQL.Mutations;
using GraphQL.Books.GraphQL.Queries;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Books.DependencyInjections;

public static class ServiceCollectionExtensions
{
    public static void AddDataServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("BooksDb"));
        services.AddScoped<IBookRepository, BookRepository>();
    }

    public static void AddGraphQLServices(this IServiceCollection services)
    {
        services.AddGraphQLServer()
                .AddQueryType<BookQuery>()
                .AddMutationType<BookMutation>();
    }
}
