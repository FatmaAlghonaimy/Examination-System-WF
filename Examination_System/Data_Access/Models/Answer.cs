using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Data_Access.Models
{
    public class Answer
    {
        public int ID { get; set; }
        public string AnswerText { get; set; }
        public bool IsAnswerCorrect { get; set; } = false;
        public int QuestionID { get; set; }
    }
}
