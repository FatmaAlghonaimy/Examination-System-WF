namespace ExaminationSystem.Presentation
{
    partial class FormInsertQuestionsToExam
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
            label7 = new Label();
            dgvQuestions = new DataGridView();
            button2 = new Button();
            dgvExams = new DataGridView();
            QuestionTypes = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(70, 41);
            label7.Name = "label7";
            label7.Size = new Size(167, 31);
            label7.TabIndex = 38;
            label7.Text = "QuestionType ";
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(26, 209);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowHeadersWidth = 51;
            dgvQuestions.Size = new Size(632, 452);
            dgvQuestions.TabIndex = 40;
            // 
            // button2
            // 
            button2.Location = new Point(588, 700);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(133, 42);
            button2.TabIndex = 45;
            button2.Text = "Save Exam";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnSave_Click;
            // 
            // dgvExams
            // 
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(718, 209);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 51;
            dgvExams.Size = new Size(581, 452);
            dgvExams.TabIndex = 46;
            // 
            // QuestionTypes
            // 
            QuestionTypes.FormattingEnabled = true;
            QuestionTypes.Location = new Point(70, 89);
            QuestionTypes.Name = "QuestionTypes";
            QuestionTypes.Size = new Size(150, 114);
            QuestionTypes.TabIndex = 47;
            // 
            // FormInsertQuestionsToExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 768);
            Controls.Add(QuestionTypes);
            Controls.Add(dgvExams);
            Controls.Add(button2);
            Controls.Add(dgvQuestions);
            Controls.Add(label7);
            Name = "FormInsertQuestionsToExam";
            Text = "FormInsertQuestionsToExam";
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private DataGridView dgvQuestions;
        private Button button2;
        private DataGridView dgvExams;
        private CheckedListBox QuestionTypes;
    }
}