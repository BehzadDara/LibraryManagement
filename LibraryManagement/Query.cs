using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement;

public class Query
{
    public IQueryable<Book> GetBooks([Service] LibraryManagementDBContext context) => context.Books.Include(b => b.Author);
    public IQueryable<Author> GetAuthors([Service] LibraryManagementDBContext context) => context.Authors.Include(a => a.Books);
    public IQueryable<User> GetUsers([Service] LibraryManagementDBContext context) => context.Users.Include(u => u.BorrowedBooks).ThenInclude(b => b.Author);
}
