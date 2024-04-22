namespace LibraryGUI
{
    partial class BooksForm
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
            addBookBtn = new Button();
            authorTxtBox = new TextBox();
            publicationDate = new DateTimePicker();
            label2 = new Label();
            titleTxtBox = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            comboBox_genre = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            dateTimePicker_updateBook = new DateTimePicker();
            label10 = new Label();
            comboBox_genreUpdateBook = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            textBox_authorUpdateBook = new TextBox();
            label7 = new Label();
            textBox_titleUpdateBook = new TextBox();
            comboBox_ID = new ComboBox();
            button_updateBook = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // addBookBtn
            // 
            addBookBtn.Location = new Point(338, 15);
            addBookBtn.Margin = new Padding(2);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(217, 23);
            addBookBtn.TabIndex = 14;
            addBookBtn.Text = "Dodaj książkę";
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // authorTxtBox
            // 
            authorTxtBox.Location = new Point(166, 43);
            authorTxtBox.Margin = new Padding(2);
            authorTxtBox.Name = "authorTxtBox";
            authorTxtBox.Size = new Size(159, 23);
            authorTxtBox.TabIndex = 12;
            // 
            // publicationDate
            // 
            publicationDate.Location = new Point(167, 99);
            publicationDate.Margin = new Padding(2);
            publicationDate.Name = "publicationDate";
            publicationDate.Size = new Size(251, 23);
            publicationDate.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 10;
            label2.Text = "Data publikacji";
            // 
            // titleTxtBox
            // 
            titleTxtBox.Location = new Point(166, 16);
            titleTxtBox.Margin = new Padding(2);
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(159, 23);
            titleTxtBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(131, 9);
            label3.Name = "label3";
            label3.Size = new Size(313, 40);
            label3.TabIndex = 15;
            label3.Text = "Zarządzanie książkami";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(562, 201);
            dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_genre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(addBookBtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(publicationDate);
            groupBox1.Controls.Add(titleTxtBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(authorTxtBox);
            groupBox1.Location = new Point(12, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 131);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodawanie";
            // 
            // comboBox_genre
            // 
            comboBox_genre.FormattingEnabled = true;
            comboBox_genre.Location = new Point(166, 71);
            comboBox_genre.Name = "comboBox_genre";
            comboBox_genre.Size = new Size(160, 23);
            comboBox_genre.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 75);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 15;
            label1.Text = "Podaj gatunek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Podaj autora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 2;
            label5.Text = "Podaj tytuł książki";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker_updateBook);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(comboBox_genreUpdateBook);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox_authorUpdateBook);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox_titleUpdateBook);
            groupBox2.Controls.Add(comboBox_ID);
            groupBox2.Controls.Add(button_updateBook);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 409);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 157);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edytowanie";
            // 
            // dateTimePicker_updateBook
            // 
            dateTimePicker_updateBook.Location = new Point(165, 127);
            dateTimePicker_updateBook.Margin = new Padding(2);
            dateTimePicker_updateBook.Name = "dateTimePicker_updateBook";
            dateTimePicker_updateBook.Size = new Size(251, 23);
            dateTimePicker_updateBook.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 133);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 17;
            label10.Text = "Data publikacji";
            // 
            // comboBox_genreUpdateBook
            // 
            comboBox_genreUpdateBook.FormattingEnabled = true;
            comboBox_genreUpdateBook.Location = new Point(165, 99);
            comboBox_genreUpdateBook.Name = "comboBox_genreUpdateBook";
            comboBox_genreUpdateBook.Size = new Size(160, 23);
            comboBox_genreUpdateBook.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 102);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 21;
            label9.Text = "Podaj gatunek";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 74);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 20;
            label8.Text = "Podaj autora";
            // 
            // textBox_authorUpdateBook
            // 
            textBox_authorUpdateBook.Location = new Point(166, 71);
            textBox_authorUpdateBook.Margin = new Padding(2);
            textBox_authorUpdateBook.Name = "textBox_authorUpdateBook";
            textBox_authorUpdateBook.Size = new Size(159, 23);
            textBox_authorUpdateBook.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 47);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 18;
            label7.Text = "Podaj tytuł książki";
            // 
            // textBox_titleUpdateBook
            // 
            textBox_titleUpdateBook.Location = new Point(166, 44);
            textBox_titleUpdateBook.Margin = new Padding(2);
            textBox_titleUpdateBook.Name = "textBox_titleUpdateBook";
            textBox_titleUpdateBook.Size = new Size(159, 23);
            textBox_titleUpdateBook.TabIndex = 17;
            // 
            // comboBox_ID
            // 
            comboBox_ID.FormattingEnabled = true;
            comboBox_ID.Location = new Point(166, 16);
            comboBox_ID.Name = "comboBox_ID";
            comboBox_ID.Size = new Size(159, 23);
            comboBox_ID.TabIndex = 17;
            // 
            // button_updateBook
            // 
            button_updateBook.Location = new Point(337, 14);
            button_updateBook.Name = "button_updateBook";
            button_updateBook.Size = new Size(217, 25);
            button_updateBook.TabIndex = 4;
            button_updateBook.Text = "Zaktualizuj książkę";
            button_updateBook.UseVisualStyleBackColor = true;
            button_updateBook.Click += button_updateBook_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 2;
            label6.Text = "Podaj ID książki";
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 578);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Name = "BooksForm";
            Text = "Zarządzanie Książkami";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBookBtn;
        private TextBox authorTxtBox;
        private DateTimePicker publicationDate;
        private Label label2;
        private TextBox titleTxtBox;
        private Label label3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private Button button_updateBook;
        private Label label6;
        private ComboBox comboBox_genre;
        private ComboBox comboBox_ID;
        private DateTimePicker dateTimePicker_updateBook;
        private Label label10;
        private ComboBox comboBox_genreUpdateBook;
        private Label label9;
        private Label label8;
        private TextBox textBox_authorUpdateBook;
        private Label label7;
        private TextBox textBox_titleUpdateBook;
    }
}