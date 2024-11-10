namespace LibraryManagement.Models;

public class Book : Entity
{
    public required string Title { get; set; }
    public required string ISBN { get; set; }
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}