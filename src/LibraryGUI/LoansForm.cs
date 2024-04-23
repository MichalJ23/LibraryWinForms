using LibraryLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Form1 _parentForm;
        public LoansForm(Form1 form1)
        {
            InitializeComponent();
            _copyService = new CopyService();
            _readerService = new ReaderService();
            _loanService = new LoanService();
            _parentForm =  form1;
            this.loadData();
        }

        private void LoadAvailableBooks()
        {
            var availableBooks = _copyService.GetBooksAvailableForLoan();

            comboBoxBook_addLoan.Items.Clear();

            foreach (var book in availableBooks)
            {
                comboBoxBook_addLoan.Items.Add(book.Title);
            }
        }

        private void loadData()
        {
            this.LoadReaders();
            this.LoadAvailableBooks();
            dataGridView1.DataSource = _loanService.LoadDataForGridView();
            this.LoadLoansCombobox();

            // Ustawianie nagłówków
            dataGridView1.Columns["LoanId"].HeaderText = "ID";
            dataGridView1.Columns["BookTitle"].HeaderText = "Tytuł Książki";
            dataGridView1.Columns["ReaderFullName"].HeaderText = "Imię i nazwisko czytelnika";
            dataGridView1.Columns["LoanDate"].HeaderText = "Data Wypożyczenia";
            dataGridView1.Columns["ReturnDate"].HeaderText = "Data końca wypożyczenia";
        }

        private void LoadReaders()
        {
            var readers = _readerService.GetAllReaders();
            comboBoxReader_addLoan.Items.Clear();
            foreach (var reader in readers)
            {
                comboBoxReader_addLoan.Items.Add(reader.FullName);
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
                int selectedReaderId = -1;
                int selectedBookId = -1;

                // Pobierz ReaderId
                int selectedReaderIndex = comboBoxReader_addLoan.SelectedIndex;
                var selectedReader = _readerService.GetAllReaders().ToList()[selectedReaderIndex];
                selectedReaderId = selectedReader.Id;

                // Pobierz BookId
                int selectedBookIndex = comboBoxBook_addLoan.SelectedIndex;
                var selectedBook = _copyService.GetBooksAvailableForLoan().ToList()[selectedBookIndex];
                selectedBookId = selectedBook.Id;

                var loanDate = dateTimePicker_addLoan.Value;

                _loanService.AddLoan(selectedReaderId, selectedBookId, loanDate);
                MessageBox.Show("Pomyślnie dodano wypożyczenie");
                _parentForm.LoadData();
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
                MessageBox.Show("Pomyślnie zwrócono książkę");
                _parentForm.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Proszę wybrać identyfikator wypożyczenia przed zakończeniem wypożyczenia.");
            }
        }
    }
}
