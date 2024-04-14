using LibraryLogic.Services;
using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryGUI
{
    public partial class BooksForm : Form
    {
        private readonly BookService _bookService;
        public BooksForm()
        {
            InitializeComponent();
            _bookService = new BookService();

            dataGridView1.DataSource = _bookService.GetAllBooks();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Author = authorTxtBox.Text,
                PublicationDate = publicationDate.Value,
                Genre = LibraryRepository.Models.Nowy_folder.Genre.Romantyczna,
                Title = titleTxtBox.Text,
            };

            _bookService.CreateBook(book);
        }

        private void button_deleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (!int.TryParse(textBox_ID.Text, out int bookId))
                {
                    MessageBox.Show("Proszę wprowadzić poprawne ID książki do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var book = new Book { Id = bookId };

                _bookService.DeleteBook(book);

                dataGridView1.DataSource = _bookService.GetAllBooks();
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę do usunięcia.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
