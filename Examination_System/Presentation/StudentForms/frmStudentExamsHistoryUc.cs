using Examination_System.Business.Enums;
using Examination_System.Business.StudentExamHistory;
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

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmStudentExamsHistoryUc : UserControl
    {
        private int stdID = General.LoggedUser.ID;
        private StudentExamService _examService;

        public frmStudentExamsHistoryUc()
        {
            InitializeComponent();
            _examService = new StudentExamService();
            StyleControls();
            LoadStudentExamsHistory();
        }

        public frmStudentExamsHistoryUc(int stdID)
        {
            InitializeComponent();
            this.stdID = stdID;
            _examService = new StudentExamService();
            StyleControls();
            LoadStudentExamsHistory();
        }

        private void StyleControls()
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmStudentHomeUc(General.LoggedUser));
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
                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }

        private void addResult()
        {
            if (!dgvExamsHistory.Columns.Contains("Col_Result"))
            {
                DataGridViewButtonColumn showResultColumn = new DataGridViewButtonColumn();
                showResultColumn.Name = "Col_Result";
                showResultColumn.HeaderText = "Show Result";
                showResultColumn.Text = "Show Result";
                showResultColumn.UseColumnTextForButtonValue = true;
                // تعديل شكل عمود زر النتيجة
                showResultColumn.DefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                showResultColumn.DefaultCellStyle.ForeColor = Color.White;
                showResultColumn.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgvExamsHistory.Columns.Add(showResultColumn);
            }
        }


        private void frmStudentExamsHistory_Load_1(object sender, EventArgs e)
        {
            LoadStudentExamsHistory();
        }
        private void dgvExamsHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvExamsHistory.Columns[e.ColumnIndex].Name == "Col_Result")
                {
                    string examStatus = dgvExamsHistory.Rows[e.RowIndex].Cells["ExamStatus"].Value.ToString();
                    string examType = dgvExamsHistory.Rows[e.RowIndex].Cells["ExamTpe"].Value.ToString();
                    if(examStatus == "Finished" &&  examType == "Practice")
                    {
                    int examId = (int)dgvExamsHistory.Rows[e.RowIndex].Cells["Id"].Value;
                    General.LoadUserControl(new Examination_System.Presentation.AdminForms.frmShowStudentExamUc(General.LoggedUser.ID, examId));

                    }
                    else {
                        new ToastForm(ToastType.Info, "You can't see this exam result").Show();
                    }
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();

            }
        }


    }
}
