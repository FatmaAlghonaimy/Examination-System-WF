using Examination_System.Business.Enums;
using ExaminationSystem.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Data_Access.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Body { get; set; }
        public QuestionType Type { get; set; }
        public int Marks { get; set; }
        public AnswerList AnswerList { get; set; }
        public int CourseID { get; set; }
    }
}
