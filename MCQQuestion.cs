using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion()
        {
            this.Answers = new Answer[3];
        }

        public void CreateQuestion(int num)
        {
            this.HeaderQuestion = "MCQ";

            string Msg3 = $"Enter The Mark Of The Question {num + 1}:";
            double Mark = 0.0;
            Helper.ReadDouble(ref Mark, Msg3);
            this.MarkOfQuestion = Mark;

            Console.WriteLine($"Enter The Body Of The Question {num + 1}:");
            string? QuestionBody = Console.ReadLine();
            this.BodyQuestion = QuestionBody;

            for (int j = 0; j < 3; ++j)
            {
                Console.WriteLine($"Enter The Choice {j + 1}:");
                string? Choice = Console.ReadLine();
                this.Answers[j] = new Answer();
                this.Answers[j].AnswerId = j;
                this.Answers[j].AnswerText = Choice;
            }

            Console.WriteLine($"Enter The Right Answer Of The Question {num + 1}:");
            string? RightAnswer = Console.ReadLine();
            this.RightAnswer = new Answer();
            this.RightAnswer.AnswerId = num;
            this.RightAnswer.AnswerText = RightAnswer;
        }
    }
}
