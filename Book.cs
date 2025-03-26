public class Book
{
	private string _title;
	private string _author;
	private string _isbn;
	private int _availablecopies;
	public Book(string title, string author, string isbn, int availablecopies)
	{
		_title = title;
		_author = author;
		_isbn = isbn;
		_availablecopies = availablecopies;
	}
	public bool BorrowBook(string title)
	{
		if (_title = title && _availablecopies>0)
		{
			_availablecopies = _availablecopies - 1;
			return true;
		}
		return false;
	}
    public void DisplayBook()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Available Copies: {_availablecopies}");
    }

}
