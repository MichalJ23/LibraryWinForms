using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            var bookToRemove = _context.Books.FirstOrDefault(b => b.Id == book.Id);
            if (bookToRemove != null)
            {
                _context.Books.Remove(bookToRemove);
                _context.SaveChanges();
            }
        }
    }
}
