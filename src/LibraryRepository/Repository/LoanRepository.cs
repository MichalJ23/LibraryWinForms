using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal class LoanRepository : ILoanRepository
    {
        private readonly AppDbContext _context;
        public LoanRepository()
        {
            _context = new AppDbContext();
        }
        public void AddLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public void DeleteLoan(Loan loan)
        {
            var loanToRemove = _context.Loans.FirstOrDefault(l => l.Id == loan.Id);

            if (loanToRemove is not null) 
            {
                _context.Loans.Remove(loanToRemove);
                _context.SaveChanges();
            }
        }
    }
}
