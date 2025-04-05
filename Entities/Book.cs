namespace BooksApi;

public class Book
{
    public int Id { get; set; }
    public required string BookName { get; set; }
    public required string BookAuthor { get; set; }
    public required string ISBN {get; set;}
}
