using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryGUI.DTOs;
using LibraryRepository.Models;
using LibraryRepository.Repository;

namespace LibraryLogic.Services
{
    public class LoanService : ILoanService
    {
        private readonly LoanRepository _loanRepository;
        private readonly CopyRepository _copyRepository;
        private readonly ReaderRepository _readerRepository;
        private readonly CopyService _copyService;
        private readonly ReaderService _readerService;
        

        public LoanService()
        {
            _loanRepository = new LoanRepository();
            _copyRepository = new CopyRepository();
            _readerRepository = new ReaderRepository();
            _copyService = new CopyService();
            _readerService = new ReaderService();
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

        public IEnumerable<LoanDTO> LoadDataForGridView()
        {
            var allLoans = this.GetAllLoans();
            var loans = new List<LoanDTO>();

            foreach(var loan in allLoans)
            {
                var readerFullName = _readerService.GetReaderFullName(loan.ReaderId);
                var book = _copyService.GetBookByCopyId(loan.CopyId);
                var loanDTO = new LoanDTO
                {
                    LoanId = loan.Id,
                    LoanDate = loan.LoanDate,
                    ReturnDate = loan.ReturnDate,
                    ReaderFullName = readerFullName,      
                    BookTitle = book.Title,
                };
                loans.Add(loanDTO);
            }

            return loans;
        }
    }
}
