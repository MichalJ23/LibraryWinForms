using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    public class LoanRepository : ILoanRepository
    {
        private readonly AppDbContext _context;
        public LoanRepository()
        {
            _context = new AppDbContext();
        }
        public List<Loan> GetAllLoans()
        {
            return _context.Loans.ToList();
        }
        public void AddLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }
        public void DeleteLoan(int loanId)
        {
            var loanToRemove = _context.Loans.FirstOrDefault(l => l.Id == loanId);

            if (loanToRemove is not null) 
            {
                _context.Loans.Remove(loanToRemove);
                _context.SaveChanges();
            }
        }

        public Loan GetLoanById(int loanId)
        {
            return _context.Loans.FirstOrDefault(l => l.Id == loanId);
        }
    }
}
