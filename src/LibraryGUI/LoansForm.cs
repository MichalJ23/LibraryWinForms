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
    public partial class LoansForm : Form
    {
        private readonly CopyService _copyService;
        private readonly ReaderService _readerService;
        private readonly LoanService _loanService;

        public LoansForm()
        {
            InitializeComponent();
            _copyService = new CopyService();
            _readerService = new ReaderService();
            _loanService = new LoanService();
            this.loadData();
        }

        private void LoadAvailableBooks()
        {
            var availableBooks = _copyService.GetBooksAvailableForLoan();

            comboBoxBook_addLoan.Items.Clear();
            comboBoxBook_addLoan.DisplayMember = "Title";
            comboBoxBook_addLoan.ValueMember = null;

            foreach (var book in availableBooks)
            {
                comboBoxBook_addLoan.Items.Add(book);
            }
        }

        private void loadData()
        {
            this.LoadReaders();
            this.LoadAvailableBooks();
            dataGridView1.DataSource = _loanService.GetAllLoans();
            this.LoadLoansCombobox();
        }

        private void LoadReaders()
        {
            var readers = _readerService.GetAllReaders();
            comboBoxReader_addLoan.Items.Clear();
            comboBoxReader_addLoan.DisplayMember = "FirstName";
            comboBoxReader_addLoan.ValueMember = null;

            foreach (var reader in readers)
            {
                comboBoxReader_addLoan.Items.Add(reader);
            }
        }

        private void LoadLoansCombobox()
        {
            comboBoxId_endLoan.Items.Clear();
            var loans = _loanService.GetAllLoans();

            comboBoxId_endLoan.Items.Clear();
            foreach (var loan in loans)
            {
                comboBoxId_endLoan.Items.Add(loan.Id);
            }

        }

        private void LoansForm_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void addLoanBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxReader_addLoan.SelectedItem != null && comboBoxBook_addLoan.SelectedItem != null)
            {
                var selectedReader = (Reader)comboBoxReader_addLoan.SelectedItem;
                var selectedReaderId = selectedReader.Id;

                var selectedBook = (Book)comboBoxBook_addLoan.SelectedItem;
                var selectedBookId = selectedBook.Id;

                var loanDate = dateTimePicker_addLoan.Value;

                var copyId = _copyService.GetCopyIdByBookId(selectedBookId);
                var copy = _copyService.GetCopyById(copyId);

                if ( copy.AvailableQuantity <= 0 || copy is null)
                {
                    MessageBox.Show("Wybrana książka nie jest dostępna do wypożyczenia.");
                    return;
                }

                _loanService.AddLoan(selectedReaderId, selectedBookId, loanDate);
                MessageBox.Show("Pomyślnie utworzono wypożyczenie.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Proszę wybrać czytelnika i książkę przed dodaniem wypożyczenia.");
            }
        }



        private void button_endLoan_Click(object sender, EventArgs e)
        {
            if (comboBoxId_endLoan.SelectedItem != null)
            {
                int loanId = (int)comboBoxId_endLoan.SelectedItem;
                _loanService.ReturnLoan(loanId);
                MessageBox.Show("Pomyślnie zwrócono książkę.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Proszę wybrać identyfikator wypożyczenia przed zakończeniem wypożyczenia.");
            }
        }
    }
}
