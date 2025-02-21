using Examination_System;
using Examination_System.Presentation;
using Microsoft.Data.SqlClient;

using System.Data;


namespace ExaminationSystem
{
    public partial class Form2 : Form
    {
        int login_id = General.LoggedUser.ID;
        public Form2()
        {
            InitializeComponent();
            string connectionString = General.connectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT CourseName FROM Courses WHERE TeacherID = {login_id}", con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        checkedListBox1.Items.Add(reader["CourseName"].ToString());
                    }
                }
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = General.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("StudentsOfTeacher", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = login_id;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    label1.Text = $"Hello Teacher Number {login_id}";

                }
            }
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
                MessageBox.Show("please choose one Student ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connectionString = General.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetStudentByName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var textboxvalue = textBox1.Text.Trim();
                    var parts = textboxvalue.Split(' ');
                    var firstname = parts[0];
                    var lastname = parts.Length > 1 ? parts[1] : (object)DBNull.Value;
                    cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstname;
                    cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastname;

                    cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = login_id;


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }

        }


        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {

            string connectionString = General.connectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("selectgender", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@gender", SqlDbType.TinyInt).Value = 0;
                    cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = login_id;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
        }

        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = General.connectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("selectgender", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@gender", SqlDbType.TinyInt).Value = 1;
                    cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = login_id;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
        }

        private void rdbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = General.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("StudentsOfTeacher", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = login_id;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    label1.Text = $"Hello Teacher Number {login_id}";

                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = General.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("showStudentOfMultipleTheCourse", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (checkedListBox1.CheckedItems.Count > 0)
                    {
                        var selectedCourses = string.Join(",", checkedListBox1.CheckedItems.Cast<string>());

                        cmd.Parameters.Add("@coursenames", SqlDbType.VarChar).Value = selectedCourses;
                        cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = login_id;

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;
                    }

                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmTeacherProfile().Show();
        }
    }
}
