using GraphQL.Books.Models;

namespace GraphQL.Books.Data.Repositories;

public interface IBookRepository
{
    IQueryable<Book> GetQueryable();
    Task<Book> GetByIdAsync(int id, CancellationToken ct);
    Task AddAsync(Book book, CancellationToken ct);
    Task UpdateAsync(Book book, CancellationToken ct);
    Task RemoveAsync(Book book, CancellationToken ct);
}

public class BookRepository(ApplicationDbContext context) : IBookRepository
{
    private readonly ApplicationDbContext _context = context;

    public IQueryable<Book> GetQueryable()
    {
        return _context.Set<Book>();
    }

    public async Task<Book> GetByIdAsync(int id, CancellationToken ct)
    {
        return await _context.Set<Book>().FindAsync([id, ct], cancellationToken: ct);
    }

    public async Task AddAsync(Book book, CancellationToken ct)
    {
        await _context.Set<Book>().AddAsync(book, ct);
        await _context.SaveChangesAsync(ct);
    }

    public async Task UpdateAsync(Book book, CancellationToken ct)
    {
        _context.Set<Book>().Update(book);
        await _context.SaveChangesAsync(ct);
    }

    public async Task RemoveAsync(Book book, CancellationToken ct)
    {
        _context.Set<Book>().Remove(book);
        await _context.SaveChangesAsync(ct);
    }
}
