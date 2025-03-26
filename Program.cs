using System;
using System.Collections.Generic;


namespace group1_lib_management
{

    public class Person
    {
        public string Name;
        public string Email;
        public string Id;

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            Id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}");
        }
    }
    public class Student : Person
    {
        private string Major;
        private int GraduationYear;

        public Student(string name, string email, string id, string major, int graduationYear) : base(name, email, id)

        {
            Major = major;
            GraduationYear = graduationYear;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Student Major: {Major},Graduation Year:{GraduationYear}");
        }
    }
    public class Staff : Person
    {
        public string Position;
        public string Department;

        public Staff(string name, string email, string id, string position, string department) : base(name, email, id)
        {
            Position = position;
            Department = department;
        }
    }
    public class Book
    {
        public string _title;
        public string _author;
        public string _isbn;
        public int _availablecopies;
        public Book(string title, string author, string isbn, int availablecopies)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
            _availablecopies = availablecopies;
        }
        public bool BorrowBook(string title)
        {
            if (_title == title && _availablecopies > 0)
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
    class Program
    {
        static void Main(string[] args)
        {
            // Create Library instance
            Library library = new Library();

            // Create and add books
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Create and add patrons
            Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            library.AddPatron(student1);
            library.AddPatron(student2);
            library.AddPatron(staff1);

            // Display initial state
            library.DisplayBooks();
            library.DisplayPatrons();

            // Borrowing scenario
            Console.WriteLine("\nBorrowing Books...");
            if (book2.BorrowBook("Business Insights with AI"))
                Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
            if (book3.BorrowBook("Analytics in Action"))
                Console.WriteLine("Akhil borrowed 'Analytics in Action'");

            // Display updated state
            Console.WriteLine("\nBooks after borrowing:");
            library.DisplayBooks();
        }
    }
}