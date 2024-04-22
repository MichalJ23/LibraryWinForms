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
            comboBox_genreUpdateBook.DataSource = Enum.GetValues(typeof(Genre));

            dataGridView1.Columns["Copies"].Visible = false;

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

            authorTxtBox.Clear();
            titleTxtBox.Clear();

            dataGridView1.DataSource = _bookService.GetAllBooks();
            comboBox_ID.DataSource = _bookService.GetAllBooks();
        }

        private void button_updateBook_Click_1(object sender, EventArgs e)
        {
            if (comboBox_ID.SelectedIndex != -1)
            {
                int selectedBookId = (int)comboBox_ID.SelectedValue;

                var selectedBook = _bookService.GetBookById(selectedBookId);

                if (selectedBook != null)
                {
                    string newAuthor = string.IsNullOrWhiteSpace(textBox_authorUpdateBook.Text) ? selectedBook.Author : textBox_authorUpdateBook.Text;
                    string newTitle = string.IsNullOrWhiteSpace(textBox_titleUpdateBook.Text) ? selectedBook.Title : textBox_titleUpdateBook.Text;
                    Genre newGenre = (Genre)comboBox_genre.SelectedItem;
                    DateTime newPublicationDate = dateTimePicker_updateBook.Value;

                    var updatedBook = new Book
                    {
                        Id = selectedBook.Id,
                        Author = newAuthor,
                        Title = newTitle,
                        Genre = newGenre,
                        PublicationDate = newPublicationDate
                    };

                    _bookService.UpdateBook(updatedBook);

                    dataGridView1.DataSource = _bookService.GetAllBooks();

                    MessageBox.Show("Książka została pomyślnie zaktualizowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_authorUpdateBook.Clear();
                    textBox_titleUpdateBook.Clear();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono książki o wybranym ID.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać ID książki do zaktualizowania.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
