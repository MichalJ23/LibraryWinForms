using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    public class FineRepository : IFineRepository
    {
        private readonly AppDbContext _context;

        public FineRepository()
        {
            _context = new AppDbContext();
        }
        public void AddFine(Fine fine)
        {
            _context.Fines.Add(fine);
            _context.SaveChanges();
        }

        public List<Fine> GetAllFines()
        {
            return _context.Fines.ToList();
        }

        public Fine GetFineById(int id)
        {
            return _context.Fines.FirstOrDefault(f => f.Id == id);
        }

        public void UpdateFine(Fine fine)
        {
            var existingFine = _context.Fines.FirstOrDefault(f => f.Id == fine.Id);
            if (existingFine != null)
            {
                existingFine.FineType = fine.FineType;
                existingFine.FineAmount = fine.FineAmount;
                existingFine.LoandId = fine.LoandId;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Nie znaleziono kary o podanym ID.", nameof(fine.Id));
            }
        }
    }
}
