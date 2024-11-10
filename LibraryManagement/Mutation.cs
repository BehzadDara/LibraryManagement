using LibraryManagement.DTOs;
using LibraryManagement.Models;

namespace LibraryManagement;

public class Mutation
{
    public async Task<Book> AddBook(AddBookDTO input, [Service] LibraryManagementDBContext context)
    {
        var book = new Book { Title = input.Title, ISBN = input.ISBN, AuthorId = input.AuthorId };

        await context.Books.AddAsync(book);
        await context.SaveChangesAsync();

        return book;
    }

    public async Task<Author> AddAuthor(AddAuthorDTO input, [Service] LibraryManagementDBContext context)
    {
        var author = new Author { Name = input.Name };

        await context.Authors.AddAsync(author);
        await context.SaveChangesAsync();

        return author;
    }

    public async Task<User> AddUser(AddUserDTO input, [Service] LibraryManagementDBContext context)
    {
        var user = new User { Name = input.Name };

        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();

        return user;
    }

    public async Task<User> UserBorrowBook(UserBorrowBookDTO input, [Service] LibraryManagementDBContext context)
    {
        var user = await context.Users.FindAsync(input.UserId)
            ?? throw new Exception("User not found.");

        var book = await context.Books.FindAsync(input.BookId)
            ?? throw new Exception("Book not found.");

        user.BorrowedBooks.Add(book);
        await context.SaveChangesAsync();

        return user;
    }

    public async Task<User> UserReturnBook(UserReturnBookDTO input, [Service] LibraryManagementDBContext context)
    {
        var user = await context.Users.FindAsync(input.UserId)
            ?? throw new Exception("User not found.");

        var book = await context.Books.FindAsync(input.BookId)
            ?? throw new Exception("Book not found.");

        user.BorrowedBooks.Remove(book);
        await context.SaveChangesAsync();

        return user;
    }
}
