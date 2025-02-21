using Examination_System;
using Examination_System.Business.Enums;

using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;

using System.Data;


namespace ExaminationSystem.Data_Access
{
    internal class QuestionRepository
    {
        public static int AddQuestion(Question question, SqlConnection connection, SqlTransaction transaction)
        {
            SqlCommand cmd = new SqlCommand("AddQuestion", connection, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CourseID", question.CourseID);
            cmd.Parameters.AddWithValue("@Body", question.Body);
            cmd.Parameters.AddWithValue("@QuestionType", question.Type);
            cmd.Parameters.AddWithValue("@Marks", question.Marks);

            SqlParameter outputParam = new SqlParameter("@QuestionID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputParam);

            cmd.ExecuteNonQuery();
            return (int)outputParam.Value; // Return the new QuestionID
        }
        public static DataTable GetQuestionsbyExamID(int ExamID)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetQuestionsByExamID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ExamID", ExamID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public static DataTable GetAllQuestionsNotInExambyCourseID(int CourseID, int ExamID, List<QuestionType>? questionType = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new(General.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllQuestionsNotInExambyCourseID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@ExamID", ExamID);
                    string typeString = (questionType is null || questionType.Count == 0)
                        ? DBNull.Value.ToString()
                        : string.Join(",", questionType.Select(t => (int)t));
                    cmd.Parameters.AddWithValue("@QuestionType", string.IsNullOrEmpty(typeString) ? DBNull.Value : typeString);


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}


