﻿using ExaminationSystem.Data_Access;
using ExaminationSystem.Data_Access.Models;
using System.Data;
using Microsoft.Data.SqlClient;


namespace ExaminationSystem.Business.ExamService
{
    internal class ExamService
    {
        public static bool CreateExam(Exam exam)
        {
            if (exam.CourseID == 0 || exam.Duration == 0 || exam.NoOfQuestions == 0 || exam.Type == default || exam.StartTime == default || exam.EndTime == default)
                throw new ArgumentException("All fields are required.");
            try
            {
                ExamRepository.CreateExam(exam);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static DataTable GetExamById(int id)
        {
            using (SqlCommand cmd = new SqlCommand(@$"Select [ID]
      ,[CourseID]
      ,[ExamType]
      ,[StartTime]
      ,[EndTime]
      ,case
	  when [Status] = 0 then 'Pending'
	  when [Status] = 1 then 'Started'
	  else 'Finished' end as Status
      ,[NoOFQuestions]
      ,[Duration]
      ,[TotalMarks]
        FROM [FatmaLast].[dbo].[Exam]"))
            {
                try
                {
                    return ExamRepository.select(cmd);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        DatabaseHelper _dl;

        public ExamService()
        {
            _dl = new DatabaseHelper();
        }

        public DataTable GetCoursesByTeacher(int teacherId)
        {
            string query = $"SELECT CourseName FROM Courses WHERE TeacherID = {teacherId}";
            return _dl.Executequery(query);
        }
        public DataTable FilterByDate(int teacherId, DateTime startDate, DateTime endDate)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@startDate", SqlDbType.DateTime) { Value = startDate },
                new SqlParameter("@endDate", SqlDbType.DateTime) { Value = endDate },
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
            };

            return _dl.ExecuteStoredProcedure("filterByDate", parameters);
        }
        public DataTable GetExamStatus(int teacherId, List<int> statusList)
        {
            string selectedExamStatus = string.Join(",", statusList);
            SqlParameter[] parameters = {
                new SqlParameter("@examstatus", SqlDbType.NVarChar) { Value = selectedExamStatus },
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
            };

            return _dl.ExecuteStoredProcedure("getExamStatus", parameters);
        }
        public DataTable GetExamType(int teacherId, List<int> typeList)
        {
            string selectedExamType = string.Join(",", typeList);
            SqlParameter[] parameters = {
                new SqlParameter("@examsType", SqlDbType.NVarChar) { Value = selectedExamType },
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
            };

            return _dl.ExecuteStoredProcedure("getExamType", parameters);
        }
        public DataTable GetCoursesWithExams(int teacherId, List<string> courses)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@coursename", SqlDbType.VarChar) { Value = courses.Contains("All") ? (object)DBNull.Value : string.Join(",", courses) },
                new SqlParameter("@teacherid", SqlDbType.Int) { Value = teacherId }
            };

            return _dl.ExecuteStoredProcedure("getCoursesWhichHaveExams", parameters);
        }
        public static DataTable GetExamByID(int examID)
        {
            return ExamRepository.GetExamById(examID);
        }
    }
}