using Examination_System;
using Examination_System.Business;
using ExaminationSystem.Business.Enums;
using ExaminationSystem.Data_Access;
using ExaminationSystem.Data_Access.Models;


namespace ExaminationSystem.Presentation
{
    public partial class FormAddExam : Form
    {
        public FormAddExam()
        {
            InitializeComponent();
            LoadCourses();
            combinedDateTimePickerStart.Enabled = false;
            combinedDateTimePickerEnd.Enabled = false;
            numDuration.Enabled = false;
            var textBox = numDuration.Controls.OfType<TextBox>().FirstOrDefault();
            if (textBox is not null)
            {
                textBox.TextChanged += SyncEndDateTimeWithDuration;
            }
            rdoFinalExam.CheckedChanged += ExamType_CheckedChanged;
            rdoPracticeExam.CheckedChanged += ExamType_CheckedChanged;
            combinedDateTimePickerStart.Value = DateTime.Now;
            combinedDateTimePickerEnd.Value = DateTime.Now;
            numDuration.ValueChanged += SyncEndDateTimeWithDuration;
            combinedDateTimePickerStart.ValueChanged += CombinedDateTimePickerStart_ValueChanged;
            combinedDateTimePickerEnd.ValueChanged += CombinedDateTimePickerEnd_ValueChanged;
        }
        private void SyncEndDateTimeWithDuration(object sender, EventArgs e)
        {
            if (double.TryParse(numDuration.Text, out double duration))
            {
                combinedDateTimePickerEnd.Value = combinedDateTimePickerStart.Value.AddMinutes(duration);
            }
        }
        private void CombinedDateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            SyncEndDateTimeWithDuration(sender, e);
        }
        private void CombinedDateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (rdoPracticeExam.Checked)
            {
                if (double.TryParse(numDuration.Text, out double duration))
                {
                    var startDatewithDuration = combinedDateTimePickerStart.Value.AddMinutes(duration);
                    if (combinedDateTimePickerEnd.Value < startDatewithDuration)
                    {
                        combinedDateTimePickerEnd.Value = startDatewithDuration;
                    }
                }
            }
        }
        private void ExamType_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFinalExam.Checked || rdoPracticeExam.Checked)
            {
                combinedDateTimePickerStart.Enabled = true;
                numDuration.Enabled = true;
                if (rdoFinalExam.Checked)
                {
                    combinedDateTimePickerEnd.Enabled = false;
                }
                else
                {
                    combinedDateTimePickerEnd.Enabled = true;
                }
                SyncEndDateTimeWithDuration(sender, e);
            }
            else
            {
                combinedDateTimePickerStart.Enabled = false;
                combinedDateTimePickerEnd.Enabled = false;
                numDuration.Enabled = false;
            }
        }
        private void PracticeExamEndDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (rdoPracticeExam.Checked)
            {
                if (double.TryParse(numDuration.Text, out double duration))
                {
                    combinedDateTimePickerEnd.Value = combinedDateTimePickerStart.Value.AddMinutes(duration);
                    if (combinedDateTimePickerEnd.Value < combinedDateTimePickerStart.Value)
                    {
                        combinedDateTimePickerEnd.Value = combinedDateTimePickerStart.Value;
                    }
                }
            }
        }
        private void LoadCourses()
        {
            cmbCourseName.DataSource = CourseService.GetAllCoursesListWithTeacherID(General.LoggedUser.ID);
            cmbCourseName.DisplayMember = "Name";
            cmbCourseName.ValueMember = "ID";
            cmbCourseName.SelectedIndex = -1;
        }
        private void btnHandleExamCreation(object sender, EventArgs e)
        {
            if (cmbCourseName.SelectedItem == null || (!rdoFinalExam.Checked && !rdoPracticeExam.Checked))
            {
                MessageBox.Show("Please select a course and exam type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdoPracticeExam.Checked && combinedDateTimePickerEnd.Value < combinedDateTimePickerStart.Value)
            {
                MessageBox.Show("End date/time cannot be earlier than start date/time for practice exams.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numDuration.Value == 0)
            {
                MessageBox.Show("Duration cannot be 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Exam newExam = new()
            {
                CourseID = (int)cmbCourseName.SelectedValue,
                Type = rdoFinalExam.Checked ? Enum.GetValues<ExamType>()[1] : Enum.GetValues<ExamType>()[0],
                StartTime = combinedDateTimePickerStart.Value,
                EndTime = combinedDateTimePickerEnd.Value,
                Duration = (int)numDuration.Value,
                NoOfQuestions = (int)UpDownNoOFQuestions.Value
            };
            int createdExamId = ExamRepository.CreateExam(newExam);

            newExam.ID = createdExamId;
            if (createdExamId > 0)
            {
                MessageBox.Show("Exam Created Successfully! Now, Add Questions.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (sender == btnGenerateExam)
                {
                    FormGenerateRandomExam formSpecifyQuestions = new(newExam);
                    formSpecifyQuestions.ShowDialog();
                }
                else if (sender == btnProceedToQuestions)
                {
                    FormInsertQuestionsToExam formInsertQuestionsIntoExam = new FormInsertQuestionsToExam(newExam);
                    formInsertQuestionsIntoExam.Show();
                }
                Hide();
            }
            else
            {
                MessageBox.Show("Failed to create exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            cmbCourseName.SelectedIndex = -1;
            rdoFinalExam.Checked = false;
            rdoPracticeExam.Checked = false;
            combinedDateTimePickerStart.Value = DateTime.Now;
            combinedDateTimePickerEnd.Value = DateTime.Now;
            numDuration.Value = 1;
            UpDownNoOFQuestions.Value = 1;
        }

    }
}
