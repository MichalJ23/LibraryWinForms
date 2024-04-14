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

namespace LibraryGUI
{
    public partial class CopiesForm : Form
    {
        private readonly CopyService _copyService;
        private readonly BookService _bookService;
        public CopiesForm()
        {
            InitializeComponent();
            _copyService = new CopyService();
            _bookService = new BookService();
            dataGridView1.DataSource = _copyService.GetAllCopies();
        }
        private void CopiesForm_Load(object sender, EventArgs e)
        {
            comboBoxBook_addCopies.DataSource = _bookService.GetAllBooks();
            comboBoxBook_addCopies.DisplayMember = "Title";
            comboBoxBook_addCopies.ValueMember = "Id";

            comboBoxBook_deleteCopies.DataSource = _bookService.GetAllBooks();
            comboBoxBook_deleteCopies.ValueMember = "Title";
            comboBoxBook_deleteCopies.ValueMember = "Id";
        }

        private void addCopiesBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxBook_addCopies.SelectedIndex != -1)
            {
                int bookId = (int)comboBoxBook_addCopies.SelectedValue;

                int copiesToAdd = (int)numericUpDownBook_addCopies.Value;

                _copyService.AddCopy(bookId, copiesToAdd);

                MessageBox.Show($"Dodano {copiesToAdd} egzemplarzy książki.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = _copyService.GetAllCopies();
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_deleteCopies_Click(object sender, EventArgs e)
        {
            if (comboBoxBook_deleteCopies.SelectedIndex != -1)
            {
                int bookId = (int)comboBoxBook_deleteCopies.SelectedValue;

                int copiesToDelete = (int)numericUpDownBook_deleteCopies.Value;

                var bookCopy = _copyService.GetAllCopies().FirstOrDefault(c => c.BookId == bookId);

                if (bookCopy != null && bookCopy.AvailableQuantity >= copiesToDelete)
                {
                    var copyId = _copyService.GetAllCopies().FirstOrDefault(c => c.BookId == bookId)?.Id;

                    if (copyId.HasValue)
                    {
                        _copyService.DeleteCopy(copyId.Value, copiesToDelete);

                        MessageBox.Show($"Usunięto {copiesToDelete} egzemplarzy książki.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = _copyService.GetAllCopies();
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono egzemplarza książki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Podana ilość egzemplarzy do usunięcia przekracza dostępną ilość.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
