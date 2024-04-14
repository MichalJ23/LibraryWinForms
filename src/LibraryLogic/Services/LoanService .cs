using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryRepository.Models;
using LibraryRepository.Repository;

namespace LibraryLogic.Services
{
    public class LoanService
    {
        private readonly LoanRepository _loanRepository;
        public LoanService() 
        {
            _loanRepository = new LoanRepository();
        }
        public List<Loan> GetAllLoans()
        {
            return _loanRepository.GetAllLoans();
        }

        public void CreateLoan(Loan loan)
        {
            if (loan is null)
            {
                return;
            }

            _loanRepository.AddLoan(loan);
        }
    }
}
