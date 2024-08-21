namespace GraphQL.Books.Models;

public class Book(string title, string author, int year)
{
    public int Id { get; private set; }
    public string Title { get; private set; } = title;
    public string Author { get; private set; } = author;
    public int Year { get; private set; } = year;

    public void Update(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}
