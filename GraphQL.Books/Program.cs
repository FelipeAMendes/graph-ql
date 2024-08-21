using GraphQL.Books.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDataServices();
builder.Services.AddGraphQLServices();

var app = builder.Build();

app.UseRouting();
app.MapGraphQL(path: "/");

app.Run();
