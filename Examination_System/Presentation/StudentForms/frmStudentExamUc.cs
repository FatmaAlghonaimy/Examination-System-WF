using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.Business.Enums;
using Examination_System.Business.StudentCoursesService;
using Examination_System.Presentation.Common;
using Examination_System.Business.StudentExamService;

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmStudentExamUc : UserControl
    {
        private int stdID;
        private StudentNextExamService _examService;

        public frmStudentExamUc()
        {
            InitializeComponent();
            stdID = General.LoggedUser?.ID ?? 0; // تجنب الخطأ في حالة عدم تسجيل الدخول

            _examService = new StudentNextExamService();
        }

        public frmStudentExamUc(int studentID)
        {
            InitializeComponent();
            this.stdID = studentID;
            _examService = new StudentNextExamService();
            LoadStudentExams();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmStudentProfile frmStudentProfile = new frmStudentProfile();
            //frmStudentProfile.Show();
        }

        private void frmStudentExamUc_Load(object sender, EventArgs e)
        {
            LoadStudentExams();
        }

        private void LoadStudentExams()
        {
            try
            {
                DataTable dt = _examService.GetStudentNextExams(stdID);
                dgvStudentExams.DataSource = dt;

                AddShowExamColumn();
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }


        private void AddShowExamColumn()
        {
            if (dgvStudentExams.Columns["Col_ExamAction"] == null)
            {
                DataGridViewButtonColumn showExamColumn = new DataGridViewButtonColumn
                {
                    Name = "Col_ExamAction",
                    HeaderText = "Exam Action",
                    Text = "Open Exam", // سيتم تغيير النص أثناء التنسيق

                    UseColumnTextForButtonValue = true
                };
                dgvStudentExams.Columns.Add(showExamColumn);
            }

        }


        private void dgvStudentExams_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // التأكد من التعامل فقط مع عمود "Col_ExamAction"
            if (e.RowIndex < 0 || dgvStudentExams.Columns[e.ColumnIndex].Name != "Col_ExamAction")
                return;

            var cellValue = dgvStudentExams.Rows[e.RowIndex].Cells["StartTime"].Value;
            if (cellValue != null && cellValue != DBNull.Value)
            {
                DateTime examDate = Convert.ToDateTime(cellValue);
                DateTime examEndTime = examDate.AddHours(1); // مدة الامتحان ساعة (يمكن تعديلها)

                if (DateTime.Now < examDate)
                {
                    e.Value = "Pending";
                    dgvStudentExams.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Gray;
                }
                else if (DateTime.Now >= examDate && DateTime.Now <= examEndTime)
                {
                    e.Value = "Open Exam";
                    dgvStudentExams.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
                else // في حال انتهاء الامتحان
                {
                    e.Value = "Closed";
                    dgvStudentExams.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                }
            }
        }

        private void dgvStudentExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // التأكد من النقر على صف صالح وعمود "Col_ExamAction"
            if (e.RowIndex < 0 || dgvStudentExams.Columns[e.ColumnIndex]?.Name != "Col_ExamAction")
                return;

            // الحصول على قيمة الزر في الصف
            string actionText = dgvStudentExams.Rows[e.RowIndex].Cells["Col_ExamAction"]?.Value?.ToString();

            // الحصول على وقت بدء الامتحان من العمود "StartTime"
            var startTimeValue = dgvStudentExams.Rows[e.RowIndex].Cells["StartTime"].Value;
            if (startTimeValue == null || startTimeValue == DBNull.Value)
            {
                MessageBox.Show("Exam start time is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime examStartTime = Convert.ToDateTime(startTimeValue);

            // التأكد من أن وقت الامتحان قد بدأ بالفعل
            if (DateTime.Now < examStartTime)
            {
                MessageBox.Show("The exam has not started yet. Please wait until " + examStartTime.ToString("T"),
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // التأكد من أن الزر هو "Open Exam"
            if (actionText == "Open Exam")
            {
                if (dgvStudentExams.Rows[e.RowIndex].Cells["Id"]?.Value == null)
                {
                    MessageBox.Show("Exam ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int examID = Convert.ToInt32(dgvStudentExams.Rows[e.RowIndex].Cells["Id"].Value);
                frmShowStudentExam examForm = new frmShowStudentExam(stdID, examID);
                examForm.ShowDialog();
            }
            else if (actionText == "Pending")
            {
                MessageBox.Show("The exam is not yet available. Please wait until the exam start time.",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (actionText == "Closed")
            {
                MessageBox.Show("The exam has ended.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmStudentHomeUc(General.LoggedUser));
        }
    }
}
