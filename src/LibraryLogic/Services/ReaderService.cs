using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRepository.Models;
using LibraryRepository.Repository;

namespace LibraryLogic.Services
{
    public class ReaderService : IReaderService
    {
        private readonly ReaderRepository _readerRepository;
        public ReaderService() 
        {
            _readerRepository = new ReaderRepository();
        }
        public List<Reader> GetAllReaders()
        {
            return _readerRepository.GetAllReaders();
        }

        public void CreateReader(Reader reader)
        {
            if (reader is null)
            {
                return;
            }

            _readerRepository.AddReader(reader);
        }

        public void DeleteReader(Reader reader)
        {
            if (reader is null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            _readerRepository.DeleteReader(reader);
        }
    }
}
