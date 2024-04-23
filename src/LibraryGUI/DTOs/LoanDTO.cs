using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.DTOs
{
    internal class LoanDTO
    {
        public int LoanId { get; set; }
        public string BookTitle { get; set; } 
        public DateOnly LoanDate { get; set; }
        public DateOnly ReturnDate { get; set; }
        public string ReaderFullName {  get; set; }
    }
}
