﻿using Examination_System;
using Examination_System.Presentation;
using ExaminationSystem.Business.StudentService;
using Microsoft.Data.SqlClient;

using System.Data;


namespace ExaminationSystem
{
    public partial class Form2 : Form
    {
        //int login_id = General.LoggedUser.ID;
        int login_id = 11;
        private StudentService _studentService;
        public Form2()
        {
            InitializeComponent();
            _studentService = new StudentService();
            LoadCourses();
        }
        private void LoadCourses()
        {
            List<string> courses = _studentService.GetTeacherCourses(login_id);
            foreach (var course in courses)
            {
                checkedListBox1.Items.Add(course);
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _studentService.GetAllStudents(login_id);
            label1.Text = $"Hello Teacher Number {login_id}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int studentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                Form3 resultForm = new Form3(studentID);
                resultForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose one Student", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ApplyFilters()
        {
            string name = textBox1.Text.Trim();
            int? gender = null;
            if (rdbtnMale.Checked)
                gender = 0;
            else if (rdbtnFemale.Checked)
                gender = 1;

            List<string> selectedCourses = checkedListBox1.CheckedItems.Cast<string>().ToList();

            dataGridView1.DataSource = _studentService.FilterStudents(login_id, name, gender, selectedCourses);
        }

        // Event handlers call ApplyFilters()
        private void textBox1_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void rdbtnMale_CheckedChanged(object sender, EventArgs e) => ApplyFilters();
        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e) => ApplyFilters();
        private void rdbtnAll_CheckedChanged(object sender, EventArgs e) => ApplyFilters();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmTeacherProfile().Show();
        }
    }
}
