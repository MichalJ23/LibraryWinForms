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
    public class CopyService : ICopyService
    {
        private readonly CopyRepository _copyRepository;
        private readonly BookRepository _bookRepository;
        public CopyService() 
        {
            _copyRepository = new CopyRepository();
            _bookRepository = new BookRepository();
        }

        public List<Copy> GetAllCopies()
        {
            return _copyRepository.GetAllCopies();
        }

        public void AddCopy(int bookId, int quantity)
        {
            if (bookId <= 0 || quantity <= 0)
            {
                throw new ArgumentException("Nieprawidłowe dane.");
            }

            _copyRepository.AddCopy(bookId, quantity);
        }

        public void DeleteCopy(int copyId, int quantity)
        {
            if (copyId <= 0 || quantity <= 0)
            {
                throw new ArgumentException("Nieprawidłowe dane.");
            }

            _copyRepository.DeleteCopy(copyId, quantity);
        }

        public IEnumerable<Book> GetBooksAvailableForLoan()
        {
            var copiesAvailable = _copyRepository.GetAllCopies().Where(copy => copy.AvailableQuantity > 0);

            var bookIdsAvailable = copiesAvailable.Select(copy => copy.BookId).Distinct();

            var booksAvailable = _bookRepository.GetAllBooks().Where(book => bookIdsAvailable.Contains(book.Id));

            return booksAvailable;
        }

        public int GetCopyIdByBookId(int bookId)
        {
            var copy = _copyRepository.GetAllCopies().FirstOrDefault(c => c.BookId == bookId);
            var copyId = copy.Id;

            return copyId;
        }

        public void IncrementAvailableQuantityForCopy(int copyId)
        {
             _copyRepository.IncrementCopiesAmount(copyId);
        }

        public void DecrementAvailableQuantityForCopy(int copyId)
        {
            _copyRepository.DecrementCopiesAmount(copyId);
        }

        public Book GetBookByCopyId(int copyId)
        {
            var copy = _copyRepository.GetCopyById(copyId);

            var book = _bookRepository.GetBookById(copy.BookId);

            return book;
        }
    }
}
