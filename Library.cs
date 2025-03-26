public class Library
{

    private List<Book> books;
    private List<Person> patrons;
    public Library()
    {
        books = new List<Book>();
        patrons = new List<Person>();
    }
 
    public void AddBook(Book book)
    {
        books.Add(book);
    }
 
    public void AddPatron(Person patron)
    {
        patrons.Add(patron);
    }
 
    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in books)

        {
            Console.WriteLine($"Title: {book._title}, Author: {book._author}, Available Copies: {book._availablecopies}");
        }
    }
 
    public void DisplayPatrons()

    {
        Console.WriteLine("\nPatrons in Library:");
        foreach (var patron in patrons)

        {
            Console.WriteLine($"Name: {patron.Name}, ID: {patron.Id}");
        }
    }
}
 