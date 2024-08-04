using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class Question
    {
        public string? HeaderQuestion { get; set; }
        public string? BodyQuestion { get; set; }
        public double MarkOfQuestion { get; set; }

        public Answer[] Answers;
        public Answer RightAnswer { get; set; }

        
    }
}
