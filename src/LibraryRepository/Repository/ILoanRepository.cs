using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal interface ILoanRepository
    {
        void AddLoan(Loan loan);
        void DeleteLoan(Loan loan);
    }
}
