using LibraryRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    public class ReaderRepository : IReaderRepository
    {
        private readonly AppDbContext _context;
        public ReaderRepository()
        {
            _context = new AppDbContext();
        }
        public List<Reader> GetAllReaders()
        {
            return _context.Readers.ToList();
        }
        public void AddReader(Reader reader)
        {
            _context.Readers.Add(reader);
            _context.SaveChanges();
        }

        public Reader GetReaderById(int id)
        {
            return _context.Readers.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateReader(Reader reader)
        {
                _context.Entry(reader).State = EntityState.Modified;
                _context.SaveChanges();
        }
    }
}
