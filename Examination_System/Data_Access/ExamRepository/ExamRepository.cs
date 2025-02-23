using Examination_System;
using ExaminationSystem;
using ExaminationSystem.Business.Enums;
using ExaminationSystem.Data_Access.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExaminationSystem.Data_Access
{
    internal class ExamRepository
    {
        private static readonly string connectionString = General.connectionString;
        private static readonly SqlConnection con = new SqlConnection(connectionString);
        public static int CreateExam(Exam exam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("CreateExam", connection, transaction)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@CourseID", exam.CourseID);
                        command.Parameters.AddWithValue("@Duration", exam.Duration);
                        command.Parameters.AddWithValue("@StartDate", exam.StartTime);
                        command.Parameters.AddWithValue("@EndDate", exam.EndTime);
                        command.Parameters.AddWithValue("@ExamType", exam.Type);
                        command.Parameters.AddWithValue("@NoOfQuestions", exam.NoOfQuestions);


                        SqlParameter outputParam = new SqlParameter("@ExamID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);
                        command.ExecuteNonQuery();
                        int createdExamID = (int)outputParam.Value;
                        transaction.Commit();
                        MessageBox.Show($"Exam Created Successfully!\nExam ID: {createdExamID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return createdExamID;

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to create exam.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }

                    finally
                    {
                        transaction.Dispose();
                    }
                }
            }
        }

        public static DataTable select(SqlCommand _cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
                _cmd.Connection = con;
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public static int DML(SqlCommand _cmd)
        {
            try
            {
                int result = 0;
                _cmd.Connection = con;
                con.Open();
                result = _cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}


 