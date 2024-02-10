namespace Task6;
public class Library : ILibrary
{
    List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        System.Console.WriteLine("---------------------");

    }
    public List<Book> DisplayBooks()
    {
        return books;
    }
    public void UpdateBook(Book _book)
    {
        var book = books.FirstOrDefault(e => e.Id == _book.Id);
        books.Add(book);
        System.Console.WriteLine("Book is updated ");
        System.Console.WriteLine("---------------------");

    }
    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(e => e.Id == id);
        books.Remove(book);
        System.Console.WriteLine("Book is deleted");
        System.Console.WriteLine("---------------------");
    }
    public Book SearchByTitle(string title)
    {
        var book = books.FirstOrDefault(e => e.Title == title);
        return book;
    }
    public Book SearchByAuthor(string author)
    {
        var book = books.FirstOrDefault(e => e.Author == author);
        return book;
    }
}
