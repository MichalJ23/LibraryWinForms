using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRepository.Models;
using LibraryRepository.Repository;

namespace LibraryLogic.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;
        public BookService() 
        {
            _bookRepository = new BookRepository();
        }

        public void CreateBook(Book book)
        {
            if (book is null)
            {
                return;
            }

            _bookRepository.AddBook(book);
        }
    }
}
