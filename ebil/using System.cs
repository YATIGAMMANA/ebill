using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool Available { get; set; }
    }

    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> GetAvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Available)
                {
                    availableBooks.Add(book);
                }
            }
            return availableBooks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Add some books to the library
            library.AddBook(new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Available = true });
            library.AddBook(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, Available = true });
            library.AddBook(new Book { Title = "1984", Author = "George Orwell", Year = 1949, Available = false });

            // Get all books in the library
            List<Book> allBooks = library.GetAllBooks();
            Console.WriteLine("All books in the library:");
            foreach (Book book in allBooks)
            {
                Console.WriteLine("{0} by {1} ({2})", book.Title, book.Author, book.Year);
            }

            // Get all available books in the library
            List<Book> availableBooks = library.GetAvailableBooks();
            Console.WriteLine("Available books in the library:");
            foreach (Book book in availableBooks)
            {
                Console.WriteLine("{0} by {1} ({2})", book.Title, book.Author, book.Year);
            }

            // Remove a book from the library
            Book bookToRemove = allBooks[0];
            library.RemoveBook(bookToRemove);
            Console.WriteLine("Removed {0} from the library", bookToRemove.Title);
        }
    }
}