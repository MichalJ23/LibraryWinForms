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
        public CopyService() 
        {
            _copyRepository = new CopyRepository();
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
    }
}
