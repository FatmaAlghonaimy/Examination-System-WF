using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Examination_System.Business.StudentExamHistory
{
    class StudentExamService
    {
        private string connString = General.connectionString;

        public DataTable GetStudentExams(int stdID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();


                    using (SqlCommand cmd = new SqlCommand(@"
                            select distinct e.Id, e.CourseID,cr.CourseName, 
                            case when e.examType = 0 then 'Practice'
                            else 'Final'end as ExamTpe,
                            case
                            when e.ExamType = 0 then CONCAT(ISNULL([dbo].[GetTotalScore](sc.StudentID, e.ID),0), ' / ', E.TotalMarks)
                            else '__'
                            end AS Score,
                            case
                            when e.ExamType = 0 then  (CASE 
                                WHEN [dbo].[GetTotalScore](sc.StudentID, e.ID) / E.TotalMarks >= 0.9 THEN 'Excellent'
                                WHEN [dbo].[GetTotalScore](sc.StudentID, e.ID) / E.TotalMarks >= 0.75 THEN 'Very Good'
                                WHEN [dbo].[GetTotalScore](sc.StudentID, e.ID) / E.TotalMarks >= 0.6 THEN 'Good'
                                WHEN [dbo].[GetTotalScore](sc.StudentID, e.ID) / E.TotalMarks >= 0.5 THEN 'Pass'
                                ELSE 'Fail'
                            END) 
                            else '__'
                            end 
                             AS Status,
                             case 
                             when e.Status = 0 then 'Pending'
                             when e.Status = 1 then 'Started'
                             else 'Finished' end
                             as ExamStatus,
                            e.StartTime, e.EndTime, e.NoOFQuestions, e.Duration,e.TotalMarks
                            from Exam e join StudentCourses sc on e.CourseID = sc.CourseID join Courses cr on e.CourseID=cr.ID 
                            where sc.StudentID = @StudentID and e.EndTime < GETDATE()
                            ", conn))
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
