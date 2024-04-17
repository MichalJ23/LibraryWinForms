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
        private readonly CopyRepository _copyRepository;
        private readonly ReaderRepository _readerRepository;
        private readonly CopyService _copyService;

        public LoanService()
        {
            _loanRepository = new LoanRepository();
            _copyRepository = new CopyRepository();
            _readerRepository = new ReaderRepository();
            _copyService = new CopyService();
        }

        public IEnumerable<Loan> GetAllLoans()
        {
            return _loanRepository.GetAllLoans();
        }

        public void AddLoan(int readerId, int bookId, DateTime loanDate)
        {
            var reader = _readerRepository.GetReaderById(readerId);
            var copyId = _copyService.GetCopyIdByBookId(bookId);
            var copy = _copyRepository.GetCopyById(copyId);

            if (reader == null)
                throw new ArgumentException("Invalid reader ID.");

            if (copy == null)
                throw new ArgumentException("Invalid copy ID.");

            if (copy.AvailableQuantity <= 0)
                throw new InvalidOperationException("No available copies to loan.");

            var loan = new Loan
            {
                LoanDate = DateOnly.FromDateTime(loanDate),
                ReturnDate = DateOnly.FromDateTime(loanDate).AddDays(30),
                ReaderId = readerId,
                CopyId = copyId
            };

            _loanRepository.AddLoan(loan);

            _copyService.DecrementAvailableQuantityForCopy(copyId);
        }

        public void ReturnLoan(int loanId)
        {
            var loan = _loanRepository.GetLoanById(loanId);
            _copyService.IncrementAvailableQuantityForCopy(loan.CopyId); 

            if (loan == null)
                throw new ArgumentException("Invalid loan ID.");

            _loanRepository.DeleteLoan(loanId);
        }
    }
}
