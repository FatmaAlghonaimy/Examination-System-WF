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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btn_back = new Button();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            rdbtnAll = new RadioButton();
            rdbtnFemale = new RadioButton();
            rdbtnMale = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            customPanel1 = new CustomControls.CustomPanel();
            dataGridView1 = new DataGridView();
            textBox1 = new CustomControls.CustomTextBox();
            button6 = new CustomControls.CustomButton();
            button1 = new CustomControls.CustomButton();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(-74, 62);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 29;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label4.Location = new Point(606, 92);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 28;
            label4.Text = "Coures";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(690, 81);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(113, 40);
            checkedListBox1.TabIndex = 27;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // rdbtnAll
            // 
            rdbtnAll.AutoSize = true;
            rdbtnAll.Location = new Point(422, 91);
            rdbtnAll.Margin = new Padding(3, 2, 3, 2);
            rdbtnAll.Name = "rdbtnAll";
            rdbtnAll.Size = new Size(39, 19);
            rdbtnAll.TabIndex = 26;
            rdbtnAll.TabStop = true;
            rdbtnAll.Text = "All";
            rdbtnAll.UseVisualStyleBackColor = true;
            rdbtnAll.CheckedChanged += rdbtnAll_CheckedChanged;
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.Location = new Point(524, 92);
            rdbtnFemale.Margin = new Padding(3, 2, 3, 2);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Size = new Size(63, 19);
            rdbtnFemale.TabIndex = 25;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "Female";
            rdbtnFemale.UseVisualStyleBackColor = true;
            rdbtnFemale.CheckedChanged += rdbtnFemale_CheckedChanged;
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.Location = new Point(467, 92);
            rdbtnMale.Margin = new Padding(3, 2, 3, 2);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(51, 19);
            rdbtnMale.TabIndex = 24;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Male";
            rdbtnMale.UseVisualStyleBackColor = true;
            rdbtnMale.CheckedChanged += rdbtnMale_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label3.Location = new Point(301, 93);
            label3.Name = "label3";
            label3.Size = new Size(114, 16);
            label3.TabIndex = 23;
            label3.Text = "Student Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.Location = new Point(27, 93);
            label2.Name = "label2";
            label2.Size = new Size(104, 16);
            label2.TabIndex = 22;
            label2.Text = "Student Name";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(857, 43);
            label1.TabIndex = 18;
            label1.Text = "Student Report";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dataGridView1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(27, 154);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(794, 344);
            customPanel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(794, 334);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderColor = Color.MediumSlateBlue;
            textBox1.BorderFocusColor = Color.HotPink;
            textBox1.BorderRadius = 25;
            textBox1.BorderSize = 2;
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.ForeColor = Color.DimGray;
            textBox1.IsFocus = false;
            textBox1.IsPlaceHolder = false;
            textBox1.Location = new Point(137, 83);
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(12, 7, 12, 7);
            textBox1.PasswordChar = false;
            textBox1.PlaceHolderColor = Color.DarkGray;
            textBox1.PlaceHolderText = "";
            textBox1.Size = new Size(149, 32);
            textBox1.TabIndex = 34;
            textBox1.UnderLine = false;
            textBox1._TextChanged += textBox1_TextChanged;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrchid;
            button6.BackgroundColor = Color.DarkOrchid;
            button6.BorderColor = Color.Black;
            button6.BorderRadius = 30;
            button6.BorderSize = 0;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(181, 511);
            button6.Name = "button6";
            button6.Size = new Size(150, 32);
            button6.TabIndex = 35;
            button6.Text = "Back";
            button6.TextColor = Color.White;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.BackgroundColor = Color.DarkOrchid;
            button1.BorderColor = Color.Black;
            button1.BorderRadius = 30;
            button1.BorderSize = 0;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(488, 511);
            button1.Name = "button1";
            button1.Size = new Size(150, 32);
            button1.TabIndex = 36;
            button1.Text = "Students Results";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2us
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(rdbtnAll);
            Controls.Add(label2);
            Controls.Add(rdbtnMale);
            Controls.Add(rdbtnFemale);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(customPanel1);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "Form2us";
            Size = new Size(863, 562);
            Load += Form2us_Load;
            customPanel1.ResumeLayout(false);
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
        private Label label1;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dataGridView1;
        private CustomControls.CustomTextBox textBox1;
        private CustomControls.CustomButton button6;
        private CustomControls.CustomButton button1;
    }
}
