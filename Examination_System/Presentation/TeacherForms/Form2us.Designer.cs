namespace Examination_System.Presentation.TeacherForms
{
    partial class Form2us
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_back = new Button();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            rdbtnAll = new RadioButton();
            rdbtnFemale = new RadioButton();
            rdbtnMale = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(-84, 83);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(86, 31);
            btn_back.TabIndex = 29;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(407, 120);
            label4.Name = "label4";
            label4.Size = new Size(106, 38);
            label4.TabIndex = 28;
            label4.Text = "Coures";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(375, 161);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 92);
            checkedListBox1.TabIndex = 27;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // rdbtnAll
            // 
            rdbtnAll.AutoSize = true;
            rdbtnAll.Location = new Point(735, 178);
            rdbtnAll.Name = "rdbtnAll";
            rdbtnAll.Size = new Size(48, 24);
            rdbtnAll.TabIndex = 26;
            rdbtnAll.TabStop = true;
            rdbtnAll.Text = "All";
            rdbtnAll.UseVisualStyleBackColor = true;
            rdbtnAll.CheckedChanged += rdbtnAll_CheckedChanged;
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.Location = new Point(735, 238);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Size = new Size(78, 24);
            rdbtnFemale.TabIndex = 25;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "Female";
            rdbtnFemale.UseVisualStyleBackColor = true;
            rdbtnFemale.CheckedChanged += rdbtnFemale_CheckedChanged;
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.Location = new Point(735, 208);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(63, 24);
            rdbtnMale.TabIndex = 24;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Male";
            rdbtnMale.UseVisualStyleBackColor = true;
            rdbtnMale.CheckedChanged += rdbtnMale_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(658, 137);
            label3.Name = "label3";
            label3.Size = new Size(223, 38);
            label3.TabIndex = 23;
            label3.Text = "Student Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 178);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 22;
            label2.Text = "Student Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.WindowFrame;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 294);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1240, 356);
            dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(414, 658);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 31);
            button1.TabIndex = 19;
            button1.Text = "Student Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 31);
            label1.Name = "label1";
            label1.Size = new Size(405, 50);
            label1.TabIndex = 18;
            label1.Text = "Hello Teacher with ID ";
            // 
            // Form2us
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_back);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(rdbtnAll);
            Controls.Add(rdbtnFemale);
            Controls.Add(rdbtnMale);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "Form2us";
            Size = new Size(986, 749);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private RadioButton rdbtnAll;
        private RadioButton rdbtnFemale;
        private RadioButton rdbtnMale;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
    }
}
