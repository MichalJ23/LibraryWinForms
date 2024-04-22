using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal interface IFineRepository
    {
        public List<Fine> GetAllFines();
        void AddFine(Fine fine);
    }
}
