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
            lbl_SearchByType.Location = new Point(515, 39);
            lbl_SearchByType.Margin = new Padding(2, 0, 2, 0);
            lbl_SearchByType.Name = "lbl_SearchByType";
            lbl_SearchByType.Size = new Size(108, 20);
            lbl_SearchByType.TabIndex = 21;
            lbl_SearchByType.Text = "Search By Type";
            // 
            // MultiChoiceType
            // 
            MultiChoiceType.AutoSize = true;
            MultiChoiceType.Location = new Point(515, 110);
            MultiChoiceType.Margin = new Padding(2);
            MultiChoiceType.Name = "MultiChoiceType";
            MultiChoiceType.Size = new Size(135, 24);
            MultiChoiceType.TabIndex = 20;
            MultiChoiceType.Text = "Multiple Choice";
            MultiChoiceType.UseVisualStyleBackColor = true;
            MultiChoiceType.CheckedChanged += chb_Parctical_CheckedChanged;
            // 
            // TrueFalseQuestion
            // 
            TrueFalseQuestion.AutoSize = true;
            TrueFalseQuestion.Location = new Point(515, 71);
            TrueFalseQuestion.Margin = new Padding(2);
            TrueFalseQuestion.Name = "TrueFalseQuestion";
            TrueFalseQuestion.Size = new Size(95, 24);
            TrueFalseQuestion.TabIndex = 19;
            TrueFalseQuestion.Text = "True False";
            TrueFalseQuestion.UseVisualStyleBackColor = true;
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(92, 241);
            dgvQuestions.Margin = new Padding(3, 4, 3, 4);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowHeadersWidth = 62;
            dgvQuestions.Size = new Size(985, 374);
            dgvQuestions.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(82, 94);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 16;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(64, 39);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(257, 30);
            button1.TabIndex = 15;
            button1.Text = "Add new Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(849, 49);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 25;
            label4.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(849, 72);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(151, 28);
            cmbCourseName.TabIndex = 24;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            // 
            // OneChoiceType
            // 
            OneChoiceType.AutoSize = true;
            OneChoiceType.Location = new Point(515, 149);
            OneChoiceType.Margin = new Padding(2);
            OneChoiceType.Name = "OneChoiceType";
            OneChoiceType.Size = new Size(103, 24);
            OneChoiceType.TabIndex = 26;
            OneChoiceType.Text = "OneChoice";
            OneChoiceType.UseVisualStyleBackColor = true;
            // 
            // FormManageQuestions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 681);
            Controls.Add(OneChoiceType);
            Controls.Add(label4);
            Controls.Add(cmbCourseName);
            Controls.Add(lbl_SearchByType);
            Controls.Add(MultiChoiceType);
            Controls.Add(TrueFalseQuestion);
            Controls.Add(dgvQuestions);
            Controls.Add(button2);
            Controls.Add(button1);
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