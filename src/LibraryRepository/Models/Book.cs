using LibraryRepository.Models.Nowy_folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public Genre Genre { get; set; }
        public string Author { get; set; }

        public ICollection<Copy> Copies { get; set; }
    }
}
