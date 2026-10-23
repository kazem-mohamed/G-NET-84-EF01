namespace G_NET_84_EF01;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Pages { get; set; }
    public int PublishedYear { get; set; }
    public bool IsInStock { get; set; }
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public Author Author { get; set; } = null!;
    public Category Category { get; set; } = null!;
}
