namespace LibraryGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_ManageBooks = new Button();
            button_ManageLoan = new Button();
            button_ManageReaders = new Button();
            dataGridView1 = new DataGridView();
            button_ManageCopies = new Button();
            button_ManageFines = new Button();
            button_Close = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_ManageBooks
            // 
            button_ManageBooks.Location = new Point(926, 116);
            button_ManageBooks.Name = "button_ManageBooks";
            button_ManageBooks.Size = new Size(174, 33);
            button_ManageBooks.TabIndex = 8;
            button_ManageBooks.Text = "Zarządzaj książkami";
            button_ManageBooks.UseVisualStyleBackColor = true;
            button_ManageBooks.Click += button_ManageBooks_Click;
            // 
            // button_ManageLoan
            // 
            button_ManageLoan.Location = new Point(926, 77);
            button_ManageLoan.Name = "button_ManageLoan";
            button_ManageLoan.Size = new Size(174, 33);
            button_ManageLoan.TabIndex = 9;
            button_ManageLoan.Text = "Zarządzaj wypożyczeniami";
            button_ManageLoan.UseVisualStyleBackColor = true;
            button_ManageLoan.Click += button_ManageLoan_Click;
            // 
            // button_ManageReaders
            // 
            button_ManageReaders.Location = new Point(926, 194);
            button_ManageReaders.Name = "button_ManageReaders";
            button_ManageReaders.Size = new Size(174, 33);
            button_ManageReaders.TabIndex = 10;
            button_ManageReaders.Text = "Zarządzaj czytelnikami";
            button_ManageReaders.UseVisualStyleBackColor = true;
            button_ManageReaders.Click += button_ManageReaders_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(910, 240);
            dataGridView1.TabIndex = 11;
            // 
            // button_ManageCopies
            // 
            button_ManageCopies.Location = new Point(926, 155);
            button_ManageCopies.Name = "button_ManageCopies";
            button_ManageCopies.Size = new Size(174, 33);
            button_ManageCopies.TabIndex = 12;
            button_ManageCopies.Text = "Zarządzaj egzemplarzami";
            button_ManageCopies.UseVisualStyleBackColor = true;
            button_ManageCopies.Click += button_ManageCopies_Click;
            // 
            // button_ManageFines
            // 
            button_ManageFines.Location = new Point(926, 233);
            button_ManageFines.Name = "button_ManageFines";
            button_ManageFines.Size = new Size(174, 33);
            button_ManageFines.TabIndex = 13;
            button_ManageFines.Text = "Zarządzaj karami";
            button_ManageFines.UseVisualStyleBackColor = true;
            button_ManageFines.Click += button_ManageFines_Click;
            // 
            // button_Close
            // 
            button_Close.BackColor = SystemColors.Info;
            button_Close.Location = new Point(926, 284);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(174, 33);
            button_Close.TabIndex = 14;
            button_Close.Text = "Zamknij program";
            button_Close.UseVisualStyleBackColor = false;
            button_Close.Click += button_Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(377, 20);
            label1.Name = "label1";
            label1.Size = new Size(203, 40);
            label1.TabIndex = 15;
            label1.Text = "Wypożyczenia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 328);
            Controls.Add(label1);
            Controls.Add(button_Close);
            Controls.Add(button_ManageFines);
            Controls.Add(button_ManageCopies);
            Controls.Add(dataGridView1);
            Controls.Add(button_ManageReaders);
            Controls.Add(button_ManageLoan);
            Controls.Add(button_ManageBooks);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Biblioteka";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_ManageBooks;
        private Button button_ManageLoan;
        private Button button_ManageReaders;
        private DataGridView dataGridView1;
        private Button button_ManageCopies;
        private Button button_ManageFines;
        private Button button_Close;
        private Label label1;
    }
}
