namespace LibraryGUI
{
    partial class LoansForm
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
            comboBoxId_endLoan = new ComboBox();
            label4 = new Label();
            button_endLoan = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker_addLoan = new DateTimePicker();
            label6 = new Label();
            comboBoxReader_addLoan = new ComboBox();
            comboBoxBook_addLoan = new ComboBox();
            label2 = new Label();
            addLoanBtn = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(396, 31);
            label1.TabIndex = 2;
            label1.Text = "Zarządzanie wypożyczeniami";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxId_endLoan);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button_endLoan);
            groupBox2.Location = new Point(9, 367);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 47);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oddanie";
            // 
            // comboBoxId_endLoan
            // 
            comboBoxId_endLoan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxId_endLoan.FormattingEnabled = true;
            comboBoxId_endLoan.Location = new Point(167, 15);
            comboBoxId_endLoan.Name = "comboBoxId_endLoan";
            comboBoxId_endLoan.Size = new Size(160, 23);
            comboBoxId_endLoan.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 18;
            label4.Text = "Podaj Id wypożyczenia";
            // 
            // button_endLoan
            // 
            button_endLoan.Location = new Point(337, 14);
            button_endLoan.Name = "button_endLoan";
            button_endLoan.Size = new Size(217, 25);
            button_endLoan.TabIndex = 4;
            button_endLoan.Text = "Zakończ wypożyczenie";
            button_endLoan.UseVisualStyleBackColor = true;
            button_endLoan.Click += button_endLoan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker_addLoan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxReader_addLoan);
            groupBox1.Controls.Add(comboBoxBook_addLoan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(addLoanBtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(9, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 102);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodawanie";
            // 
            // dateTimePicker_addLoan
            // 
            dateTimePicker_addLoan.Location = new Point(167, 74);
            dateTimePicker_addLoan.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker_addLoan.Name = "dateTimePicker_addLoan";
            dateTimePicker_addLoan.Size = new Size(251, 23);
            dateTimePicker_addLoan.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 20;
            label6.Text = "Podaj datę wypożyczenia";
            // 
            // comboBoxReader_addLoan
            // 
            comboBoxReader_addLoan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReader_addLoan.FormattingEnabled = true;
            comboBoxReader_addLoan.Location = new Point(167, 44);
            comboBoxReader_addLoan.Name = "comboBoxReader_addLoan";
            comboBoxReader_addLoan.Size = new Size(160, 23);
            comboBoxReader_addLoan.TabIndex = 17;
            // 
            // comboBoxBook_addLoan
            // 
            comboBoxBook_addLoan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBook_addLoan.FormattingEnabled = true;
            comboBoxBook_addLoan.Location = new Point(167, 16);
            comboBoxBook_addLoan.Name = "comboBoxBook_addLoan";
            comboBoxBook_addLoan.Size = new Size(160, 23);
            comboBoxBook_addLoan.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 15;
            label2.Text = "Podaj czytelnika";
            // 
            // addLoanBtn
            // 
            addLoanBtn.Location = new Point(338, 15);
            addLoanBtn.Margin = new Padding(2, 2, 2, 2);
            addLoanBtn.Name = "addLoanBtn";
            addLoanBtn.Size = new Size(217, 23);
            addLoanBtn.TabIndex = 14;
            addLoanBtn.Text = "Zatwierdź wypożyczenie";
            addLoanBtn.UseVisualStyleBackColor = true;
            addLoanBtn.Click += addLoanBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 2;
            label5.Text = "Podaj książkę";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(562, 201);
            dataGridView1.TabIndex = 22;
            // 
            // LoansForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 420);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "LoansForm";
            Text = "Zarządzanie wypożyczeniami";
            Load += LoansForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBoxId_endLoan;
        private Label label4;
        private Button button_endLoan;
        private GroupBox groupBox1;
        private ComboBox comboBoxReader_addLoan;
        private ComboBox comboBoxBook_addLoan;
        private Label label2;
        private Button addLoanBtn;
        private Label label5;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker_addLoan;
        private Label label6;
    }
}