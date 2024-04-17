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
    public class FineService : IFineService
    {
        private readonly FineRepository _fineRepository;
        public FineService() 
        {
            _fineRepository = new FineRepository();
        }

        public List<Fine> GetAllFines()
        {
            return _fineRepository.GetAllFines();
        }

        public void AddFine(Fine fine)
        {
            if (fine is null)
            {
                return;
            }

            _fineRepository.AddFine(fine);
        }

        public void DeleteFine(Fine fine)
        {
            if (fine is null)
            {
                throw new ArgumentNullException(nameof(fine));
            }

            _fineRepository.RemoveFine(fine);
        }
    }
}
