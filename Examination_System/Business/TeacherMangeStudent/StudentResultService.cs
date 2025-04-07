using Examination_System.Data_Access;
using ExaminationSystem.Data_Access;
using System.Data;
using Microsoft.Data.SqlClient;



namespace ExaminationSystem.Business.StudentResultService
{
    public class StudentResultService
    {
        private readonly StudentResultRepository _studentResultRepository;

        public StudentResultService()
        {
            _studentResultRepository = new StudentResultRepository();
        }

        public DataTable GetStudentResults(int studentId, int teacherId)
        {
            SqlCommand cmd = new SqlCommand(@$"SELECT 
                        u.ID AS [StudentId],  
                        E.ID AS ExamId,
                        U.FirstName + ' ' + U.LastName AS [Student Name],
                        C.CourseName,
                        CONCAT(ISNULL([dbo].[GetTotalScore](sc.StudentID, e.ID),0), ' / ', E.TotalMarks) AS Score,
                        CASE 
                            WHEN [dbo].[GetTotalScore](u.ID, e.ID) / E.TotalMarks >= 0.9 THEN 'Excellent'
                            WHEN [dbo].[GetTotalScore](u.ID, e.ID) / E.TotalMarks >= 0.75 THEN 'Very Good'
                            WHEN [dbo].[GetTotalScore](u.ID, e.ID) / E.TotalMarks >= 0.6 THEN 'Good'
                            WHEN [dbo].[GetTotalScore](u.ID, e.ID) / E.TotalMarks >= 0.5 THEN 'Pass'
                            ELSE 'Fail'
                        END AS Status
                    FROM Exam E
                    JOIN StudentCourses sc ON sc.CourseID = e.CourseID
                    JOIN Users U ON U.ID = SC.StudentID
                    JOIN Courses c ON sc.CourseID = c.ID
                    WHERE e.Status = 2 
                        AND u.id = {studentId} 
                        AND c.teacherId = {teacherId};");
            return Reposatory.select(cmd);
        }
    }
}
