using System.Windows.Forms;

namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminEditExamUc
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
            btn_Back = new CustomControls.CustomButton();
            btn_EditQuestions = new CustomControls.CustomButton();
            btn_SaveChanges = new CustomControls.CustomButton();
            cmbCourseName = new CustomControls.CustomComboBox();
            combinedDateTimePickerStart = new ExaminationSystem.CombinedDateTimePicker();
            combinedDateTimePickerEnd = new ExaminationSystem.CombinedDateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            numDuration = new NumericUpDown();
            NoOfQuestionsUpDown = new Label();
            UpDownNoOFQuestions = new NumericUpDown();
            label6 = new Label();
            rdoFinalExam = new RadioButton();
            rdoPracticeExam = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).BeginInit();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.DarkOrchid;
            btn_Back.BackgroundColor = Color.DarkOrchid;
            btn_Back.BorderColor = Color.Black;
            btn_Back.BorderRadius = 30;
            btn_Back.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.ForeColor = Color.White;
            btn_Back.Location = new Point(589, 343);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(233, 30);
            btn_Back.TabIndex = 0;
            btn_Back.Text = "Back";
            btn_Back.TextColor = Color.White;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_EditQuestions
            // 
            btn_EditQuestions.BackColor = Color.DarkOrchid;
            btn_EditQuestions.BackgroundColor = Color.DarkOrchid;
            btn_EditQuestions.BorderColor = Color.Black;
            btn_EditQuestions.BorderRadius = 30;
            btn_EditQuestions.BorderSize = 0;
            btn_EditQuestions.FlatStyle = FlatStyle.Flat;
            btn_EditQuestions.ForeColor = Color.White;
            btn_EditQuestions.Location = new Point(303, 343);
            btn_EditQuestions.Name = "btn_EditQuestions";
            btn_EditQuestions.Size = new Size(228, 30);
            btn_EditQuestions.TabIndex = 1;
            btn_EditQuestions.Text = "Edit Questions";
            btn_EditQuestions.TextColor = Color.White;
            btn_EditQuestions.UseVisualStyleBackColor = false;
            btn_EditQuestions.Click += btn_EditQuestions_Click;
            // 
            // btn_SaveChanges
            // 
            btn_SaveChanges.BackColor = Color.DarkOrchid;
            btn_SaveChanges.BackgroundColor = Color.DarkOrchid;
            btn_SaveChanges.BorderColor = Color.Black;
            btn_SaveChanges.BorderRadius = 30;
            btn_SaveChanges.BorderSize = 0;
            btn_SaveChanges.FlatStyle = FlatStyle.Flat;
            btn_SaveChanges.ForeColor = Color.White;
            btn_SaveChanges.Location = new Point(303, 414);
            btn_SaveChanges.Name = "btn_SaveChanges";
            btn_SaveChanges.Size = new Size(519, 33);
            btn_SaveChanges.TabIndex = 2;
            btn_SaveChanges.Text = "Save Changes";
            btn_SaveChanges.TextColor = Color.White;
            btn_SaveChanges.UseVisualStyleBackColor = false;
            btn_SaveChanges.Click += btn_SaveChanges_Click;
            // 
            // cmbCourseName
            // 
            cmbCourseName.BackColor = Color.WhiteSmoke;
            cmbCourseName.BorderColor = Color.DarkOrchid;
            cmbCourseName.BorderRadius = 0;
            cmbCourseName.BorderSize = 2;
            cmbCourseName.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCourseName.Font = new Font("Segoe UI", 10F);
            cmbCourseName.ForeColor = Color.DimGray;
            cmbCourseName.IconColor = Color.MediumSlateBlue;
            cmbCourseName.Items.AddRange(new object[] { "Option 1", "Option 2", "Option 3" });
            cmbCourseName.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbCourseName.ListTextColor = Color.DimGray;
            cmbCourseName.Location = new Point(589, 285);
            cmbCourseName.MinimumSize = new Size(150, 30);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Padding = new Padding(2);
            cmbCourseName.SelectedValue = null;
            cmbCourseName.Size = new Size(233, 30);
            cmbCourseName.TabIndex = 3;
            cmbCourseName.Texts = "";
            // 
            // combinedDateTimePickerStart
            // 
            combinedDateTimePickerStart.BackColor = Color.Transparent;
            combinedDateTimePickerStart.Location = new Point(284, 173);
            combinedDateTimePickerStart.Margin = new Padding(3, 2, 3, 2);
            combinedDateTimePickerStart.Name = "combinedDateTimePickerStart";
            combinedDateTimePickerStart.Size = new Size(247, 88);
            combinedDateTimePickerStart.TabIndex = 14;
            // 
            // combinedDateTimePickerEnd
            // 
            combinedDateTimePickerEnd.BackColor = Color.Transparent;
            combinedDateTimePickerEnd.Location = new Point(571, 173);
            combinedDateTimePickerEnd.Margin = new Padding(3, 2, 3, 2);
            combinedDateTimePickerEnd.Name = "combinedDateTimePickerEnd";
            combinedDateTimePickerEnd.Size = new Size(251, 88);
            combinedDateTimePickerEnd.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(589, 76);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 31;
            label2.Text = "Exam Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(589, 254);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 30;
            label1.Text = "Course Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(303, 156);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 11;
            label5.Text = "StartDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(305, 263);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 5;
            label3.Text = "Duration";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(304, 292);
            numDuration.Margin = new Padding(3, 2, 3, 2);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(212, 23);
            numDuration.TabIndex = 4;
            // 
            // NoOfQuestionsUpDown
            // 
            NoOfQuestionsUpDown.AutoSize = true;
            NoOfQuestionsUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NoOfQuestionsUpDown.Location = new Point(305, 76);
            NoOfQuestionsUpDown.Name = "NoOfQuestionsUpDown";
            NoOfQuestionsUpDown.Size = new Size(133, 21);
            NoOfQuestionsUpDown.TabIndex = 33;
            NoOfQuestionsUpDown.Text = "No of Questions";
            // 
            // UpDownNoOFQuestions
            // 
            UpDownNoOFQuestions.Location = new Point(303, 112);
            UpDownNoOFQuestions.Margin = new Padding(3, 2, 3, 2);
            UpDownNoOFQuestions.Name = "UpDownNoOFQuestions";
            UpDownNoOFQuestions.Size = new Size(213, 23);
            UpDownNoOFQuestions.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(589, 149);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 13;
            label6.Text = "End Date";
            // 
            // rdoFinalExam
            // 
            rdoFinalExam.AutoSize = true;
            rdoFinalExam.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rdoFinalExam.Location = new Point(589, 103);
            rdoFinalExam.Margin = new Padding(3, 2, 3, 2);
            rdoFinalExam.Name = "rdoFinalExam";
            rdoFinalExam.Size = new Size(93, 21);
            rdoFinalExam.TabIndex = 36;
            rdoFinalExam.TabStop = true;
            rdoFinalExam.Text = "Final Exam";
            rdoFinalExam.UseVisualStyleBackColor = true;
            // 
            // rdoPracticeExam
            // 
            rdoPracticeExam.AutoSize = true;
            rdoPracticeExam.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rdoPracticeExam.Location = new Point(706, 103);
            rdoPracticeExam.Margin = new Padding(3, 2, 3, 2);
            rdoPracticeExam.Name = "rdoPracticeExam";
            rdoPracticeExam.Size = new Size(111, 21);
            rdoPracticeExam.TabIndex = 37;
            rdoPracticeExam.TabStop = true;
            rdoPracticeExam.Text = "Practice Exam";
            rdoPracticeExam.UseVisualStyleBackColor = true;
            // 
            // frmAdminEditExamUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._72127776_9760493;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(combinedDateTimePickerStart);
            Controls.Add(combinedDateTimePickerEnd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_Back);
            Controls.Add(label3);
            Controls.Add(btn_EditQuestions);
            Controls.Add(numDuration);
            Controls.Add(btn_SaveChanges);
            Controls.Add(cmbCourseName);
            Controls.Add(label2);
            Controls.Add(NoOfQuestionsUpDown);
            Controls.Add(UpDownNoOFQuestions);
            Controls.Add(rdoFinalExam);
            Controls.Add(rdoPracticeExam);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminEditExamUc";
            Size = new Size(863, 562);
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownNoOFQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label5;
        private ExaminationSystem.CombinedDateTimePicker combinedDateTimePickerStart;
        private Label label3;
        private NumericUpDown numDuration;
        private Label NoOfQuestionsUpDown;
        private NumericUpDown UpDownNoOFQuestions;
        private Label label6;
        private RadioButton rdoFinalExam;
        private ExaminationSystem.CombinedDateTimePicker combinedDateTimePickerEnd;
        private RadioButton rdoPracticeExam;
        private CustomControls.CustomButton btn_Back;
        private CustomControls.CustomButton btn_EditQuestions;
        private CustomControls.CustomButton btn_SaveChanges;
        private CustomControls.CustomComboBox cmbCourseName;
    }
}
