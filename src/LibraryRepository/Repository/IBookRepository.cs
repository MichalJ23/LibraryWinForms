using LibraryRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal interface IBookRepository
    {
        public List<Book> GetAllBooks();
        void AddBook(Book book);
        void DeleteBook(Book book);
    }
}
