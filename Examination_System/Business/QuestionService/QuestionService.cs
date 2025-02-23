
using ExaminationSystem.Data_Access.Models;
using ExaminationSystem.Data_Access;
using System.Data;
using Examination_System.Business.Enums;

namespace ExaminationSystem.Business.QuestionService
{
    internal class QuestionService
    {
        public static DataTable GetQuestionsbyExamID(int ExamID)
        {
            return QuestionRepository.GetQuestionsbyExamID(ExamID);
        }
        public static QuestionList GetQuestionsListbyExamID(int ExamID)
        {
            DataTable dataTable = GetQuestionsbyExamID(ExamID);
            return ConvertDataTableQuestionsToList(dataTable);
        }
        public static QuestionList ConvertDataTableQuestionsToList(DataTable dataTable)
        {
            QuestionList questions = new QuestionList();

            foreach (DataRow row in dataTable.Rows)
            {
                int questionId = (int)row["ID"];

                questions.Add(new Question
                {
                    ID = questionId,
                    CourseID = (int)row["CourseID"],
                    Body = row["Body"].ToString(),
                    Type = (QuestionType)(byte)row["QuestionType"],
                    Marks = (int)row["Marks"],
                    AnswerList = AnswerService.AnswerService.GetAnswerListbyQuestionID(questionId),
                    
                });
            }
            return questions;
        }
        public static DataTable GetAllQuestionsNotInExambyCourseID(int CourseID, int ExamID, List<QuestionType>? questionTypes = null)
        {
            return QuestionRepository.GetAllQuestionsNotInExambyCourseID(CourseID, ExamID, questionTypes);
        }
        public static DataTable GetAllQuestionByCourseID(int CourseID)
        {
            return QuestionRepository.GetAllQuestionByCourseID(CourseID);
        }
        public static DataTable GetAllQuestions()
        {
            return QuestionRepository.GetAllQuestions();
        }
        //public static DataTable GetQuestionsByType(List<QuestionType> type) 
        //{
        //    return QuestionRepository.GetQuestionsByType(type);
        //}
    }
}
