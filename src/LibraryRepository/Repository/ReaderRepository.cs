using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal class ReaderRepository : IReaderRepository
    {
        private readonly AppDbContext _context;
        public ReaderRepository()
        {
            _context = new AppDbContext();
        }
        public void AddReader(Reader reader)
        {
            _context.Readers.Add(reader);
            _context.SaveChanges();
        }

        public void DeleteReader(Reader reader)
        {
            var readerToDelete = _context.Readers.FirstOrDefault(r => r.Id == reader.Id);

            if (readerToDelete != null)
            {
                _context.Readers.Remove(readerToDelete);
            }
        }
    }
}
