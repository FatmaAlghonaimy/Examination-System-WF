using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using Examination_System.Presentation.AdminForms;
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
    public partial class frmAdminManageStudents : Form
    {
        public frmAdminManageStudents()
        {
            InitializeComponent();

            //initialize courses combobox

            DataTable coursesTable = CourseService.GetAllCourses();
            DataRow course = coursesTable.NewRow();
            course["Id"] = 0;
            course["CourseName"] = "All";
            coursesTable.Rows.InsertAt(course, 0);
            com_courses.DataSource = coursesTable;
            com_courses.DisplayMember = "CourseName";
            com_courses.ValueMember = "Id";

            com_courses.SelectedIndex = 0;


            //initialize teacher combobox
            DataTable teachersTable = UserService.GetAllTeachers();
            DataRow teacher = teachersTable.NewRow();
            teacher["Id"] = 0;
            teacher["TeacherName"] = "All";
            teachersTable.Rows.InsertAt(teacher, 0);
            com_teachers.DataSource = teachersTable;
            com_teachers.DisplayMember = "TeacherName";
            com_courses.ValueMember = "Id";

            com_courses.SelectedIndex = 0;

            //initialize dgv_students
            dgv_students.DataSource = UserService.GetAllStudents();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminDashboard().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FilterStudents(object sender, EventArgs e)
        {
            if (com_teachers.SelectedItem is DataRowView teacherselectedRow && com_courses.SelectedItem is DataRowView courseselectedRow)
            {
                int teacherId = (int)teacherselectedRow["Id"];
                int courseId = (int)courseselectedRow["Id"];
                dgv_students.DataSource = UserService.FilterStudents(courseId, teacherId);

                if (!dgv_students.Columns.Contains("col_details"))
                {
                    DetailsDeleteButtonColumn();
                }

                if (!dgv_students.Columns.Contains("col_edit"))
                {
                    EditDeleteButtonColumn();
                }
                if (!dgv_students.Columns.Contains("col_delete"))
                {
                    AddDeleteButtonColumn();
                }
            }
        }
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Delete";  // Column title
            btnColumn.Text = "delete";      // Button text
            btnColumn.Name = "col_delete";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_students.Columns.Add(btnColumn); // Add to DataGridView
        }

        private void EditDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Edit";  // Column title
            btnColumn.Text = "edit";      // Button text
            btnColumn.Name = "col_edit";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_students.Columns.Add(btnColumn); // Add to DataGridView
        }

        private void DetailsDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Details";  // Column title
            btnColumn.Text = "details";      // Button text
            btnColumn.Name = "col_details";      // Button text
            btnColumn.UseColumnTextForButtonValue = true; // Show text on button

            dgv_students.Columns.Add(btnColumn); // Add to DataGridView
        }
        private void com_teachers_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterStudentAndLoadDgv();
        }

        private void filterStudentAndLoadDgv()
        {
            if (com_teachers.SelectedItem is DataRowView teacherselectedRow && com_courses.SelectedItem is DataRowView courseselectedRow)
            {
                int teacherId = (int)teacherselectedRow["Id"];
                int courseId = (int)courseselectedRow["Id"];

                dgv_students.DataSource = UserService.GetStudentsByTeacherAndCourse(courseId, teacherId);
            }
        }

        private void HandleEDD_Buttons_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgv_students.Columns[e.ColumnIndex].Name == "col_delete")
                {
                    // delete button was clicked
                    int studentId = (int)dgv_students.Rows[e.RowIndex].Cells["Id"].Value;

                    if (MessageBox.Show($"Are you sure you want to delete this student>", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        int result = UserService.DeleteUserById(studentId);
                        switch (result)
                        {
                            case 1:
                                MessageBox.Show("User was deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                filterStudentAndLoadDgv();
                                break;
                            case 0:
                                MessageBox.Show("You can't delete admin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                break;
                            case -1:
                                MessageBox.Show("Error occured while deleting the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                break;
                            default:
                                MessageBox.Show("Unknown Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                break;
                        }

                    }
                }
                else if (e.RowIndex >= 0 && dgv_students.Columns[e.ColumnIndex].Name == "col_edit")
                {
                    // edit button was clicked
                    int studentId = (int)dgv_students.Rows[e.RowIndex].Cells["Id"].Value;
                    User student = UserService.GetUsrById(studentId);
                    if (student.ID != 0)
                    {
                        this.Close();
                        new frmAdminCreateUser(student, ReturnForm.frmAdminManageStudents, OperationMode.Edit).Show();
                    }
                }
                else if (e.RowIndex >= 0 && dgv_students.Columns[e.ColumnIndex].Name == "col_details")
                {
                    //details button was clicked
                    int studentId = (int)dgv_students.Rows[e.RowIndex].Cells["Id"].Value;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_newstudent_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminCreateUser(ReturnForm.frmAdminManageStudents, UserRole.Student, OperationMode.Create).Show();
        }
    }
}
