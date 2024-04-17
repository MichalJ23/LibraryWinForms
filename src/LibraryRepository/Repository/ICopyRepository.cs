using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal interface ICopyRepository
    {
        public List<Copy> GetAllCopies();
        void AddCopy(int bookId, int quantity);
        void DeleteCopy(int copyId, int quantity);
        void IncrementCopiesAmount(int copyId);
        void DecrementCopiesAmount(int copyId);
    }
}
