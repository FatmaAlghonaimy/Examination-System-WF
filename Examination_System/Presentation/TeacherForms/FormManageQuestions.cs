using Examination_System.Business;
using Examination_System.Business.Enums;
using ExaminationSystem.Business.QuestionService;
using ExaminationSystem.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class FormManageQuestions : Form
    {
        private BindingSource questionsBinding = [];
        Course selectedCourse;
        public FormManageQuestions()
        {
            InitializeComponent();
            LoadCourses();
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            TrueFalseQuestion.CheckedChanged += CheckBoxType_CheckChanged;
            MultiChoiceType.CheckedChanged += CheckBoxType_CheckChanged;
            OneChoiceType.CheckedChanged += CheckBoxType_CheckChanged;
        }

        private void CheckBoxType_CheckChanged(object sender, EventArgs e)
        {
            LoadQuestions(selectedCourse?.ID);

        }

        private void LoadCourses()
        {
            cmbCourseName.DataSource = CourseService.GetAllCoursesListWithTeacherID(General.LoggedUser.ID);
            cmbCourseName.DisplayMember = "Name";
            cmbCourseName.ValueMember = "ID";
            cmbCourseName.SelectedIndex = -1;
        }
        private void chb_Parctical_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourseName.SelectedItem is not null)
            {
                selectedCourse = (Course)cmbCourseName.SelectedItem;
                LoadQuestions(selectedCourse.ID);
            }
            else
            {
                LoadQuestions();
            }
        }

        private void LoadQuestions(int? CourseID = null)
        {
            DataTable table;
            if (CourseID is null)
            {
                table = QuestionService.GetAllQuestions();
            }
            else
            {
                table = QuestionService.GetAllQuestionByCourseID(CourseID.Value);
            }
            questionsBinding.DataSource = table;
            dgvQuestions.DataSource = questionsBinding;
        }

    }
}
