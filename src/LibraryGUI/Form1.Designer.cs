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
            titleTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            publicationDate = new DateTimePicker();
            author = new Label();
            authorTxtBox = new TextBox();
            addBookBtn = new Button();
            SuspendLayout();
            // 
            // titleTxtBox
            // 
            titleTxtBox.Location = new Point(12, 47);
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(150, 31);
            titleTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 1;
            label1.Text = "Tytuł";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 3;
            label2.Text = "Data publikacji";
            // 
            // publicationDate
            // 
            publicationDate.Location = new Point(12, 109);
            publicationDate.Name = "publicationDate";
            publicationDate.Size = new Size(357, 31);
            publicationDate.TabIndex = 4;
            // 
            // author
            // 
            author.AutoSize = true;
            author.Location = new Point(12, 151);
            author.Name = "author";
            author.Size = new Size(57, 25);
            author.TabIndex = 6;
            author.Text = "Autor";
            // 
            // authorTxtBox
            // 
            authorTxtBox.Location = new Point(12, 179);
            authorTxtBox.Name = "authorTxtBox";
            authorTxtBox.Size = new Size(150, 31);
            authorTxtBox.TabIndex = 5;
            // 
            // addBookBtn
            // 
            addBookBtn.Location = new Point(12, 216);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(175, 34);
            addBookBtn.TabIndex = 7;
            addBookBtn.Text = "Dodaj książkę";
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addBookBtn);
            Controls.Add(author);
            Controls.Add(authorTxtBox);
            Controls.Add(publicationDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(titleTxtBox);
            Name = "Form1";
            Text = "bookTitle";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTxtBox;
        private Label label1;
        private Label label2;
        private DateTimePicker publicationDate;
        private Label author;
        private TextBox authorTxtBox;
        private Button addBookBtn;
    }
}
