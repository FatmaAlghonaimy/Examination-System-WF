using Examination_System.Business.Enums;
using Examination_System.Business.StudentExamHistory;
using Examination_System.Business.StudentExamService;
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
        private void LoadStudentExams()
        {
            try
            {
                DataTable dt = _examService.GetStudentNextExams(stdID);
                dgvStudentExams.DataSource = dt;
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }

        private void frmStudentExam_Load_1(object sender, EventArgs e)
        {
            LoadStudentExams();
        }
    }
}
