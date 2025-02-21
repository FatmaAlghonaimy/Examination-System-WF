
using Examination_System.Business.Enums;
using ExaminationSystem.Data_Access;
using ExaminationSystem.Data_Access.Models;

using System.Data;


namespace ExaminationSystem.Business.ExamQuestionService
{
    internal class ExamQuestionService
    {
        public static DataTable GetRandomExamQuestions(int CourseID, QuestionType type, int noOfQuestionsPerType)
        {
            DataTable questionTable = ExamQuestionRepository.GetRandomExamQuestions(CourseID, type, noOfQuestionsPerType);
            return questionTable;
        }
        public static QuestionList GetRandomExamQuestionsList(int CourseID, QuestionType type, int noOfQuestionsPerType)
        {
            DataTable dataTable = GetRandomExamQuestions(CourseID, type, noOfQuestionsPerType);
            return QuestionService.QuestionService.ConvertDataTableQuestionsToList(dataTable);
        }
        public static void SaveExamQuestions(int examID, QuestionList questions)
        {
            ExamQuestionRepository.SaveExamQuestions(examID, questions);
        }
        public static void SaveQuestionToExam(int examID, int questionID)
        {
            ExamQuestionRepository.SaveQuestionToExam(examID, questionID);
        }
        public static void DeleteExamQuestion(int examID, int questionID)
        {
            ExamQuestionRepository.DeleteExamQuestion(examID, questionID);

        }
    }
}

