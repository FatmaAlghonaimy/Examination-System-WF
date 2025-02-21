using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
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

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminCreateUser : Form
    {
        private readonly ReturnForm returnForm;
        private readonly UserRole role;
        private readonly User user = new User();
        private readonly OperationMode operationMode;

        public frmAdminCreateUser()
        {
            InitializeComponent();
            clb_courses.DataSource = CourseService.GetAllCourses();
            clb_courses.ValueMember = "Id";
            clb_courses.DisplayMember = "CourseName";
            com_gender.DataSource = Enum.GetValues(typeof(Gender));
        }

        public frmAdminCreateUser(User _user, ReturnForm _returnForm, OperationMode _operationMode) : this()
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


            com_gender.DataSource = Enum.GetValues(typeof(Gender));
            operationMode = _operationMode;

            com_gender.SelectedItem = user.Gender;
            try
            {
                List<Course> studentCourses = new List<Course>();
                var stdCourses = UserService.GetAllCoursesStudentEnrolledIn(user.ID);
                foreach (DataRow item in stdCourses.Rows)
                {
                    studentCourses.Add(new Course() {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public frmAdminCreateUser(ReturnForm _returnForm, UserRole _role, OperationMode _operationMode) : this()
        {
            returnForm = _returnForm;
            role = _role;
            operationMode = _operationMode;
        }

        public frmAdminCreateUser(ReturnForm _returnForm, UserRole _role) : this()
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
                    if(operationMode == OperationMode.Create)
                    {
                        CreateStudent();
                    } 
                    //the form is used to edit the student data
                    else if(operationMode == OperationMode.Edit)
                    {
                        UpdateeStudent();
                    }

                }

                // the form handle create and update the teacher data
                else if (role == UserRole.Teacher)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if (result == 1)
            {
                MessageBox.Show("Student was created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (returnForm == ReturnForm.frmAdminManageStudents)
                {
                    new frmAdminManageStudents().Show();
                }


            }
            else
            {

                MessageBox.Show("Student was", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Student was created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (returnForm == ReturnForm.frmAdminManageStudents)
                {
                    new frmAdminManageStudents().Show();
                }


            }
            else
            {

                MessageBox.Show("Student was", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Close();
            if(returnForm == ReturnForm.frmAdminManageStudents)
            {
                new frmAdminManageStudents().Show();
            }
        }
    }
}
