namespace ExaminationSystem
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rdbtnMale = new RadioButton();
            rdbtnFemale = new RadioButton();
            rdbtnAll = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.WindowFrame;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1085, 267);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(483, 455);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 6;
            button1.Text = "Student Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 7);
            label1.Name = "label1";
            label1.Size = new Size(327, 41);
            label1.TabIndex = 5;
            label1.Text = "Hello Teacher with ID ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 82);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 56);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 10;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(900, 51);
            label3.Name = "label3";
            label3.Size = new Size(176, 30);
            label3.TabIndex = 11;
            label3.Text = "Student Gender";
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.Location = new Point(968, 104);
            rdbtnMale.Margin = new Padding(3, 2, 3, 2);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(51, 19);
            rdbtnMale.TabIndex = 12;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Male";
            rdbtnMale.UseVisualStyleBackColor = true;
            rdbtnMale.CheckedChanged += rdbtnMale_CheckedChanged;
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.Location = new Point(968, 127);
            rdbtnFemale.Margin = new Padding(3, 2, 3, 2);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Size = new Size(63, 19);
            rdbtnFemale.TabIndex = 13;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "Female";
            rdbtnFemale.UseVisualStyleBackColor = true;
            rdbtnFemale.CheckedChanged += rdbtnFemale_CheckedChanged;
            // 
            // rdbtnAll
            // 
            rdbtnAll.AutoSize = true;
            rdbtnAll.Location = new Point(968, 82);
            rdbtnAll.Margin = new Padding(3, 2, 3, 2);
            rdbtnAll.Name = "rdbtnAll";
            rdbtnAll.Size = new Size(39, 19);
            rdbtnAll.TabIndex = 14;
            rdbtnAll.TabStop = true;
            rdbtnAll.Text = "All";
            rdbtnAll.UseVisualStyleBackColor = true;
            rdbtnAll.CheckedChanged += rdbtnAll_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(483, 82);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(132, 76);
            checkedListBox1.TabIndex = 15;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(501, 51);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 16;
            label4.Text = "Coures";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(47, 24);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 17;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1106, 488);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private RadioButton rdbtnMale;
        private RadioButton rdbtnFemale;
        private RadioButton rdbtnAll;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private Button btn_back;
    }
}