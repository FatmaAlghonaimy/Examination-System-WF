using Examination_System.Business.Enums;
using Examination_System.Business.StudentExamHistory;
using Examination_System.Business.StudentExamService;
using Examination_System.Presentation.Common;
using Examination_System.Presentation.StudentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation
{
    public partial class frmStudentExam : Form
    {
        private int stdID = General.LoggedUser.ID;
        private StudentNextExamService _examService;
        public frmStudentExam()
        {
            InitializeComponent();
            _examService = new StudentNextExamService();
        }
        public frmStudentExam(int stdID)
        {
            InitializeComponent();
            this.stdID = stdID;
            _examService = new StudentNextExamService();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStudentProfile frmStudentProfile = new frmStudentProfile();
            frmStudentProfile.Show();
        }
        

        private void frmStudentExam_Load_1(object sender, EventArgs e)
        {
            LoadStudentExams();
        }
        private void addshowexam()
        {
            if (dgvStudentExams.Columns["Col_ExamAction"] != null)
            {
                dgvStudentExams.Columns.Remove("Col_ExamAction"); // Remove existing column to refresh the buttons
            }

            DataGridViewButtonColumn showExamColumn = new DataGridViewButtonColumn();
            showExamColumn.Name = "Col_ExamAction";
            showExamColumn.HeaderText = "Exam Action";
            showExamColumn.Text = "Start Exam";
            showExamColumn.UseColumnTextForButtonValue = true;
            dgvStudentExams.Columns.Add(showExamColumn);
        }

        private void LoadStudentExams()
        {
            try
            {
                DataTable dt = _examService.GetStudentNextExams(stdID);
                dgvStudentExams.DataSource = dt;
                FormatExamGrid();
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }

        private void FormatExamGrid()
        {
            // Remove the column if it already exists to refresh it
            if (dgvStudentExams.Columns["Col_ExamAction"] != null)
            {
                dgvStudentExams.Columns.Remove("Col_ExamAction");
            }

            DataGridViewButtonColumn showExamColumn = new DataGridViewButtonColumn
            {
                Name = "Col_ExamAction",
                HeaderText = "Exam Action",
                Text = "Start Exam",
                UseColumnTextForButtonValue = true
            };

            dgvStudentExams.Columns.Add(showExamColumn);
        }

        private void dgvExamsStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStudentExams.Columns[e.ColumnIndex].Name == "Col_ExamAction")
            {
                var startTimeValue = dgvStudentExams.Rows[e.RowIndex].Cells["StartTime"].Value;
                var endTimeValue = dgvStudentExams.Rows[e.RowIndex].Cells["EndTime"].Value;

                if (startTimeValue != null && startTimeValue != DBNull.Value &&
                    endTimeValue != null && endTimeValue != DBNull.Value)
                {
                    DateTime examStart = Convert.ToDateTime(startTimeValue);
                    DateTime examEnd = Convert.ToDateTime(endTimeValue);

                    if (DateTime.Now >= examStart && DateTime.Now <= examEnd)
                    {
                        e.Value = "Start Exam"; // Button is active
                    }
                    else
                    {
                        dgvStudentExams.Rows[e.RowIndex].Cells["Col_ExamAction"].Value = null; // Hide button
                    }
                }
            }
        }

        private void dgvStudentExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvStudentExams.Columns[e.ColumnIndex].Name != "Col_ExamAction")
                return;

            var startTimeValue = dgvStudentExams.Rows[e.RowIndex].Cells["StartTime"].Value;
            var endTimeValue = dgvStudentExams.Rows[e.RowIndex].Cells["EndTime"].Value;

            if (startTimeValue == null || startTimeValue == DBNull.Value ||
                endTimeValue == null || endTimeValue == DBNull.Value)
                return;

            DateTime examStart = Convert.ToDateTime(startTimeValue);
            DateTime examEnd = Convert.ToDateTime(endTimeValue);

            if (DateTime.Now >= examStart && DateTime.Now <= examEnd)
            {
                frmExam examForm = new frmExam();
                examForm.Show(); // Use Show() instead of ShowDialog()
            }
            else
            {
                new ToastForm(ToastType.Warning, "Exam not available now").Show();
            }
        }

    }
}
