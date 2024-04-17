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
    public partial class FinesForm : Form
    {
        private readonly FineService _fineService;
        private readonly LoanService _loanService;
        public FinesForm()
        {
            InitializeComponent();
            _fineService = new FineService();
            _loanService = new LoanService();

            dataGridViewFines.DataSource = _fineService.GetAllFines();
            dataGridViewLoans.DataSource = _loanService.GetAllLoans();    
        }
        private void FinesForm_Load(object sender, EventArgs e)
        {
            comboBoxLoanId_addFine.DataSource = _fineService.GetAllFines();
            comboBoxLoanId_addFine.ValueMember = "Id";
        }

        private void addFineBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxLoanId_addFine.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(textBox_FineType.Text))
            {
                if (decimal.TryParse(numericUpDown_FineAmount.Text, out decimal fineAmount) && int.TryParse(comboBoxLoanId_addFine.SelectedValue.ToString(), out int loanId))
                {
                    var fine = new Fine
                    {
                        LoanId = loanId,
                        FineType = textBox_FineType.Text,
                        FineAmount = fineAmount,
                    };

                    _fineService.AddFine(fine);

                    MessageBox.Show("Kara została pomyślnie dodana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Podano nieprawidłową kwotę kary.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteFine_Click(object sender, EventArgs e)
        {

        }

        private void button_sumFine_Click(object sender, EventArgs e)
        {

        }
    }
}
