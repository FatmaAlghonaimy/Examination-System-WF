using Examination_System.Business.StudentExamHistory;
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

<<<<<<< HEAD

        private void LoadStudentExamsHistory()
        {
            try
            {
                DataTable dt = _examService.GetStudentExams(stdID);
                dgvExamsHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void frmStudentExamsHistory_Load_1(object sender, EventArgs e)
        {
            LoadStudentExamsHistory();
=======
        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

>>>>>>> d8ac61edf214f9b089a41e8c4251965a6aa19053
        }
    }
}
