using LibraryGUI.DTOs;
using LibraryLogic.Services;
using LibraryRepository.Models;
using System.Data;

namespace LibraryGUI
{
    public partial class Form1 : Form
    {
        private readonly LoanService _loanService;
        public Form1()
        {
            InitializeComponent();
            _loanService = new LoanService();

            dataGridView1.DataSource = _loanService.GetAllLoans();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_ManageLoan_Click(object sender, EventArgs e)
        {
            LoansForm loansForm = new LoansForm();
            loansForm.ShowDialog();
        }

        private void button_ManageBooks_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void button_ManageReaders_Click(object sender, EventArgs e)
        {
            ReadersForm readersForm = new ReadersForm();
            readersForm.ShowDialog();
        }

        private void button_ManageCopies_Click(object sender, EventArgs e)
        {
            CopiesForm copiesForm = new CopiesForm();
            copiesForm.ShowDialog();
        }

        private void button_ManageFines_Click(object sender, EventArgs e)
        {
            FinesForm finesForm = new FinesForm();
            finesForm.ShowDialog();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
