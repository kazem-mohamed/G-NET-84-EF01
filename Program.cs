using Microsoft.EntityFrameworkCore;

namespace G_NET_84_EF01;

class Program
{
    static void Main(string[] args)
    {
        const string defaultConnectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=ReadMoreBooks;Trusted_Connection=True;TrustServerCertificate=True;";

        var connectionString = Environment.GetEnvironmentVariable("READMORE_BOOKSTORE_CONNECTION")
            ?? defaultConnectionString;

        var options = new DbContextOptionsBuilder<BookstoreContext>()
            .UseSqlServer(connectionString)
            .Options;

        using var context = new BookstoreContext(options);

        try
        {
            var databaseCreated = context.Database.EnsureCreated();
            Console.WriteLine(databaseCreated
                ? "ReadMoreBooks database was created."
                : "ReadMoreBooks database already exists.");
            Console.WriteLine($"Provider: {context.Database.ProviderName}");
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine($"Database creation failed: {exception.Message}");
            Environment.ExitCode = 1;
        }
    }
}
