using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.Services
{
    internal interface IBookService
    {
        public List<Book> GetAllBooks();
        void CreateBook(Book book);
        void DeleteBook(Book book);
    }
}
