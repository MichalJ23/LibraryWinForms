using System;
using System.Collections.Generic;
using System.Linq;
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
            return new List<Book>();
        }

        public void CreateBook(Book book)
        {
            if (book is null)
            {
                return;
            }

            _bookRepository.AddBook(book);
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        void IBookService.GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
