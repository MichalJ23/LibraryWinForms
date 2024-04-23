using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.DTOs
{
    public class CopyDTO
    {
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public string BookTitle { get; set; }
    }
}
