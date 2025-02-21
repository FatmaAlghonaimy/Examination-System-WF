using Examination_System;
using Examination_System.Business.Enums;
using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ExaminationSystem.Data_Access
{
    public class ExamQuestionRepository
    {
        private static string connectionString = General.connectionString;
        public static DataTable GetRandomExamQuestions(int courseId, QuestionType type, int noOfQuestionsPerType)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetRandomQuestions", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@NoOfQuestions", SqlDbType.Int) { Value = noOfQuestionsPerType });
                        command.Parameters.Add(new SqlParameter("@courseID", SqlDbType.Int) { Value = courseId });
                        command.Parameters.Add(new SqlParameter("@QuestionType", SqlDbType.Int) { Value = (int)type });

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while fetching random exam questions.", ex);
            }
            return dt;
        }
        public static void SaveExamQuestions(int examID, QuestionList questions)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    foreach (Question question in questions)
                    {
                        using (SqlCommand command = new SqlCommand("InsertExamQuestion", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ExamID", examID);
                            command.Parameters.AddWithValue("@QuestionID", question.ID);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while saving exam questions.", ex);
                }
            }
        }

        public static void DeleteExamQuestion(int examID, int QuestionID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("RemoveQuestionFromExam", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ExamID", examID);
                        command.Parameters.AddWithValue("@QuestionID", QuestionID);
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while deleting exam question.", ex);
                }
            }

        }

        public static void SaveQuestionToExam(int examID, int questionID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertExamQuestion", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ExamID", examID);
                        command.Parameters.AddWithValue("@QuestionID", questionID);
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while saving exam question.", ex);
                }
            }
        }
    }
}