using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int ReaderId { get; set; }
        public Reader Reader { get; set; }

        public int CopyId { get; set; }
        public Copy Copy { get; set; }

        public int FineId { get; set; }
        public Fine Fine { get; set; }
    }
}
