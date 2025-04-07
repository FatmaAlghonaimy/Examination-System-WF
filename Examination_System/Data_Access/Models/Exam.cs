using ExaminationSystem.Business.Enums;


namespace ExaminationSystem.Data_Access.Models
{
    public class Exam
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public ExamType Type { get; set; }
        public int Marks { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Duration { get; set; }
        public ExamStatus Status { get; set; }
        public int NoOfQuestions { get; set; }
        public QuestionList QuestionList { get; set; }
    }
}
