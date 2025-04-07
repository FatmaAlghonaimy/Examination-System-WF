using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Data_Access.Models
{
    public class QuestionList : List<Question>
    {
        public QuestionList(IEnumerable<Question> collection) : base(collection)
        {
        }
        public QuestionList() : base() { }
    }
}
