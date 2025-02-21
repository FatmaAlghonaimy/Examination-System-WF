using ExaminationSystem.Data_Access.Models;
using ExaminationSystem.DAL.QuestionAnswerRepo;


namespace ExaminationSystem.Business.QuestionAnswerService
{
    internal static class QuestionAnswerService
    {
        public static bool AddQuestionWithAnswers(Question question, AnswerList answers)
        {
            if (string.IsNullOrWhiteSpace(question.Body) || answers.Count == 0)
                throw new ArgumentException("Question and at least Two answers are required.");

            try
            {
                QuestionAnswerRepository.AddQuestionWithAnswers(question, answers);
                return true; 

            }catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

