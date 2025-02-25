using Examination_System.Business.StudentCoursesService;
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
    public partial class frmStudentCourses : Form
    {
        private int stdID = General.LoggedUser.ID;
        private StudentCoursesService _courceService;
        public frmStudentCourses()
        {
            InitializeComponent();
            _courceService = new StudentCoursesService();
        }
        public frmStudentCourses(int stdID)
        {
            InitializeComponent();
            this.stdID = stdID;
            _courceService = new StudentCoursesService();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStudentProfile frmStudentProfile = new frmStudentProfile();
            frmStudentProfile.Show();

        }
        private void LoadStudentCourses()
        {
            try
            {
                DataTable dt = _courceService.GetStudentCources(stdID);
                dgvStudentCourses.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvStudentCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadStudentCourses();
        }

        private void frmStudentCourses_Load(object sender, EventArgs e)
        {
            LoadStudentCourses();
        }
    }
}
