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

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmStudentCourcesUc : UserControl
    {
        


        private int stdID = General.LoggedUser.ID;
        private StudentCoursesService _courceService;
        public frmStudentCourcesUc()
        {
            InitializeComponent();
            _courceService = new StudentCoursesService();
        }
        public frmStudentCourcesUc(int stdID)
        {
            InitializeComponent();
            this.stdID = stdID;
            _courceService = new StudentCoursesService();
            LoadStudentCourses();
        }

        private void LoadStudentCourses()
        {
            try
            {
                DataTable dt = _courceService.GetStudentCources(stdID);
                dgvStudentCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudentCourses.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }

        private void frmStudentCourses_Load(object sender, EventArgs e)
        {
            LoadStudentCourses();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmStudentHomeUc(General.LoggedUser));
        }
    }
}
