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
        public List<Fine> GetAllFines()
        {
            return _context.Fines.ToList();
        }
        public void AddFine(Fine fine)
        {
            _context.Fines.Add(fine);
            _context.SaveChanges();
        }

        public void RemoveFine(Fine fine)
        {
            var fineToRemove = _context.Fines.FirstOrDefault(f => f.Id == fine.Id);

            if(fineToRemove is not null)
            {
                _context.Remove(fine);
                _context.SaveChanges();
            }
        }
    }
}
