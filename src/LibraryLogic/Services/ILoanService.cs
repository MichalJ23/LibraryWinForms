using LibraryGUI.DTOs;
using LibraryRepository.Models;
using LibraryRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.Services
{
    public interface ILoanService
    {
        IEnumerable<Loan> GetAllLoans();
        void AddLoan(int readerId, int bookId, DateTime loanDate);
        void ReturnLoan(int loanId);
        IEnumerable<LoanDTO> LoadDataForGridView();
    }
}
