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
        List<Loan> GetAllLoans();
        void AddLoan(int readerId, int bookId, DateTime loanDate);
        void ReturnLoan(int loanId);
    }
}
