using LibraryGUI.DTOs;
using LibraryLogic.Services;
using LibraryRepository.Models;

namespace LibraryGUI
{
    public partial class Form1 : Form
    {
        private readonly BookService _bookService;
        public Form1()
        {
            InitializeComponent();
            _bookService = new BookService();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Author = author.Text,
                PublicationDate = publicationDate.Value,
                Genre = LibraryRepository.Models.Nowy_folder.Genre.Romantyczna,
                Title = titleTxtBox.Text,
            };

            _bookService.CreateBook(book);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
