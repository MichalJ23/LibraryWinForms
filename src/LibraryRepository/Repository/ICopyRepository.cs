using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal interface ICopyRepository
    {
        void AddCopy(Copy copy);
        void DeleteCopy(Copy copy);
    }
}
