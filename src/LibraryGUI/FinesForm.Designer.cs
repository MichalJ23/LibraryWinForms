﻿namespace LibraryGUI
{
    partial class FinesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBoxId_deleteFine = new ComboBox();
            label4 = new Label();
            button_deleteFine = new Button();
            groupBox1 = new GroupBox();
            numericUpDown_FineAmount = new NumericUpDown();
            label6 = new Label();
            textBox_FineType = new TextBox();
            comboBoxLoanId_addFine = new ComboBox();
            label2 = new Label();
            addFineBtn = new Button();
            label5 = new Label();
            dataGridViewFines = new DataGridView();
            groupBox3 = new GroupBox();
            label7 = new Label();
            comboBox_reader = new ComboBox();
            label3 = new Label();
            button_sumFine = new Button();
            dataGridViewLoans = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FineAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFines).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 40);
            label1.TabIndex = 1;
            label1.Text = "Zarządzanie karami";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxId_deleteFine);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button_deleteFine);
            groupBox2.Location = new Point(12, 638);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 50);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Anulowanie";
            // 
            // comboBoxId_deleteFine
            // 
            comboBoxId_deleteFine.FormattingEnabled = true;
            comboBoxId_deleteFine.Location = new Point(167, 15);
            comboBoxId_deleteFine.Name = "comboBoxId_deleteFine";
            comboBoxId_deleteFine.Size = new Size(160, 23);
            comboBoxId_deleteFine.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 18;
            label4.Text = "Podaj Id kary";
            // 
            // button_deleteFine
            // 
            button_deleteFine.Location = new Point(337, 14);
            button_deleteFine.Name = "button_deleteFine";
            button_deleteFine.Size = new Size(217, 25);
            button_deleteFine.TabIndex = 4;
            button_deleteFine.Text = "Anuluj karę";
            button_deleteFine.UseVisualStyleBackColor = true;
            button_deleteFine.Click += button_deleteFine_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown_FineAmount);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox_FineType);
            groupBox1.Controls.Add(comboBoxLoanId_addFine);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(addFineBtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 522);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 110);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodawanie";
            // 
            // numericUpDown_FineAmount
            // 
            numericUpDown_FineAmount.Location = new Point(168, 74);
            numericUpDown_FineAmount.Name = "numericUpDown_FineAmount";
            numericUpDown_FineAmount.Size = new Size(161, 23);
            numericUpDown_FineAmount.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 76);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 18;
            label6.Text = "Podaj kwotę kary";
            // 
            // textBox_FineType
            // 
            textBox_FineType.Location = new Point(168, 45);
            textBox_FineType.Name = "textBox_FineType";
            textBox_FineType.Size = new Size(160, 23);
            textBox_FineType.TabIndex = 17;
            // 
            // comboBoxLoanId_addFine
            // 
            comboBoxLoanId_addFine.FormattingEnabled = true;
            comboBoxLoanId_addFine.Location = new Point(167, 16);
            comboBoxLoanId_addFine.Name = "comboBoxLoanId_addFine";
            comboBoxLoanId_addFine.Size = new Size(160, 23);
            comboBoxLoanId_addFine.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 15;
            label2.Text = "Podaj rodzaj kary";
            // 
            // addFineBtn
            // 
            addFineBtn.Location = new Point(338, 15);
            addFineBtn.Margin = new Padding(2);
            addFineBtn.Name = "addFineBtn";
            addFineBtn.Size = new Size(217, 23);
            addFineBtn.TabIndex = 14;
            addFineBtn.Text = "Dodaj karę";
            addFineBtn.UseVisualStyleBackColor = true;
            addFineBtn.Click += addFineBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 2;
            label5.Text = "Podaj Id wypożyczenia";
            // 
            // dataGridViewFines
            // 
            dataGridViewFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFines.Location = new Point(12, 67);
            dataGridViewFines.Name = "dataGridViewFines";
            dataGridViewFines.Size = new Size(562, 201);
            dataGridViewFines.TabIndex = 25;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(comboBox_reader);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button_sumFine);
            groupBox3.Location = new Point(12, 694);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(560, 80);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Podliczanie kary czytelnika";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(286, 62);
            label7.Name = "label7";
            label7.Size = new Size(215, 15);
            label7.TabIndex = 21;
            label7.Text = "Kwota do wpłacenia przez czytelnika to:";
            // 
            // comboBox_reader
            // 
            comboBox_reader.FormattingEnabled = true;
            comboBox_reader.Location = new Point(167, 15);
            comboBox_reader.Name = "comboBox_reader";
            comboBox_reader.Size = new Size(160, 23);
            comboBox_reader.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 18;
            label3.Text = "Podaj Id czytelnika";
            // 
            // button_sumFine
            // 
            button_sumFine.Location = new Point(337, 14);
            button_sumFine.Name = "button_sumFine";
            button_sumFine.Size = new Size(217, 25);
            button_sumFine.TabIndex = 4;
            button_sumFine.Text = "Podlicz";
            button_sumFine.UseVisualStyleBackColor = true;
            button_sumFine.Click += button_sumFine_Click;
            // 
            // dataGridViewLoans
            // 
            dataGridViewLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoans.Location = new Point(12, 306);
            dataGridViewLoans.Name = "dataGridViewLoans";
            dataGridViewLoans.Size = new Size(562, 201);
            dataGridViewLoans.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 49);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 30;
            label8.Text = "Kary:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 288);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 31;
            label9.Text = "Wypożyczenia:";
            // 
            // FinesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 778);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridViewLoans);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewFines);
            Controls.Add(label1);
            Name = "FinesForm";
            Text = "Zarządzanie Karami";
            Load += FinesForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FineAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFines).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBoxId_deleteFine;
        private Label label4;
        private Button button_deleteFine;
        private GroupBox groupBox1;
        private ComboBox comboBoxLoanId_addFine;
        private Label label2;
        private Button addFineBtn;
        private Label label5;
        private DataGridView dataGridViewFines;
        private NumericUpDown numericUpDown_FineAmount;
        private Label label6;
        private TextBox textBox_FineType;
        private GroupBox groupBox3;
        private ComboBox comboBox_reader;
        private Label label3;
        private Button button_sumFine;
        private Label label7;
        private DataGridView dataGridViewLoans;
        private Label label8;
        private Label label9;
    }
}