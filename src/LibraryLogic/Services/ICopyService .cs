using LibraryRepository.Models;
using LibraryRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.Services
{
    internal interface ICopyService
    {
        public List<Copy> GetAllCopies();
        public void AddCopy(int bookId, int quantity);
        void DeleteCopy(int bookId, int quantity);
    }
}
