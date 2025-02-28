namespace Examination_System.Presentation.TeacherForms
{
    partial class FormAddExamUc
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
            btnGenerateExam = new Button();
            rdoPracticeExam = new RadioButton();
            rdoFinalExam = new RadioButton();
            btnProceedToQuestions = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label5 = new Label();
            combinedDateTimePickerStart = new ExaminationSystem.CombinedDateTimePicker();
            label3 = new Label();
            numDuration = new NumericUpDown();
            label6 = new Label();
            combinedDateTimePickerEnd = new ExaminationSystem.CombinedDateTimePicker();
            NoOfQuestionsUpDown = new Label();
            UpDownNoOFQuestions = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            cmbCourseName = new ComboBox();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateExam
            // 
            btnGenerateExam.Location = new Point(422, 160);
            btnGenerateExam.Margin = new Padding(3, 2, 3, 2);
            btnGenerateExam.Name = "btnGenerateExam";
            btnGenerateExam.Size = new Size(181, 30);
            btnGenerateExam.TabIndex = 27;
            btnGenerateExam.Text = "Generate Exam";
            btnGenerateExam.UseVisualStyleBackColor = true;
            btnGenerateExam.Click += btnHandleExamCreation;
            // 
            // rdoPracticeExam
            // 
            rdoPracticeExam.AutoSize = true;
            rdoPracticeExam.Location = new Point(46, 197);
            rdoPracticeExam.Margin = new Padding(3, 2, 3, 2);
            rdoPracticeExam.Name = "rdoPracticeExam";
            rdoPracticeExam.Size = new Size(99, 19);
            rdoPracticeExam.TabIndex = 26;
            rdoPracticeExam.TabStop = true;
            rdoPracticeExam.Text = "Practice Exam";
            rdoPracticeExam.UseVisualStyleBackColor = true;
            // 
            // rdoFinalExam
            // 
            rdoFinalExam.AutoSize = true;
            rdoFinalExam.Location = new Point(46, 168);
            rdoFinalExam.Margin = new Padding(3, 2, 3, 2);
            rdoFinalExam.Name = "rdoFinalExam";
            rdoFinalExam.Size = new Size(82, 19);
            rdoFinalExam.TabIndex = 25;
            rdoFinalExam.TabStop = true;
            rdoFinalExam.Text = "Final Exam";
            rdoFinalExam.UseVisualStyleBackColor = true;
            // 
            // btnProceedToQuestions
            // 
            btnProceedToQuestions.Location = new Point(422, 108);
            btnProceedToQuestions.Margin = new Padding(3, 2, 3, 2);
            btnProceedToQuestions.Name = "btnProceedToQuestions";
            btnProceedToQuestions.Size = new Size(181, 31);
            btnProceedToQuestions.TabIndex = 24;
            btnProceedToQuestions.Text = "Proceed To Questions";
            btnProceedToQuestions.UseVisualStyleBackColor = true;
            btnProceedToQuestions.Click += btnHandleExamCreation;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(combinedDateTimePickerStart);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(numDuration);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(combinedDateTimePickerEnd);
            flowLayoutPanel1.Location = new Point(46, 243);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(557, 258);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "StartDate";
            // 
            // combinedDateTimePickerStart
            // 
            combinedDateTimePickerStart.Location = new Point(65, 3);
            combinedDateTimePickerStart.Margin = new Padding(4, 3, 4, 3);
            combinedDateTimePickerStart.Name = "combinedDateTimePickerStart";
            combinedDateTimePickerStart.Size = new Size(433, 99);
            combinedDateTimePickerStart.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 105);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Duration";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(62, 107);
            numDuration.Margin = new Padding(3, 2, 3, 2);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(438, 23);
            numDuration.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 132);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 13;
            label6.Text = "End Date";
            // 
            // combinedDateTimePickerEnd
            // 
            combinedDateTimePickerEnd.Location = new Point(64, 135);
            combinedDateTimePickerEnd.Margin = new Padding(4, 3, 4, 3);
            combinedDateTimePickerEnd.Name = "combinedDateTimePickerEnd";
            combinedDateTimePickerEnd.Size = new Size(433, 99);
            combinedDateTimePickerEnd.TabIndex = 16;
            // 
            // NoOfQuestionsUpDown
            // 
            NoOfQuestionsUpDown.AutoSize = true;
            NoOfQuestionsUpDown.Location = new Point(239, 91);
            NoOfQuestionsUpDown.Name = "NoOfQuestionsUpDown";
            NoOfQuestionsUpDown.Size = new Size(93, 15);
            NoOfQuestionsUpDown.TabIndex = 22;
            NoOfQuestionsUpDown.Text = "No of Questions";
            // 
            // UpDownNoOFQuestions
            // 
            UpDownNoOFQuestions.Location = new Point(239, 108);
            UpDownNoOFQuestions.Margin = new Padding(3, 2, 3, 2);
            UpDownNoOFQuestions.Name = "UpDownNoOFQuestions";
            UpDownNoOFQuestions.Size = new Size(132, 23);
            UpDownNoOFQuestions.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 144);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 20;
            label2.Text = "Exam Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 90);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 19;
            label1.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(50, 108);
            cmbCourseName.Margin = new Padding(3, 2, 3, 2);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(133, 23);
            cmbCourseName.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(49, 53);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 28;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAddExamUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(btnGenerateExam);
            Controls.Add(rdoPracticeExam);
            Controls.Add(rdoFinalExam);
            Controls.Add(btnProceedToQuestions);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(NoOfQuestionsUpDown);
            Controls.Add(UpDownNoOFQuestions);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCourseName);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "FormAddExamUc";
            Size = new Size(863, 562);
            Load += FormAddExamUc_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateExam;
        private RadioButton rdoPracticeExam;
        private RadioButton rdoFinalExam;
        private Button btnProceedToQuestions;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExaminationSystem.CombinedDateTimePicker combinedDateTimePickerStart;
        private Label label5;
        private Label label3;
        private NumericUpDown numDuration;
        private Label label6;
        private ExaminationSystem.CombinedDateTimePicker combinedDateTimePickerEnd;
        private Label NoOfQuestionsUpDown;
        private NumericUpDown UpDownNoOFQuestions;
        private Label label2;
        private Label label1;
        private ComboBox cmbCourseName;
        private Button button1;
    }
}
