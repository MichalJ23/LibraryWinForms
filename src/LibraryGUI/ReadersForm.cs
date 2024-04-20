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
    public partial class ReadersForm : Form
    {
        private readonly ReaderService _readerService;
        public ReadersForm()
        {
            InitializeComponent();
            _readerService = new ReaderService();

            dataGridView1.DataSource = _readerService.GetAllReaders();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _readerService.GetAllReaders();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            dataGridView1.Columns["Loans"].Visible = false;
        }

        private void button_AddReader_Click(object sender, EventArgs e)
        {
            var reader = new Reader
            {
                FirstName = textBox_FirstName.Text,
                LastName = textBox_LastName.Text
            };
            _readerService.CreateReader(reader);

            MessageBox.Show("Czytelnik został pomyślnie dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.DataSource = _readerService.GetAllReaders();
            comboBox1.DataSource = _readerService.GetAllReaders();
        }

        private void button_updateReader_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                int selectedReaderId = (int)comboBox1.SelectedValue;

                var selectedReader = _readerService.GetReaderById(selectedReaderId);

                if (selectedReader != null)
                {
                    string newFirstName = string.IsNullOrWhiteSpace(textBox_firstNameUpdateReader.Text) ? selectedReader.FirstName : textBox_firstNameUpdateReader.Text;
                    string newLastName = string.IsNullOrWhiteSpace(textBox_lastNameUpdateReader.Text) ? selectedReader.LastName : textBox_lastNameUpdateReader.Text;

                    var updatedReader = new Reader
                    {
                        Id = selectedReader.Id,
                        FirstName = newFirstName,
                        LastName = newLastName
                    };

                    _readerService.UpdateReader(updatedReader);

                    MessageBox.Show("Dane czytelnika zostały pomyślnie zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = _readerService.GetAllReaders();
                    comboBox1.DataSource = _readerService.GetAllReaders();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono czytelnika o wybranym ID.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać czytelnika do aktualizacji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
