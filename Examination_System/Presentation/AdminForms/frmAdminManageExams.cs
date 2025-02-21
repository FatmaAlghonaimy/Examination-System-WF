using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access;
using Microsoft.Data.SqlClient;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminManageExams : Form
    {
        DataTable dt = AdminManageExamService.GetAllExams();
        public frmAdminManageExams()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAdminDashboard().Show();
        }

        private void dgv_Exam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAdminManageExams_Load(object sender, EventArgs e)
        {
            dgv_Exam.DataSource = dt;
            LoadComboBoxData();
            AddUpdateButtonColumn();
        }

        private void AddUpdateButtonColumn()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "Action";
            editButton.Text = "Edit";
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Action";
            deleteButton.Text = "Delete";
            editButton.UseColumnTextForButtonValue = true; 
            dgv_Exam.Columns.Add(editButton);
            deleteButton.UseColumnTextForButtonValue = true;
            dgv_Exam.Columns.Add(deleteButton);
        }


        private void LoadComboBoxData()
        {
            try
            {

                DataTable dt;
                dt = AdminManageExamService.GetAll_Courses();
                DataRow allCoursesRow = dt.NewRow();
                allCoursesRow["CourseName"] = "All Courses";
                allCoursesRow["ID"] = 0;
                dt.Rows.InsertAt(allCoursesRow, 0);
                cmb_SearchByCourse.DataSource = dt;
                cmb_SearchByCourse.DisplayMember = "CourseName";
                cmb_SearchByCourse.ValueMember = "ID";
                cmb_SearchByCourse.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }
        private void FilterByCources(int id)
        {
            try
            {

                DataTable dt = AdminManageExamService.GetExamsByCourse(id);
                dgv_Exam.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                dgv_Exam.DataSource = dt;
            }
        }
        private void cmb_SearchByCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SearchByCourse.SelectedIndex > 0)
            {
                chb_Parctical.Checked = false;
                chb_Final.Checked = false;
            }

            if (cmb_SearchByCourse.SelectedValue == null || cmb_SearchByCourse.SelectedIndex == 0)
            {
                DataTable dt = AdminManageExamService.GetAllExams();
                dgv_Exam.DataSource = dt;
                return;
            }
            int selectedCategory;
            if (int.TryParse(cmb_SearchByCourse.SelectedValue.ToString(), out selectedCategory))
            {
                FilterByCources(selectedCategory);

            }
            else
            {
                return;
            }
        }
        //no of stud && teacher
        private void chb_Final_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Final.Checked)
            {
                chb_Parctical.Checked = false;
                cmb_SearchByCourse.SelectedIndex = 0;
            }
            DataTable dt = null;
            try
            {
                if (chb_Final.Checked)
                {
                    dt = AdminManageExamService.GetExamByType(1);
                }
                else
                {
                    dt = GetOriginalDataTable();
                }

                dgv_Exam.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                dt = GetOriginalDataTable();
                dgv_Exam.DataSource = dt;
            }
            chb_Parctical.Checked = false;
        }
        private void chb_Parctical_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Parctical.Checked)
            {
                chb_Final.Checked = false;
                cmb_SearchByCourse.SelectedIndex = 0;
            }
            DataTable dt = null;
            try
            {
                if (chb_Parctical.Checked)
                {
                    dt = AdminManageExamService.GetExamByType(0);
                }
                else
                {
                    dt = GetOriginalDataTable();
                }

                dgv_Exam.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                dt = GetOriginalDataTable();
                dgv_Exam.DataSource = dt;
            }

        }
        private DataTable GetOriginalDataTable()
        {
            return dt;
        }

        //--------------------------------filter by Data Time---------------------------------------
        private void FilterExams()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetExamByTime"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DateTime? startDate = dtp_FilterByStartTime.Checked ? dtp_FilterByStartTime.Value : (DateTime?)null;
                    DateTime? endDate = dtp_FilterByEndTime.Checked ? dtp_FilterByEndTime.Value : (DateTime?)null;

                    cmd.Parameters.AddWithValue("@s", (object)startDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)endDate ?? DBNull.Value);

                    DataTable dt = AdminManageTeacherRepository.select(cmd);

                    dgv_Exam.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            FilterExams();
        }

        private void lbl_NoStud_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Exam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int examId;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Exam.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out examId))
                {
                    string teacherName = AdminManageExamService.GetTeacherNameByExamId(examId);
                    lbl_ExamTeacher.Text = $"Teacher: {teacherName}";
                    int studentCount = AdminManageExamService.GetStudentNumberPerExam(examId);
                    lbl_NoStud.Text = $"Number of Students: {studentCount}";
                }

            }
        }


        private void txb_ExamTeacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            AdminManageTeacherService.ExportToExcel(dgv_Exam);
        }
    }
}
