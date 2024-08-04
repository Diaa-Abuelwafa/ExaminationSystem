using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion()
        {
            this.Answers = new Answer[2];
        }

        public void CreateQustion(int num)
        {
            this.HeaderQuestion = "True or False";

            string Msg3 = $"Enter The Mark Of The Question {num + 1}:";
            double Mark = 0.0;
            Helper.ReadDouble(ref Mark, Msg3);
            this.MarkOfQuestion = Mark;

            Console.WriteLine($"Enter The Body Of The Question {num + 1}:");
            string? QuestionBody = Console.ReadLine();
            this.BodyQuestion = QuestionBody;

            this.Answers[0] = new Answer();
            this.Answers[0].AnswerId = 0;
            this.Answers[0].AnswerText = "true";

            this.Answers[1] = new Answer();
            this.Answers[1].AnswerId = 1;
            this.Answers[1].AnswerText = "false";

            Console.WriteLine($"Enter The Right Answer Of The Question {num + 1}:");
            string? RightAnswer = Console.ReadLine();
            this.RightAnswer = new Answer();
            this.RightAnswer.AnswerId = num;
            this.RightAnswer.AnswerText = RightAnswer;
        }
    }
}
