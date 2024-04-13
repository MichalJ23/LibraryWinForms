using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    internal class Fine
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public string FineType { get; set; }
        public decimal FineAmount { get; set; }

        public int LoandId { get; set; }
        public Loan Loan { get; set; }
    }
}
