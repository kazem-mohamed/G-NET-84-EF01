using Microsoft.EntityFrameworkCore;

namespace G_NET_84_EF01;

public class BookstoreContext(DbContextOptions<BookstoreContext> options) : DbContext(options)
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Category> Categories => Set<Category>();
}
