using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using ExaminationSystem.Business.StudentResultService;
using Examination_System.Business;
using Examination_System.Data_Access.Models;
using Examination_System.Business.Enums;
using Examination_System.Presentation.Common;
using Examination_System.Presentation.AdminForms;

namespace Examination_System.Presentation.TeacherForms
{
    public partial class Form3us : UserControl
    {

        private int _studentId;
        private StudentResultService _studentResultService;
        User Student;
        public Form3us(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            _studentResultService = new StudentResultService();
            Student = UserService.GetUsrById(studentId);
        }

        private void Form3us_Load(object sender, EventArgs e)
        {
            LoadStudentResults();
        }

        private void LoadStudentResults()
        {
            dataGridView1.DataSource = _studentResultService.GetStudentResults(_studentId, General.LoggedUser.ID);
            if (!dataGridView1.Columns.Contains("Show Exam"))
            {
                AddColumnButton("Show Exam");
            }
            textBox1.Text = $"Result Of Student: {Student.Fullname}";
        }
        private void AddColumnButton(string btnName)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = btnName;
            btn.Text = btnName;
            btn.Name = btnName;
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2us form2us = new Form2us();
            General.LoadUserControl(form2us);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Show Exam")
                {
                    int examId = (int)dataGridView1.Rows[e.RowIndex].Cells["ExamId"].Value;
                    int studentId = (int)dataGridView1.Rows[e.RowIndex].Cells["StudentId"].Value;
                    //new frmShowStudentExam(studentId, examId).Show();
                    General.LoadUserControl(new frmShowStudentExamUc(studentId, examId));
                }
            }
            catch (Exception ex)
            {
                new ToastForm(ToastType.Error, ex.Message).Show();

            }
        }
    }
}
