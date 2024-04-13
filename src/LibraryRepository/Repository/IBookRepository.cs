using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal interface IBookRepository
    {
        void AddBook(Book book);
        void DeleteBook(Book book);
    }
}
