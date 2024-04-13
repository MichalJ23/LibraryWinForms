using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal class CopyRepository : ICopyRepository
    {
        private readonly AppDbContext _context;
        public CopyRepository(AppDbContext appDbContext) 
        {
            _context = appDbContext;
        }
        public void AddCopy(Copy copy)
        {
            _context.Copies.Add(copy);
            _context.SaveChanges();
        }

        public void DeleteCopy(Copy copy)
        {
            var copyToRemove = _context.Copies.FirstOrDefault( c => c.Id == copy.Id );
            if (copyToRemove != null)
            {
                _context.Copies.Remove(copyToRemove);
                _context.SaveChanges();
            }
        }
    }
}
