using LibraryLogic.DTOs;
using LibraryRepository.Models;
using LibraryRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.Services
{
    public interface ICopyService
    {
        List<Copy> GetAllCopies();
        void AddCopy(int bookId, int quantity);
        void DeleteCopy(int copyId, int quantity);
        IEnumerable<Book> GetBooksAvailableForLoan();
        int GetCopyIdByBookId(int bookId);
        void IncrementAvailableQuantityForCopy(int copyId);
        void DecrementAvailableQuantityForCopy(int copyId);
        IEnumerable<CopyDTO> LoadDtosForComboBox();
    }
}
