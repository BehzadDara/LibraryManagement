using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement;

public class Query
{
    public IQueryable<Book> GetBooks([Service] LibraryManagementDBContext context) => context.Books.Include(b => b.Author);
    public IQueryable<Author> GetAuthors([Service] LibraryManagementDBContext context) => context.Authors.Include(a => a.Books);
    public IQueryable<User> GetUsers(string? q, [Service] LibraryManagementDBContext context)
    {
        var query = context.Users.Include(u => u.BorrowedBooks).ThenInclude(b => b.Author).AsQueryable();

        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(u => u.Name.Contains(q));
        }

        return query;
    }
}
