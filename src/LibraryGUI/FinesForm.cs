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
    public partial class FinesForm : Form
    {
        private readonly LoanService _loanService;
        private readonly FineService _fineService;
        public FinesForm()
        {
            InitializeComponent();
            _loanService = new LoanService();
            _fineService = new FineService();
        }
        private void FinesForm_Load(object sender, EventArgs e)
        {
            // Ustawianie nagłówków
            dataGridView_loans.DataSource = _loanService.LoadDataForGridView();
            dataGridView_loans.Columns["LoanId"].HeaderText = "ID";
            dataGridView_loans.Columns["BookTitle"].HeaderText = "Tytuł Książki";
            dataGridView_loans.Columns["ReaderFullName"].HeaderText = "Imię i nazwisko czytelnika";
            dataGridView_loans.Columns["LoanDate"].HeaderText = "Data Wypożyczenia";
            dataGridView_loans.Columns["ReturnDate"].HeaderText = "Data końca wypożyczenia";

            dataGridView_fines.DataSource = _fineService.GetAllFines();
            dataGridView_fines.Columns["Loan"].Visible = false;
            dataGridView_fines.Columns["FineType"].HeaderText = "Rodzaj kary";
            dataGridView_fines.Columns["LoandId"].HeaderText = "ID wypożyczenia";
            dataGridView_fines.Columns["FineAmount"].HeaderText = "Wielkość naliczonej kary";


            comboBoxLoanId_addFine.DataSource = _loanService.GetAllLoans();
            comboBoxLoanId_addFine.ValueMember = "Id";

            comboBox_fineId.DataSource = _fineService.GetAllFines();
            comboBox_fineId.ValueMember = "Id";
        }

        private void addFineBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxLoanId_addFine.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać wypożyczenie przed dodaniem kary.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int loanId = (int)comboBoxLoanId_addFine.SelectedValue;
            string fineType = textBox_FineType.Text;
            decimal fineAmount = numericUpDown_FineAmount.Value;
            var newFine = new Fine
            {
                LoandId = loanId,
                FineType = fineType,
                FineAmount = fineAmount
            };

            if (string.IsNullOrWhiteSpace(fineType))
            {
                MessageBox.Show("Proszę podać rodzaj kary.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fineAmount <= 0)
            {
                MessageBox.Show("Kwota kary musi być większa niż 0.", "Nieprawidłowa kwota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _fineService.AddFine(newFine);
                MessageBox.Show("Kara została pomyślnie dodana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_fines.DataSource = _fineService.GetAllFines();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas dodawania kary: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comboBox_fineId.DataSource = _fineService.GetAllFines();
            comboBox_fineId.ValueMember = "Id";
        }

        private void button_updateFine_Click(object sender, EventArgs e)
        {
            int selectedFineId = (int)comboBox_fineId.SelectedValue;

            var selectedFine = _fineService.GetFineById(selectedFineId);

            if (selectedFine != null)
            {
                string newFineType = string.IsNullOrWhiteSpace(textBox1.Text) ? selectedFine.FineType : textBox1.Text;
                decimal newFineAmount = numericUpDown1.Value;

                var updatedFine = new Fine
                {
                    Id = selectedFine.Id,
                    LoandId = selectedFine.LoandId,
                    FineType = newFineType,
                    FineAmount = newFineAmount
                };

                if (string.IsNullOrWhiteSpace(newFineType))
                {
                    MessageBox.Show("Proszę podać rodzaj kary.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newFineAmount <= 0)
                {
                    MessageBox.Show("Kwota kary musi być większa niż 0.", "Nieprawidłowa kwota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _fineService.UpdateFine(updatedFine);
                    MessageBox.Show("Kara została pomyślnie zaktualizowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_fines.DataSource = _fineService.GetAllFines();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas aktualizacji kary: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                comboBox_fineId.DataSource = _fineService.GetAllFines();
                comboBox_fineId.ValueMember = "Id";
            }
        }

        private void button_sumFine_Click(object sender, EventArgs e)
        {

        }
    }
}
