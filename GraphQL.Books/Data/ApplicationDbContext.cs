using GraphQL.Books.Models;
using Microsoft.EntityFrameworkCore;
namespace GraphQL.Books.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
}
