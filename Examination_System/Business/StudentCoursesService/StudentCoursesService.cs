using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Examination_System.Business.StudentCoursesService
{
    class StudentCoursesService
    {
        private string connString = General.connectionString;

        public DataTable GetStudentCources(int stdID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("select distinct cr.CourseName ,cr.Duration,cr.Grade,scr.EnrollmentDate\r\nfrom StudentCourses scr join Courses cr on scr.CourseID=cr.ID\r\nwhere scr.StudentID=@StudentID", conn))
                    {
                        cmd.Parameters.AddWithValue("StudentID", stdID);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error happened: " + ex.Message);
            }

            return dt;
        }
    }
}
