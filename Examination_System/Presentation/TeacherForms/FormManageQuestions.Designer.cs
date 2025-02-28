namespace Examination_System.Presentation.TeacherForms
{
    partial class FormManageQuestions
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
            lbl_SearchByType = new Label();
            MultiChoiceType = new CheckBox();
            TrueFalseQuestion = new CheckBox();
            dgvQuestions = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            cmbCourseName = new ComboBox();
            OneChoiceType = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // lbl_SearchByType
            // 
            lbl_SearchByType.AutoSize = true;
            lbl_SearchByType.Location = new Point(590, 29);
            lbl_SearchByType.Margin = new Padding(2, 0, 2, 0);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(85, 15);
            lbl_SearchByType.TabIndex = 21;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // MultiChoiceType
            // 
            MultiChoiceType.AutoSize = true;
            MultiChoiceType.Location = new Point(590, 82);
            MultiChoiceType.Margin = new Padding(2);
            MultiChoiceType.Name = "MultiChoiceType";
            MultiChoiceType.Size = new Size(110, 19);
            MultiChoiceType.TabIndex = 20;
            MultiChoiceType.Text = "Multiple Choice";
            MultiChoiceType.UseVisualStyleBackColor = true;
            // 
            // TrueFalseQuestion
            // 
            TrueFalseQuestion.AutoSize = true;
            TrueFalseQuestion.Location = new Point(590, 53);
            TrueFalseQuestion.Margin = new Padding(2);
            TrueFalseQuestion.Name = "TrueFalseQuestion";
            TrueFalseQuestion.Size = new Size(77, 19);
            TrueFalseQuestion.TabIndex = 19;
            TrueFalseQuestion.Text = "True False";
            TrueFalseQuestion.UseVisualStyleBackColor = true;
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(80, 181);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dgvQuestions.RowHeadersWidth = 62;
            dgvQuestions.Size = new Size(1078, 338);
            dgvQuestions.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(72, 70);
            button2.Name = "button2";
            button2.Size = new Size(75, 22);
            button2.TabIndex = 16;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(56, 29);
            button1.Name = "button1";
            button1.Size = new Size(225, 22);
            button1.TabIndex = 15;
            button1.Text = "Add new Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(743, 37);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 25;
            label4.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(743, 54);
            cmbCourseName.Margin = new Padding(3, 2, 3, 2);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(133, 23);
            cmbCourseName.TabIndex = 24;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            // 
            // OneChoiceType
            // 
            OneChoiceType.AutoSize = true;
            OneChoiceType.Location = new Point(590, 112);
            OneChoiceType.Margin = new Padding(2);
            OneChoiceType.Name = "OneChoiceType";
            OneChoiceType.Size = new Size(85, 19);
            OneChoiceType.TabIndex = 26;
            OneChoiceType.Text = "OneChoice";
            OneChoiceType.UseVisualStyleBackColor = true;
            // 
            // FormManageQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 526);
            Controls.Add(OneChoiceType);
            Controls.Add(label4);
            Controls.Add(cmbCourseName);
            Controls.Add(lbl_SearchByType);
            Controls.Add(MultiChoiceType);
            Controls.Add(TrueFalseQuestion);
            Controls.Add(dgvQuestions);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormManageQuestions";
            Text = "FormManageQuestions";
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SearchByType;
        private CheckBox MultiChoiceType;
        private CheckBox TrueFalseQuestion;
        private DataGridView dgvQuestions;
        private Button button2;
        private Button button1;
        private Label label4;
        private ComboBox cmbCourseName;
        private CheckBox OneChoiceType;
    }
}