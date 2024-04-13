using LibraryRepository.Models.Nowy_folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.DTOs
{
    internal class BookDto
    {
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public Genre Genre { get; set; }
        public string Author { get; set; }
    }
}
