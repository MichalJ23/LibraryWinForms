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
            publicationDate_endLoan = new DateTimePicker();
            comboBoxId_endLoan = new ComboBox();
            label3 = new Label();
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
            label1.Location = new Point(116, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(590, 47);
            label1.TabIndex = 2;
            label1.Text = "Zarządzanie wypożyczeniami";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(publicationDate_endLoan);
            groupBox2.Controls.Add(comboBoxId_endLoan);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button_endLoan);
            groupBox2.Location = new Point(13, 612);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(800, 127);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oddanie";
            // 
            // publicationDate_endLoan
            // 
            publicationDate_endLoan.Location = new Point(239, 72);
            publicationDate_endLoan.Name = "publicationDate_endLoan";
            publicationDate_endLoan.Size = new Size(357, 31);
            publicationDate_endLoan.TabIndex = 21;
            // 
            // comboBoxId_endLoan
            // 
            comboBoxId_endLoan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxId_endLoan.FormattingEnabled = true;
            comboBoxId_endLoan.Location = new Point(239, 25);
            comboBoxId_endLoan.Margin = new Padding(4, 5, 4, 5);
            comboBoxId_endLoan.Name = "comboBoxId_endLoan";
            comboBoxId_endLoan.Size = new Size(227, 33);
            comboBoxId_endLoan.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 19;
            label3.Text = "Podaj datę oddania";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 18;
            label4.Text = "Podaj Id wypożyczenia";
            // 
            // button_endLoan
            // 
            button_endLoan.Location = new Point(481, 23);
            button_endLoan.Margin = new Padding(4, 5, 4, 5);
            button_endLoan.Name = "button_endLoan";
            button_endLoan.Size = new Size(310, 42);
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
            groupBox1.Location = new Point(13, 432);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(800, 170);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodawanie";
            // 
            // dateTimePicker_addLoan
            // 
            dateTimePicker_addLoan.Location = new Point(239, 123);
            dateTimePicker_addLoan.Name = "dateTimePicker_addLoan";
            dateTimePicker_addLoan.Size = new Size(357, 31);
            dateTimePicker_addLoan.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 123);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(210, 25);
            label6.TabIndex = 20;
            label6.Text = "Podaj datę wypożyczenia";
            // 
            // comboBoxReader_addLoan
            // 
            comboBoxReader_addLoan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReader_addLoan.FormattingEnabled = true;
            comboBoxReader_addLoan.Location = new Point(239, 73);
            comboBoxReader_addLoan.Margin = new Padding(4, 5, 4, 5);
            comboBoxReader_addLoan.Name = "comboBoxReader_addLoan";
            comboBoxReader_addLoan.Size = new Size(227, 33);
            comboBoxReader_addLoan.TabIndex = 17;
            // 
            // comboBoxBook_addLoan
            // 
            comboBoxBook_addLoan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBook_addLoan.FormattingEnabled = true;
            comboBoxBook_addLoan.Location = new Point(239, 27);
            comboBoxBook_addLoan.Margin = new Padding(4, 5, 4, 5);
            comboBoxBook_addLoan.Name = "comboBoxBook_addLoan";
            comboBoxBook_addLoan.Size = new Size(227, 33);
            comboBoxBook_addLoan.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 15;
            label2.Text = "Podaj czytelnika";
            // 
            // addLoanBtn
            // 
            addLoanBtn.Location = new Point(483, 25);
            addLoanBtn.Name = "addLoanBtn";
            addLoanBtn.Size = new Size(310, 38);
            addLoanBtn.TabIndex = 14;
            addLoanBtn.Text = "Zatwierdź wypożyczenie";
            addLoanBtn.UseVisualStyleBackColor = true;
            addLoanBtn.Click += addLoanBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 2;
            label5.Text = "Podaj książkę";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 87);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(803, 335);
            dataGridView1.TabIndex = 22;
            // 
            // LoansForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 755);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label3;
        private Label label4;
        private Button button_endLoan;
        private GroupBox groupBox1;
        private ComboBox comboBoxReader_addLoan;
        private ComboBox comboBoxBook_addLoan;
        private Label label2;
        private Button addLoanBtn;
        private Label label5;
        private DataGridView dataGridView1;
        private DateTimePicker publicationDate_endLoan;
        private DateTimePicker dateTimePicker_addLoan;
        private Label label6;
    }
}