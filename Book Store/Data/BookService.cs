using System.Collections.Generic;
using System.Linq;

namespace BookstoreBlazorApp.Data
{
    public class BookService
    {
        private List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Book 1", Author = "Author 1", Price = 10.99m },
            new Book { Id = 2, Title = "Book 2", Author = "Author 2", Price = 12.99m }
        };

        public List<Book> GetBooks() => books;

        public Book GetBookById(int id) => books.FirstOrDefault(b => b.Id == id);

        public void AddBook(Book book)
        {
            book.Id = books.Max(b => b.Id) + 1;
            books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Price = book.Price;
            }
        }

        public void DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
        }
    }
}