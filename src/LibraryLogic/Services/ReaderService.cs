using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public void UpdateReader(Reader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            var existingReader = _readerRepository.GetReaderById(reader.Id);

            if (existingReader == null)
            {
                throw new ArgumentException("Nie znaleziono czytelnika o podanym ID.", nameof(reader.Id));
            }

            existingReader.FirstName = string.IsNullOrWhiteSpace(reader.FirstName) ? existingReader.FirstName : reader.FirstName;
            existingReader.LastName = string.IsNullOrWhiteSpace(reader.LastName) ? existingReader.LastName : reader.LastName;

            _readerRepository.UpdateReader(existingReader);
        }

        public Reader GetReaderById(int readerId)
        {
            return _readerRepository.GetReaderById(readerId);
        }

        public string GetReaderFullName(int id)
        {
            var reader = _readerRepository.GetReaderById(id);

            return $"{reader.FirstName} {reader.LastName}";
        }
    }
}
