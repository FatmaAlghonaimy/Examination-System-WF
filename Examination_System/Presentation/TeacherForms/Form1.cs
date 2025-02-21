using Examination_System.Presentation;
using ExaminationSystem.Business.ExamService;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ExaminationSystem
{
    public partial class Form1 : Form
    {
        int login_id = 11;
        int gendervalue;
        ExamService _examService;

        public Form1()
        {
            InitializeComponent();
            _examService = new ExamService();

        }
        //load courses of the teacher in the checkedlistbox
        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox3.Items.Add("All");
            LoadCourses();
            Title.Text = $"Hello Teacher Number {login_id}";
        }
        private void LoadCourses()
        {
            DataTable courses = _examService.GetCoursesByTeacher(login_id);
            foreach (DataRow row in courses.Rows)
            {
                checkedListBox3.Items.Add(row["CourseName"].ToString());
            }
        }

        //get the exams of the teacher by date
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DataTable table = _examService.FilterByDate(login_id, dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = _examService.FilterByDate(login_id, dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = table;
        }


        //select status of the exams
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedItems.Count > 0)
            {
                List<int> statusList = checkedListBox1.CheckedItems.Cast<string>().Select(item => item switch
                {
                    "Pending" => 0,
                    "Started" => 1,
                    "Finished" => 2,
                    _ => -1
                }).ToList();

                DataTable table = _examService.GetExamStatus(login_id, statusList);
                dataGridView1.DataSource = table;
            }
            else { dataGridView1.DataSource = null; }

        }
        //select Type of the exams
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count > 0)
            {
                List<int> TypeList = new List<int>();
                foreach (var item in checkedListBox2.CheckedItems)
                {
                    switch (item.ToString())
                    {
                        case "Practice":
                            TypeList.Add(0);
                            break;
                        case "Final":
                            TypeList.Add(1);
                            break;
                    }
                }
                DataTable table = _examService.GetExamType(login_id, TypeList);
                dataGridView1.DataSource = table;

            }
            else
            {
                dataGridView1.DataSource = null;
            }

        }

        //select courses of the teacher
        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox3.CheckedItems.Count > 0)
            {
                List<string> selectedCourses = checkedListBox3.CheckedItems.Cast<string>().ToList();
                DataTable table = _examService.GetCoursesWithExams(login_id, selectedCourses);
                dataGridView1.DataSource = table;
            }
            else
            {
                dataGridView1.DataSource = null;
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmTeacherProfile().Show();
        }
    }
}
