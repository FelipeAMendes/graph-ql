using GraphQL.Books.Data.Repositories;
using GraphQL.Books.Models;

namespace GraphQL.Books.GraphQL.Queries;

public class BookQuery
{
    public IQueryable<Book> GetBooks([Service] IBookRepository repository) => repository.GetQueryable();
    public async Task<Book> GetBook(int id, [Service] IBookRepository repository, CancellationToken ct) => await repository.GetByIdAsync(id, ct);
}
