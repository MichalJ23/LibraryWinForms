using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    public class CopyRepository : ICopyRepository
    {
        private readonly AppDbContext _context;
        public CopyRepository() 
        {
            _context = new AppDbContext();
        }
        public List<Copy> GetAllCopies()
        {
            return _context.Copies.ToList();
        }
        public void AddCopy(int bookId, int quantity)
        {
            var bookCopy = _context.Copies.FirstOrDefault(c => c.BookId == bookId);

            if (bookCopy != null)
            {
                bookCopy.TotalQuantity += quantity;
                bookCopy.AvailableQuantity += quantity;
            }
            else
            {
                var book = _context.Books.Find(bookId);

                if (book != null)
                {
                    var copy = new Copy
                    {
                        BookId = bookId,
                        TotalQuantity = quantity,
                        AvailableQuantity = quantity
                    };

                    _context.Copies.Add(copy);
                }
                else
                {
                    throw new ArgumentException("Książka o podanym ID nie istnieje.");
                }
            }

            _context.SaveChanges();
        }

        public void DeleteCopy(int copyId, int quantity)
        {
            var copy = _context.Copies.Find(copyId);

            if (copy != null)
            {
                if (copy.TotalQuantity >= quantity && copy.AvailableQuantity >= quantity)
                {
                    copy.TotalQuantity -= quantity;
                    copy.AvailableQuantity -= quantity;

                    if (copy.TotalQuantity == 0)
                    {
                        _context.Copies.Remove(copy);
                    }
                }
                else
                {
                    throw new ArgumentException("Podana ilość egzemplarzy do usunięcia przekracza dostępną ilość.");
                }
            }
            else
            {
                throw new ArgumentException("Egzemplarz o podanym ID nie istnieje.");
            }

            _context.SaveChanges();
        }

        public Copy GetCopyById(int id)
        {
            return _context.Copies.FirstOrDefault(c => c.Id == id);  
        }

        public void IncrementCopiesAmount(int copyId)
        {
            var copy = _context.Copies.FirstOrDefault(c => c.Id == copyId);

            copy.AvailableQuantity++;
            _context.SaveChanges();
        }

        public void DecrementCopiesAmount(int copyId)
        {
            var copy = _context.Copies.FirstOrDefault(c => c.Id == copyId);

            copy.AvailableQuantity--;
            _context.SaveChanges();
        }
    }
}
