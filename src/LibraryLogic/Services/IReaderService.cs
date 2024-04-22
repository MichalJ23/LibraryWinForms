using LibraryRepository.Models;
using LibraryRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.Services
{
    internal interface IReaderService
    {
        public List<Reader> GetAllReaders();
        void CreateReader(Reader reader);
        public void UpdateReader(Reader reader);
        string GetReaderFullName(int id);
    }
}
