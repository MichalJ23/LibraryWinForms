using LibraryRepository.Models;
using LibraryRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.Services
{
    internal interface ILoanService
    {
        public List<Loan> GetAllLoans();
        void CreateLoan(Loan loan);
        void DeleteLoan(Loan loan);
    }
}
