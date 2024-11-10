namespace LibraryManagement.Models;

public class User : Entity
{
    public required string Name { get; set; }
    public ICollection<Book> BorrowedBooks { get; set; } = [];
}