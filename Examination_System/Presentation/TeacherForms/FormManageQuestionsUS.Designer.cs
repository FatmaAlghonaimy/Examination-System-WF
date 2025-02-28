namespace Examination_System.Presentation.TeacherForms
{
    partial class FormManageQuestionsUS
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
            OneChoiceType = new CheckBox();
            label4 = new Label();
            cmbCourseName = new ComboBox();
            lbl_SearchByType = new Label();
            MultiChoiceType = new CheckBox();
            TrueFalseQuestion = new CheckBox();
            dgvQuestions = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // OneChoiceType
            // 
            OneChoiceType.AutoSize = true;
            OneChoiceType.Location = new Point(399, 185);
            OneChoiceType.Margin = new Padding(2);
            OneChoiceType.Name = "OneChoiceType";
            OneChoiceType.Size = new Size(103, 24);
            OneChoiceType.TabIndex = 35;
            OneChoiceType.Text = "OneChoice";
            OneChoiceType.UseVisualStyleBackColor = true;
            OneChoiceType.CheckedChanged += OneChoiceType_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 85);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 34;
            label4.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(574, 108);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(151, 28);
            cmbCourseName.TabIndex = 33;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged_1;
            // 
            // lbl_SearchByType
            // 
            lbl_SearchByType.AutoSize = true;
            lbl_SearchByType.Location = new Point(399, 75);
            lbl_SearchByType.Margin = new Padding(2, 0, 2, 0);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(108, 20);
            lbl_SearchByType.TabIndex = 32;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // MultiChoiceType
            // 
            MultiChoiceType.AutoSize = true;
            MultiChoiceType.Location = new Point(399, 146);
            MultiChoiceType.Margin = new Padding(2);
            MultiChoiceType.Name = "MultiChoiceType";
            MultiChoiceType.Size = new Size(135, 24);
            MultiChoiceType.TabIndex = 31;
            MultiChoiceType.Text = "Multiple Choice";
            MultiChoiceType.UseVisualStyleBackColor = true;
            MultiChoiceType.CheckedChanged += MultiChoiceType_CheckedChanged;
            // 
            // TrueFalseQuestion
            // 
            TrueFalseQuestion.AutoSize = true;
            TrueFalseQuestion.Location = new Point(399, 107);
            TrueFalseQuestion.Margin = new Padding(2);
            TrueFalseQuestion.Name = "TrueFalseQuestion";
            TrueFalseQuestion.Size = new Size(95, 24);
            TrueFalseQuestion.TabIndex = 30;
            TrueFalseQuestion.Text = "True False";
            TrueFalseQuestion.UseVisualStyleBackColor = true;
            TrueFalseQuestion.CheckedChanged += TrueFalseQuestion_CheckedChanged;
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(32, 259);
            dgvQuestions.Margin = new Padding(3, 4, 3, 4);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dgvQuestions.RowHeadersWidth = 62;
            dgvQuestions.Size = new Size(913, 450);
            dgvQuestions.TabIndex = 29;
            dgvQuestions.CellContentClick += dgvQuestions_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(59, 130);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 28;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(41, 75);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(257, 30);
            button1.TabIndex = 27;
            button1.Text = "Add new Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormManageQuestionsUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OneChoiceType);
            Controls.Add(label4);
            Controls.Add(cmbCourseName);
            Controls.Add(lbl_SearchByType);
            Controls.Add(MultiChoiceType);
            Controls.Add(TrueFalseQuestion);
            Controls.Add(dgvQuestions);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "FormManageQuestionsUS";
            Size = new Size(986, 749);
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox OneChoiceType;
        private Label label4;
        private ComboBox cmbCourseName;
        private Label lbl_SearchByType;
        private CheckBox MultiChoiceType;
        private CheckBox TrueFalseQuestion;
        private DataGridView dgvQuestions;
        private Button button2;
        private Button button1;
    }
}
