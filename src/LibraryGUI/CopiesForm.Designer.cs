namespace LibraryGUI
{
    partial class CopiesForm
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
            numericUpDownBook_deleteCopies = new NumericUpDown();
            comboBoxBook_deleteCopies = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button_deleteCopies = new Button();
            groupBox1 = new GroupBox();
            numericUpDownBook_addCopies = new NumericUpDown();
            comboBoxBook_addCopies = new ComboBox();
            label2 = new Label();
            addCopiesBtn = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBook_deleteCopies).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBook_addCopies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(93, 6);
            label1.Name = "label1";
            label1.Size = new Size(387, 40);
            label1.TabIndex = 0;
            label1.Text = "Zarządzanie egzemplarzami";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDownBook_deleteCopies);
            groupBox2.Controls.Add(comboBoxBook_deleteCopies);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button_deleteCopies);
            groupBox2.Location = new Point(12, 338);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 76);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuwanie";
            // 
            // numericUpDownBook_deleteCopies
            // 
            numericUpDownBook_deleteCopies.Location = new Point(167, 44);
            numericUpDownBook_deleteCopies.Name = "numericUpDownBook_deleteCopies";
            numericUpDownBook_deleteCopies.Size = new Size(161, 23);
            numericUpDownBook_deleteCopies.TabIndex = 21;
            // 
            // comboBoxBook_deleteCopies
            // 
            comboBoxBook_deleteCopies.FormattingEnabled = true;
            comboBoxBook_deleteCopies.Location = new Point(167, 15);
            comboBoxBook_deleteCopies.Name = "comboBoxBook_deleteCopies";
            comboBoxBook_deleteCopies.Size = new Size(160, 23);
            comboBoxBook_deleteCopies.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 19;
            label3.Text = "Podaj ilość egzemplarzy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 18;
            label4.Text = "Podaj książkę";
            // 
            // button_deleteCopies
            // 
            button_deleteCopies.Location = new Point(337, 14);
            button_deleteCopies.Name = "button_deleteCopies";
            button_deleteCopies.Size = new Size(217, 25);
            button_deleteCopies.TabIndex = 4;
            button_deleteCopies.Text = "Usuń egzemplarze";
            button_deleteCopies.UseVisualStyleBackColor = true;
            button_deleteCopies.Click += button_deleteCopies_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownBook_addCopies);
            groupBox1.Controls.Add(comboBoxBook_addCopies);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(addCopiesBtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 76);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodawanie";
            // 
            // numericUpDownBook_addCopies
            // 
            numericUpDownBook_addCopies.Location = new Point(167, 45);
            numericUpDownBook_addCopies.Name = "numericUpDownBook_addCopies";
            numericUpDownBook_addCopies.Size = new Size(161, 23);
            numericUpDownBook_addCopies.TabIndex = 17;
            // 
            // comboBoxBook_addCopies
            // 
            comboBoxBook_addCopies.FormattingEnabled = true;
            comboBoxBook_addCopies.Location = new Point(167, 16);
            comboBoxBook_addCopies.Name = "comboBoxBook_addCopies";
            comboBoxBook_addCopies.Size = new Size(160, 23);
            comboBoxBook_addCopies.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 15;
            label2.Text = "Podaj ilość egzemplarzy";
            // 
            // addCopiesBtn
            // 
            addCopiesBtn.Location = new Point(338, 15);
            addCopiesBtn.Margin = new Padding(2);
            addCopiesBtn.Name = "addCopiesBtn";
            addCopiesBtn.Size = new Size(217, 23);
            addCopiesBtn.TabIndex = 14;
            addCopiesBtn.Text = "Dodaj ilość egzemplarzy";
            addCopiesBtn.UseVisualStyleBackColor = true;
            addCopiesBtn.Click += addCopiesBtn_Click;
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
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(562, 201);
            dataGridView1.TabIndex = 19;
            // 
            // CopiesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 421);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CopiesForm";
            Text = "Zarządzanie Egzemplarzami";
            Load += CopiesForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBook_deleteCopies).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBook_addCopies).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBox_ID;
        private Button button_deleteCopies;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox comboBoxBook_addCopies;
        private Label label2;
        private Button addCopiesBtn;
        private Label label5;
        private DateTimePicker publicationDate;
        private TextBox titleTxtBox;
        private TextBox authorTxtBox;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDownBook_deleteCopies;
        private ComboBox comboBoxBook_deleteCopies;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownBook_addCopies;
    }
}