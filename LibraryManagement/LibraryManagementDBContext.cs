using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement;

public class LibraryManagementDBContext(DbContextOptions<LibraryManagementDBContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<User> Users { get; set; }
}