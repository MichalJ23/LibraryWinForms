using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using LibraryRepository.Models;
using LibraryRepository.Repository;

namespace LibraryLogic.Services
{
    public class BookService : IBookService
    {
        private readonly BookRepository _bookRepository;
        public BookService() 
        {
            _bookRepository = new BookRepository();
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public void CreateBook(Book book)
        {
            if (book is null)
            {
                return;
            }

            _bookRepository.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _bookRepository.GetBookById(book.Id);

            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Genre = book.Genre;
                existingBook.PublicationDate = book.PublicationDate;

                _bookRepository.UpdateBook(existingBook);
            }
            else
            {
                throw new ArgumentException("Książka o podanym ID nie istnieje.");
            }
        }
    }
}
