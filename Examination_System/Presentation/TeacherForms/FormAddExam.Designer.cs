namespace ExaminationSystem.Presentation
{
    partial class FormAddExam
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
            cmbCourseName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            numDuration = new NumericUpDown();
            label3 = new Label();
            NoOfQuestionsUpDown = new Label();
            UpDownNoOFQuestions = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label5 = new Label();
            combinedDateTimePickerStart = new CombinedDateTimePicker();
            label6 = new Label();
            combinedDateTimePickerEnd = new CombinedDateTimePicker();
            btnProceedToQuestions = new Button();
            rdoFinalExam = new RadioButton();
            rdoPracticeExam = new RadioButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnGenerateExam = new Button();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCourseName
            // 
            cmbCourseName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(38, 37);
            cmbCourseName.Margin = new Padding(3, 2, 3, 2);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(133, 23);
            cmbCourseName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 73);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Exam Type";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(62, 107);
            numDuration.Margin = new Padding(3, 2, 3, 2);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(438, 23);
            numDuration.TabIndex = 4;
            numDuration.ValueChanged += SyncEndDateTimeWithDuration;
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
            // NoOfQuestionsUpDown
            // 
            NoOfQuestionsUpDown.AutoSize = true;
            NoOfQuestionsUpDown.Location = new Point(375, 43);
            NoOfQuestionsUpDown.Name = "NoOfQuestionsUpDown";
            NoOfQuestionsUpDown.Size = new Size(93, 15);
            NoOfQuestionsUpDown.TabIndex = 7;
            NoOfQuestionsUpDown.Text = "No of Questions";
            // 
            // UpDownNoOFQuestions
            // 
            UpDownNoOFQuestions.Location = new Point(375, 60);
            UpDownNoOFQuestions.Margin = new Padding(3, 2, 3, 2);
            UpDownNoOFQuestions.Name = "UpDownNoOFQuestions";
            UpDownNoOFQuestions.Size = new Size(132, 23);
            UpDownNoOFQuestions.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(combinedDateTimePickerStart);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(numDuration);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(combinedDateTimePickerEnd);
            flowLayoutPanel1.Location = new Point(34, 143);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(557, 258);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
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
            // btnProceedToQuestions
            // 
            btnProceedToQuestions.Location = new Point(623, 143);
            btnProceedToQuestions.Margin = new Padding(3, 2, 3, 2);
            btnProceedToQuestions.Name = "btnProceedToQuestions";
            btnProceedToQuestions.Size = new Size(181, 31);
            btnProceedToQuestions.TabIndex = 14;
            btnProceedToQuestions.Text = "Proceed To Questions";
            btnProceedToQuestions.UseVisualStyleBackColor = true;
            btnProceedToQuestions.Click += btnHandleExamCreation;
            // 
            // rdoFinalExam
            // 
            rdoFinalExam.AutoSize = true;
            rdoFinalExam.Location = new Point(34, 97);
            rdoFinalExam.Margin = new Padding(3, 2, 3, 2);
            rdoFinalExam.Name = "rdoFinalExam";
            rdoFinalExam.Size = new Size(82, 19);
            rdoFinalExam.TabIndex = 15;
            rdoFinalExam.TabStop = true;
            rdoFinalExam.Text = "Final Exam";
            rdoFinalExam.UseVisualStyleBackColor = true;
            // 
            // rdoPracticeExam
            // 
            rdoPracticeExam.AutoSize = true;
            rdoPracticeExam.Location = new Point(34, 126);
            rdoPracticeExam.Margin = new Padding(3, 2, 3, 2);
            rdoPracticeExam.Name = "rdoPracticeExam";
            rdoPracticeExam.Size = new Size(99, 19);
            rdoPracticeExam.TabIndex = 16;
            rdoPracticeExam.TabStop = true;
            rdoPracticeExam.Text = "Practice Exam";
            rdoPracticeExam.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnGenerateExam
            // 
            btnGenerateExam.Location = new Point(623, 195);
            btnGenerateExam.Margin = new Padding(3, 2, 3, 2);
            btnGenerateExam.Name = "btnGenerateExam";
            btnGenerateExam.Size = new Size(181, 30);
            btnGenerateExam.TabIndex = 17;
            btnGenerateExam.Text = "Generate Exam";
            btnGenerateExam.UseVisualStyleBackColor = true;
            btnGenerateExam.Click += btnHandleExamCreation;
            // 
            // FormAddExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 421);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddExam";
            Text = "formAddExam";
            Load += FormAddExam_Load;
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCourseName;
        private Label label1;
        private Label label2;
        private NumericUpDown numDuration;
        private Label label3;
        private Label NoOfQuestionsUpDown;
        private NumericUpDown UpDownNoOFQuestions;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private Label label6;
        private Button btnProceedToQuestions;
        private RadioButton rdoFinalExam;
        private RadioButton rdoPracticeExam;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private CombinedDateTimePicker combinedDateTimePickerStart;
        private CombinedDateTimePicker combinedDateTimePickerEnd;
        private Button btnGenerateExam;
    }
}