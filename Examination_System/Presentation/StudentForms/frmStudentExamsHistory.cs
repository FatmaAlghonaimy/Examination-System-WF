﻿using Examination_System.Business.Enums;
using Examination_System.Business.StudentExamHistory;
using Examination_System.Presentation.AdminForms;
using Examination_System.Presentation.Common;
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
    public partial class frmStudentExamsHistory : Form
    {
        private int stdID = General.LoggedUser.ID;
        private StudentExamService _examService;

        public frmStudentExamsHistory()
        {
            InitializeComponent();
            _examService = new StudentExamService();
        }

        public frmStudentExamsHistory(int stdID)
        {
            InitializeComponent();
            this.stdID = stdID;
            _examService = new StudentExamService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStudentProfile frmStudentProfile = new frmStudentProfile();
            frmStudentProfile.Show();
        }


        private void LoadStudentExamsHistory()
        {
            try
            {
                DataTable dt = _examService.GetStudentExams(stdID);
                dgvExamsHistory.DataSource = dt;
                addResult();
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error,ex.Message).Show();
            }
        }
        private void addResult()
        {
            DataGridViewButtonColumn showResultColumn = new DataGridViewButtonColumn();
            showResultColumn.Name = "Col_Result";
            showResultColumn.HeaderText = "Show Result";
            showResultColumn.Text = "Show Result";
            showResultColumn.UseColumnTextForButtonValue = true;
            dgvExamsHistory.Columns.Add(showResultColumn);
        }

        private void frmStudentExamsHistory_Load_1(object sender, EventArgs e)
        {
            LoadStudentExamsHistory();
        }
        private void dgvExamsHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // التأكد من أن النقر ليس على رأس العمود
            if (e.RowIndex < 0)
                return;

            // التحقق إذا كان النقر على عمود "ShowResult"
            if (dgvExamsHistory.Columns[e.ColumnIndex].Name == "Col_Result")
            {
                // التأكد من أن زر عرض النتائج مفعل (غير ReadOnly)
                if (!dgvExamsHistory.Rows[e.RowIndex].Cells["Col_Result"].ReadOnly)
                {
                    // جلب رقم الطالب من general.loggeduser.id
                    int studentId = General.LoggedUser.ID;

                    // جلب رقم الامتحان من أول عمود (نفترض أن ExamID موجود في العمود الأول)
                    int examId = Convert.ToInt32(dgvExamsHistory.Rows[e.RowIndex].Cells[0].Value);

                    // فتح النموذج frmshowstudentexam وتمرير رقم الطالب ورقم الامتحان
                    frmShowStudentExam examResultForm = new frmShowStudentExam(studentId, examId);
                    examResultForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("data cannot be viewed untill you finish exam");
                }
            }
        }

    }
}
