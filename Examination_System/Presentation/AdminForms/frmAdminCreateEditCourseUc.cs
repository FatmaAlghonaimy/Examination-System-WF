using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Presentation.Common;
using ExaminationSystem.Data_Access.Models;
using System.Data;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminCreateEditCourseUc : UserControl
    {
        OperationMode _operation;
        Course _course;
        public frmAdminCreateEditCourseUc(OperationMode op)
        {
            InitializeComponent();
            _operation = op;
            LoadTeachers(UserService.GetAllTeachers);
            com_courseteacher.SelectedIndex = -1;
            btn_save.Enabled = false;
        }
        public frmAdminCreateEditCourseUc(Course course, OperationMode op) : this(op)
        {
            tx_coursename.IsPlaceHolder = false;
            n_courseduration.IsPlaceHolder = false;
            n_coursegrade.IsPlaceHolder = false;
            _course = course;
            tx_coursename.Text = course.Name;
            n_courseduration.Text = course.Duration.ToString();
            n_coursegrade.Text = course.Grade.ToString();
            com_courseteacher.SelectedValue = course.TeacherID;
            lb_title.Text = $"Edit {course.Name} Course";
        }


        private void btn_back_Click_1(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminManageCoursesUc());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Get values from input controls
            string courseName = tx_coursename.Text.Trim();
            int teacherId = (com_courseteacher.SelectedItem != null) ? Convert.ToInt32(com_courseteacher.SelectedValue) : -1;
            int courseGrade;
            int courseDuration;

            // Validate Course Name
            if (Utility.IsNullOrEmpty(courseName))
            {
                new ToastForm(ToastType.Error, "Course name cannot be empty!").Show();
                tx_coursename.Focus(); // Set focus back to the course name textbox
                return;
            }

            // Validate Teacher
            if (teacherId <= 0)
            {
                new ToastForm(ToastType.Error, "Please select a valid teacher!").Show();
                com_courseteacher.Focus(); // Set focus back to the teacher combo box
                return;
            }

            // Validate Course Grade
            if (!int.TryParse(n_coursegrade.Text, out courseGrade) || !Utility.IsPositive(courseGrade))
            {
                new ToastForm(ToastType.Error, "Course grade must be a positive number!").Show();
                n_coursegrade.Focus(); // Set focus back to the course grade numeric control
                return;
            }

            // Validate Course Duration
            if (!int.TryParse(n_courseduration.Text, out courseDuration) || !Utility.IsPositive(courseDuration))
            {
                new ToastForm(ToastType.Error, "Course duration must be a positive number!").Show();
                n_courseduration.Focus(); // Set focus back to the course duration numeric control
                return;
            }

            // If all validations pass, proceed with inserting or updating the course
            Course course = new Course()
            {
                Duration = courseDuration,
                Grade = courseGrade,
                Name = courseName,
                TeacherID = teacherId
            };

            try
            {
                CreateEditCourseStatus result = CreateEditCourseStatus.OtherError;

                if (_operation == OperationMode.Create)
                {
                    result = CourseService.CreateCourse(course);
                }
                else
                {
                    course.ID = _course.ID;
                    result = CourseService.UpdateCourse(course);
                }

                // Handle the result of the operation
                switch (result)
                {
                    case CreateEditCourseStatus.Success:
                        new ToastForm(ToastType.Success, "Course saved successfully!").Show();
                        General.LoadUserControl(new frmAdminManageCoursesUc());
                        break;

                    case CreateEditCourseStatus.UniqueConstraintViolation:
                        new ToastForm(ToastType.Error, "Course name must be unique!").Show();
                        tx_coursename.Focus(); // Set focus back to the course name textbox
                        break;

                    case CreateEditCourseStatus.NotNullViolation:
                        new ToastForm(ToastType.Error, "Course name must not be empty or null!").Show();
                        tx_coursename.Focus(); // Set focus back to the course name textbox
                        break;

                    default:
                        new ToastForm(ToastType.Error, "Unknown Error!").Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();
            }
        }
        private void LoadTeachers(Func<DataTable> fun)
        {
            com_courseteacher.DataSource = fun?.Invoke();
            com_courseteacher.DisplayMember = "TeacherName";
            com_courseteacher.ValueMember = "Id";

        }

        private bool AreRequiredFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(tx_coursename.Text.Trim()))
            {
                lb_coursename.Text = "Course Name is required *";

            }
            else
            {
                lb_coursename.Text = "";
            }

            if (string.IsNullOrWhiteSpace(n_courseduration.Text.Trim()))
            {
                lb_courseduration.Text = "Course Duration is required *";

            }
            else
            {
                lb_courseduration.Text = "";
            }

            if (string.IsNullOrWhiteSpace(n_coursegrade.Text.Trim()))
            {
                lb_coursegrade.Text = "Course Grade is required *";
            }
            else
            {
                lb_coursegrade.Text = "";
            }



            return !string.IsNullOrWhiteSpace(tx_coursename.Text.Trim()) &&
                   !string.IsNullOrWhiteSpace(n_coursegrade.Text.Trim()) &&
                   !string.IsNullOrWhiteSpace(n_coursegrade.Text.Trim());
        }

        private void UpdateSaveButtonState()
        {
            btn_save.Enabled = AreRequiredFieldsFilled();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            General.LoadUserControl(new frmAdminManageCoursesUc());
        }
    }
}
