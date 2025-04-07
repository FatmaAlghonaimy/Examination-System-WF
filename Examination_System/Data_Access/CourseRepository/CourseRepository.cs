using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;

using System.Data;


namespace Examination_System.Data_Access
{
    public static class CourseRepository
    {
        public static DataTable GetAllCourses()
        {
            DataTable table = new();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("getAllCourses", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }
            return table;
        }
        public static DataTable GetAllCoursesWithTeacherID(int teacherID)
        {
            DataTable table = new();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetCoursesByTeacher", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }
            return table;
        }
        public static List<Course> GetAllCoursesListWithTeacherID(int teacherID)
        {
            List<Course> courses = [];
            DataTable dt = GetAllCoursesWithTeacherID(teacherID);

            foreach (DataRow row in dt.Rows)
            {
                courses.Add(new Course
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["CourseName"].ToString(),
                    TeacherID = Convert.ToInt32(row["TeacherID"]),
                    Grade = Convert.ToInt32(row["Grade"]),
                    Duration = Convert.ToInt32(row["Duration"])
                });
            }
            return courses;
        }
        public static string GetCourseNameByCourseID(int CourseID)
        {
            string CourseName = String.Empty;
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetCourseNameByCourseID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    con.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj is not null)
                    {
                        CourseName = obj.ToString();
                    }
                }
            }
            return CourseName;
        }
    }
}
