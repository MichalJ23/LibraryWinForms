namespace LibraryGUI
{
    partial class ReadersForm
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
            groupBox1 = new GroupBox();
            button_AddReader = new Button();
            textBox_FirstName = new TextBox();
            label2 = new Label();
            textBox_LastName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button_deleteReader = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_AddReader);
            groupBox1.Controls.Add(textBox_FirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_LastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 84);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodawanie";
            // 
            // button_AddReader
            // 
            button_AddReader.Location = new Point(337, 14);
            button_AddReader.Name = "button_AddReader";
            button_AddReader.Size = new Size(217, 25);
            button_AddReader.TabIndex = 4;
            button_AddReader.Text = "Dodaj czytelnika";
            button_AddReader.UseVisualStyleBackColor = true;
            button_AddReader.Click += button_AddReader_Click;
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Location = new Point(167, 16);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(159, 23);
            textBox_FirstName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(143, 15);
            label2.TabIndex = 3;
            label2.Text = "Podaj nazwisko czytelnika";
            // 
            // textBox_LastName
            // 
            textBox_LastName.Location = new Point(167, 53);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(159, 23);
            textBox_LastName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "Podaj imię czytelnika";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button_deleteReader);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(14, 371);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 53);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuwanie";
            // 
            // button_deleteReader
            // 
            button_deleteReader.Location = new Point(337, 14);
            button_deleteReader.Name = "button_deleteReader";
            button_deleteReader.Size = new Size(217, 25);
            button_deleteReader.TabIndex = 4;
            button_deleteReader.Text = "Usuń czytelnika";
            button_deleteReader.UseVisualStyleBackColor = true;
            button_deleteReader.Click += button_deleteReader_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 2;
            label4.Text = "Podaj ID czytelnika";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(562, 201);
            dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(128, 9);
            label3.Name = "label3";
            label3.Size = new Size(348, 40);
            label3.TabIndex = 16;
            label3.Text = "Zarządzanie czytelnikami";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 5;
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 438);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReadersForm";
            Text = "Zarządzanie Czytelnikami";
            Load += ReadersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_AddReader;
        private TextBox textBox_FirstName;
        private Label label2;
        private TextBox textBox_LastName;
        private Label label1;
        private GroupBox groupBox2;
        private Button button_deleteReader;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox comboBox1;
    }
}