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
            textBox_Genre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            button_deleteBook = new Button();
            textBox_ID = new TextBox();
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
            authorTxtBox.Location = new Point(167, 45);
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
            titleTxtBox.Location = new Point(167, 16);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(562, 201);
            dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_Genre);
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
            // textBox_Genre
            // 
            textBox_Genre.Location = new Point(167, 72);
            textBox_Genre.Margin = new Padding(2);
            textBox_Genre.Name = "textBox_Genre";
            textBox_Genre.Size = new Size(159, 23);
            textBox_Genre.TabIndex = 16;
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
            groupBox2.Controls.Add(button_deleteBook);
            groupBox2.Controls.Add(textBox_ID);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 409);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 53);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuwanie";
            // 
            // button_deleteBook
            // 
            button_deleteBook.Location = new Point(337, 14);
            button_deleteBook.Name = "button_deleteBook";
            button_deleteBook.Size = new Size(217, 25);
            button_deleteBook.TabIndex = 4;
            button_deleteBook.Text = "Usuń książkę";
            button_deleteBook.UseVisualStyleBackColor = true;
            button_deleteBook.Click += button_deleteBook_Click;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(167, 16);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(159, 23);
            textBox_ID.TabIndex = 0;
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
            ClientSize = new Size(589, 472);
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
        private TextBox textBox_Genre;
        private Label label1;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private Button button_deleteBook;
        private TextBox textBox_ID;
        private Label label6;
    }
}