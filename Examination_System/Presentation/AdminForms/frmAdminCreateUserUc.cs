using Examination_System.Business.Enums;
using Examination_System.Business;
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
using Examination_System.Data_Access.Models;
using Examination_System.Presentation.Common;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminCreateUserUc : UserControl
    {
        private readonly ReturnForm returnForm;
        private readonly UserRole role;
        private readonly User user = new User();
        private readonly OperationMode operationMode;

        public frmAdminCreateUserUc()
        {
            InitializeComponent();
            
            com_gender.DataSource = Enum.GetValues(typeof(Gender));
        }

        public frmAdminCreateUserUc(User _user, ReturnForm _returnForm, OperationMode _operationMode) : this()
        {
            user = _user;
            role = user.UserRole;
            returnForm = _returnForm;
            UserService.SetUserImage(pic_userImg, user);
            tx_username.Text = user.Username;
            tx_email.Text = user.Email;
            tx_firstname.Text = user.FirstName;
            tx_lastname.Text = user.LastName;
            tx_password.Text = user.PasswordHash;
            tx_ssn.Text = user.SSN;
            tx_username.Text = user.Username;

            if(role == UserRole.Student)
            {
                clb_courses.DataSource = CourseService.GetAllCourses();
                clb_courses.ValueMember = "Id";
                clb_courses.DisplayMember = "CourseName";
            } else if(role == UserRole.Teacher)
            {
                clb_courses.DataSource = UserService.getAllCoursesForTeacher(user.ID);
                clb_courses.ValueMember = "Id";
                clb_courses.DisplayMember = "CourseName";
            }
            operationMode = _operationMode;

            com_gender.SelectedItem = user.Gender;
            try
            {
                if(role == UserRole.Student)
                {
                    List<Course> studentCourses = new List<Course>();
                    var stdCourses = UserService.GetAllCoursesStudentEnrolledIn(user.ID);
                    foreach (DataRow item in stdCourses.Rows)
                    {
                        studentCourses.Add(new Course()
                        {
                            ID = Convert.ToInt32(item["Id"]), // Assuming Id is an integer
                            Name = item["CourseName"].ToString() // Assuming CourseName is a string
                        });
                    }

                    for (int i = 0; i < clb_courses.Items.Count; i++)
                    {
                        var rowView = clb_courses.Items[i] as DataRowView;
                        Course course = new Course() { ID = Convert.ToInt32(rowView.Row["Id"]), Name = rowView.Row["CourseName"].ToString() };
                        if (course != null && studentCourses.Any(sc => sc.ID == course.ID))
                        {
                            clb_courses.SetItemChecked(i, true); // Check the item
                        }
                    }
                } else if(role == UserRole.Teacher)
                {
                    List<Course> studentCourses = new List<Course>();
                    var stdCourses = UserService.GetTeacherCourses(user.ID);
                    foreach (DataRow item in stdCourses.Rows)
                    {
                        studentCourses.Add(new Course()
                        {
                            ID = Convert.ToInt32(item["Id"]), // Assuming Id is an integer
                            Name = item["CourseName"].ToString() // Assuming CourseName is a string
                        });
                    }

                    for (int i = 0; i < clb_courses.Items.Count; i++)
                    {
                        var rowView = clb_courses.Items[i] as DataRowView;
                        Course course = new Course() { ID = Convert.ToInt32(rowView.Row["Id"]), Name = rowView.Row["CourseName"].ToString() };
                        if (course != null && studentCourses.Any(sc => sc.ID == course.ID))
                        {
                            clb_courses.SetItemChecked(i, true); // Check the item
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                new ToastForm(ToastType.Error,ex.Message);
            }
        }



        public frmAdminCreateUserUc(ReturnForm _returnForm, UserRole _role, OperationMode _operationMode) : this()
        {
            returnForm = _returnForm;
            role = _role;
            operationMode = _operationMode;
        }

        public frmAdminCreateUserUc(ReturnForm _returnForm, UserRole _role) : this()
        {
            returnForm = _returnForm;
            role = _role;
            com_gender.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                // the form handle create and update the students data
                if (role == UserRole.Student)
                {
                    // the form is used to create new student
                    if (operationMode == OperationMode.Create)
                    {
                        CreateStudent();
                    }
                    //the form is used to edit the student data
                    else if (operationMode == OperationMode.Edit)
                    {
                        UpdateeStudent();
                    }

                }

                // the form handle create and update the teacher data
                else if (role == UserRole.Teacher)
                {
                    // the form is used to create new Teacher
                    if (operationMode == OperationMode.Create)
                    {
                        CreateTeacher();
                    }
                    //the form is used to edit the teacher data
                    else if (operationMode == OperationMode.Edit)
                    {
                        UpdateeStudent();
                    }
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error,ex.Message).Show();

            }
        }


        private void CreateStudent()
        {
            User user = new User()
            {
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Student,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                user.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();
            foreach (var item in clb_courses.CheckedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    selectedCourses.Add((int)dataRowView["Id"]);
                }
            }
            int result = UserService.CreateUpdateUser(user, selectedCourses, OperationMode.Create);
            if (result == ((int)UserErrorMessage.Suceeded))
            {
                new ToastForm(ToastType.Success,"Student was created successfully").Show();
                if (returnForm == ReturnForm.frmAdminManageStudents)
                {
                    //new frmAdminManageStudents().Show();
                    General.LoadUserControl(new frmAdminManageStudentUc());

                }


            }
            else
            {
                if(result == ((int)UserErrorMessage.NotUniqueUsername))
                    new ToastForm(ToastType.Error,"This username already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueEmail))
                    new ToastForm(ToastType.Error,"This email already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueSSN))
                    new ToastForm(ToastType.Error, "This SSN already exist").Show();
                else 
                    new ToastForm(ToastType.Error, "Unknown Error").Show();

            }
        }

        private void UpdateeStudent()
        {
            User updatedUser = new User()
            {
                ID = user.ID,
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Student,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                updatedUser.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();
            foreach (var item in clb_courses.CheckedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    selectedCourses.Add((int)dataRowView["Id"]);
                }
            }
            int result = UserService.CreateUpdateUser(updatedUser, selectedCourses, OperationMode.Edit);
            if (result == 1)
            {
                new ToastForm(ToastType.Success, "Student was updated successfully").Show();
                if (returnForm == ReturnForm.frmAdminManageStudents)
                {
                    General.LoadUserControl(new frmAdminManageStudentUc());
                }
            }
            else
            {

                if (result == ((int)UserErrorMessage.NotUniqueUsername))
                    new ToastForm(ToastType.Error, "This username already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueEmail))
                    new ToastForm(ToastType.Error, "This email already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueSSN))
                    new ToastForm(ToastType.Error, "This SSN already exist").Show();
                else
                    new ToastForm(ToastType.Error, "Unknown Error").Show();
            }
        }

        private void CreateTeacher()
        {
            User user = new User()
            {
                Email = tx_email.Text.Trim(),
                FirstName = tx_firstname.Text.Trim(),
                Gender = (Gender)com_gender.SelectedItem,
                LastName = tx_lastname.Text.Trim(),
                PasswordHash = tx_password.Text.Trim(),
                SSN = tx_ssn.Text.Trim(),
                Username = tx_username.Text.Trim(),
                UserRole = UserRole.Teacher,
            };
            if (pic_userImg.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pic_userImg.Image.Save(stream, pic_userImg.Image.RawFormat);
                user.UserImg = stream.GetBuffer();
            }
            List<int> selectedCourses = new();
            foreach (var item in clb_courses.CheckedItems)
            {
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    selectedCourses.Add((int)dataRowView["Id"]);
                }
            }
            int result = UserService.CreateUpdateUser(user, selectedCourses, OperationMode.Create);
            if (result == ((int)UserErrorMessage.Suceeded))
            {
                new ToastForm(ToastType.Success, "Student was created successfully").Show();
                if (returnForm == ReturnForm.frmAdminManageStudents)
                {
                    //new frmAdminManageStudents().Show();
                    General.LoadUserControl(new frmAdminManageStudentUc());

                }


            }
            else
            {
                if (result == ((int)UserErrorMessage.NotUniqueUsername))
                    new ToastForm(ToastType.Error, "This username already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueEmail))
                    new ToastForm(ToastType.Error, "This email already exist").Show();
                else if (result == ((int)UserErrorMessage.NotUniqueSSN))
                    new ToastForm(ToastType.Error, "This SSN already exist").Show();
                else
                    new ToastForm(ToastType.Error, "Unknown Error").Show();

            }
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = ".png|*.png|.jpg|*.jpg|.jpeg|*.jpeg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_userImg.Image = new Bitmap(fileDialog.FileName);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            General.LoadUserControl(new frmAdminManageStudentUc());
        }
    }
}
