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
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            label7 = new Label();
            comboBox_reader = new ComboBox();
            label3 = new Label();
            button_sumFine = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FineAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown_FineAmount);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox_FineType);
            groupBox1.Controls.Add(comboBoxLoanId_addFine);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(addFineBtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 259);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(562, 201);
            dataGridView1.TabIndex = 25;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(comboBox_reader);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button_sumFine);
            groupBox3.Location = new Point(12, 375);
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
            // 
            // FinesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 520);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FinesForm";
            Text = "Zarządzanie Karami";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FineAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown_FineAmount;
        private Label label6;
        private TextBox textBox_FineType;
        private GroupBox groupBox3;
        private ComboBox comboBox_reader;
        private Label label3;
        private Button button_sumFine;
        private Label label7;
    }
}