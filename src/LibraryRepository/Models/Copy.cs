using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    public class Copy
    {
        public int Id { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
