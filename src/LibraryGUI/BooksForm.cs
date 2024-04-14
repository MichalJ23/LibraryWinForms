using LibraryLogic.Services;
using LibraryRepository.Models;
using LibraryRepository.Models.Nowy_folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            comboBox_ID.DataSource = _bookService.GetAllBooks();
            comboBox_ID.ValueMember = "Id";

            comboBox_genre.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (comboBox_genre.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać gatunek książki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedGenre = (Genre)comboBox_genre.SelectedItem;

            var book = new Book
            {
                Author = authorTxtBox.Text,
                PublicationDate = publicationDate.Value,
                Genre = selectedGenre,
                Title = titleTxtBox.Text,
            };

            _bookService.CreateBook(book);

            MessageBox.Show("Książka została pomyślnie dodana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = _bookService.GetAllBooks();
            comboBox_ID.DataSource = _bookService.GetAllBooks();
        }

        private void button_deleteBook_Click(object sender, EventArgs e)
        {
            if (comboBox_ID.SelectedIndex != -1)
            {
                if (!int.TryParse(comboBox_ID.SelectedValue?.ToString(), out int bookId))
                {
                    MessageBox.Show("Proszę wybrać poprawną książkę do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var book = new Book { Id = bookId };

                _bookService.DeleteBook(book);

                MessageBox.Show("Książka została pomyślnie usunięta.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = _bookService.GetAllBooks();
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę do usunięcia.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
