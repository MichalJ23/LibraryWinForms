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
        }

        private void button_AddReader_Click(object sender, EventArgs e)
        {
            var reader = new Reader
            {
                FirstName = textBox_FirstName.Text,
                LastName = textBox_LastName.Text
            };
            _readerService.CreateReader(reader);

            dataGridView1.DataSource = _readerService.GetAllReaders();
            comboBox1.DataSource = _readerService.GetAllReaders();
        }

        private void button_deleteReader_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                int readerId = (int)comboBox1.SelectedValue;

                var reader = new Reader { Id = readerId };

                _readerService.DeleteReader(reader);

                comboBox1.DataSource = _readerService.GetAllReaders();

                MessageBox.Show("Czytelnik został pomyślnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = _readerService.GetAllReaders();
            }
            else
            {
                MessageBox.Show("Proszę wybrać czytelnika do usunięcia.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
