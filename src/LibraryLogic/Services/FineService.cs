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

        public void UpdateFine(Fine fine)
        {
            if (fine == null)
            {
                throw new ArgumentNullException(nameof(fine));
            }

            var existingFine = _fineRepository.GetFineById(fine.Id);

            if (existingFine == null)
            {
                throw new ArgumentException("Nie znaleziono kary o podanym ID.", nameof(fine.Id));
            }

            existingFine.LoandId = fine.LoandId;
            existingFine.FineType = fine.FineType;
            existingFine.FineAmount = fine.FineAmount;

            _fineRepository.UpdateFine(existingFine);
        }

        public Fine GetFineById(int fineId)
        {
            return _fineRepository.GetFineById(fineId);
        }
    }
}