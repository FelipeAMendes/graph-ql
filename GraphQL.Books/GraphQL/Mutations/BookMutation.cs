using GraphQL.Books.Data.Repositories;
using GraphQL.Books.Dtos;
using GraphQL.Books.Models;

namespace GraphQL.Books.GraphQL.Mutations;

public class BookMutation
{
    public async Task<Book> AddBook(BookDto input, [Service] IBookRepository repository, CancellationToken ct)
    {
        var book = new Book(input.Title, input.Author, input.Year);

        await repository.AddAsync(book, ct);

        return book;
    }

    public async Task<Book> UpdateBook(int id, BookDto input, [Service] IBookRepository repository, CancellationToken ct)
    {
        if (await repository.GetByIdAsync(id, ct) is var book && book is null)
            return null;

        book.Update(input.Title, input.Author, input.Year);

        await repository.UpdateAsync(book, ct);
        return book;
    }

    public async Task<bool> DeleteBook(int id, [Service] IBookRepository repository, CancellationToken ct)
    {
        if (await repository.GetByIdAsync(id, ct) is var book && book is null)
            return false;
        
        await repository.RemoveAsync(book, ct);
        return true;
    }
}
