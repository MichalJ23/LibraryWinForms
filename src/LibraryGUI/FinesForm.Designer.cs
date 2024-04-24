namespace LibraryGUI
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
            groupBox1 = new GroupBox();
            numericUpDown_FineAmount = new NumericUpDown();
            label6 = new Label();
            textBox_FineType = new TextBox();
            comboBoxLoanId_addFine = new ComboBox();
            label2 = new Label();
            addFineBtn = new Button();
            label5 = new Label();
            dataGridView_loans = new DataGridView();
            dataGridView_fines = new DataGridView();
            label4 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            textBox1 = new TextBox();
            comboBox_fineId = new ComboBox();
            label10 = new Label();
            button_updateFine = new Button();
            label11 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FineAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_loans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_fines).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(181, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(403, 47);
            label1.TabIndex = 1;
            label1.Text = "Zarządzanie karami";
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
            groupBox1.Location = new Point(17, 858);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(800, 183);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodawanie";
            // 
            // numericUpDown_FineAmount
            // 
            numericUpDown_FineAmount.Location = new Point(240, 123);
            numericUpDown_FineAmount.Margin = new Padding(4, 5, 4, 5);
            numericUpDown_FineAmount.Name = "numericUpDown_FineAmount";
            numericUpDown_FineAmount.Size = new Size(230, 31);
            numericUpDown_FineAmount.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 127);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 18;
            label6.Text = "Podaj kwotę kary";
            // 
            // textBox_FineType
            // 
            textBox_FineType.Location = new Point(240, 75);
            textBox_FineType.Margin = new Padding(4, 5, 4, 5);
            textBox_FineType.Name = "textBox_FineType";
            textBox_FineType.Size = new Size(227, 31);
            textBox_FineType.TabIndex = 17;
            // 
            // comboBoxLoanId_addFine
            // 
            comboBoxLoanId_addFine.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoanId_addFine.FormattingEnabled = true;
            comboBoxLoanId_addFine.Location = new Point(239, 27);
            comboBoxLoanId_addFine.Margin = new Padding(4, 5, 4, 5);
            comboBoxLoanId_addFine.Name = "comboBoxLoanId_addFine";
            comboBoxLoanId_addFine.Size = new Size(227, 33);
            comboBoxLoanId_addFine.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 15;
            label2.Text = "Podaj rodzaj kary";
            // 
            // addFineBtn
            // 
            addFineBtn.Location = new Point(483, 25);
            addFineBtn.Name = "addFineBtn";
            addFineBtn.Size = new Size(310, 38);
            addFineBtn.TabIndex = 14;
            addFineBtn.Text = "Dodaj karę";
            addFineBtn.UseVisualStyleBackColor = true;
            addFineBtn.Click += addFineBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 2;
            label5.Text = "Podaj Id wypożyczenia";
            // 
            // dataGridView_loans
            // 
            dataGridView_loans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_loans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_loans.Location = new Point(17, 128);
            dataGridView_loans.Margin = new Padding(4, 5, 4, 5);
            dataGridView_loans.Name = "dataGridView_loans";
            dataGridView_loans.RowHeadersVisible = false;
            dataGridView_loans.RowHeadersWidth = 62;
            dataGridView_loans.Size = new Size(803, 335);
            dataGridView_loans.TabIndex = 25;
            // 
            // dataGridView_fines
            // 
            dataGridView_fines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_fines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_fines.Location = new Point(17, 513);
            dataGridView_fines.Margin = new Padding(4, 5, 4, 5);
            dataGridView_fines.Name = "dataGridView_fines";
            dataGridView_fines.RowHeadersVisible = false;
            dataGridView_fines.RowHeadersWidth = 62;
            dataGridView_fines.Size = new Size(803, 335);
            dataGridView_fines.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 30;
            label4.Text = "Wypożyczenia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 483);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 25);
            label8.TabIndex = 31;
            label8.Text = "Kary";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(comboBox_fineId);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(button_updateFine);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(17, 1052);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(800, 183);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edytowanie";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(240, 123);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(230, 31);
            numericUpDown1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 127);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(147, 25);
            label9.TabIndex = 18;
            label9.Text = "Podaj kwotę kary";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 75);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 31);
            textBox1.TabIndex = 17;
            // 
            // comboBox_fineId
            // 
            comboBox_fineId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_fineId.FormattingEnabled = true;
            comboBox_fineId.Location = new Point(239, 27);
            comboBox_fineId.Margin = new Padding(4, 5, 4, 5);
            comboBox_fineId.Name = "comboBox_fineId";
            comboBox_fineId.Size = new Size(227, 33);
            comboBox_fineId.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 80);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(148, 25);
            label10.TabIndex = 15;
            label10.Text = "Podaj rodzaj kary";
            // 
            // button_updateFine
            // 
            button_updateFine.Location = new Point(483, 25);
            button_updateFine.Name = "button_updateFine";
            button_updateFine.Size = new Size(310, 38);
            button_updateFine.TabIndex = 14;
            button_updateFine.Text = "Zaktualizuj karę";
            button_updateFine.UseVisualStyleBackColor = true;
            button_updateFine.Click += button_updateFine_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 32);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(115, 25);
            label11.TabIndex = 2;
            label11.Text = "Podaj Id kary";
            // 
            // FinesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 1252);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(dataGridView_fines);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView_loans);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FinesForm";
            Text = "Zarządzanie Karami";
            Load += FinesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FineAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_loans).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_fines).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBoxLoanId_addFine;
        private Label label2;
        private Button addFineBtn;
        private Label label5;
        private DataGridView dataGridView_loans;
        private NumericUpDown numericUpDown_FineAmount;
        private Label label6;
        private TextBox textBox_FineType;
        private DataGridView dataGridView_fines;
        private Label label4;
        private Label label8;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private TextBox textBox1;
        private ComboBox comboBox_fineId;
        private Label label10;
        private Button button_updateFine;
        private Label label11;
    }
}