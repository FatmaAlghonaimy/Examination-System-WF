using Examination_System;
using Microsoft.Data.SqlClient;

using System.Data;


namespace ExaminationSystem
{
    public partial class Form3 : Form
    {
         int studentid;
        public Form3(int studentid)
        {
            InitializeComponent();
            this.studentid = studentid;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = General.connectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ShowResult", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = studentid;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    textBox1.Text = $"Result Of Student Number {studentid}";

                }
            }
        }
    }
}
