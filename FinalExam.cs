using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class FinalExam : Exam
    {
        Question[] QuestionsOfExam;

        public FinalExam()
        {
            
        }

        public FinalExam(Subject S)
        {
            this.Subject = S;
        }
        public override void ShowExam()
        {
            double YourMark = 0;

            int[] YourAnswers = new int[NumberOfQuestions];

            for (int i = 0; i < NumberOfQuestions; ++i)
            {
                Console.WriteLine("--------");
                Console.WriteLine($"The Header Of The Question : {QuestionsOfExam[i].HeaderQuestion}");
                Console.WriteLine($"Question {i + 1} :");
                Console.WriteLine($"{QuestionsOfExam[i].BodyQuestion}");

                for(int j = 0; j < QuestionsOfExam[i].Answers.Length; ++j)
                {
                    Console.WriteLine($"Ans {j + 1} : {QuestionsOfExam[i].Answers[j].AnswerText}");
                }

                string Msg = "Choose Your Answer";
                int ChoiceAns = 0;
                Helper.ReadInt(ref ChoiceAns, Msg);

                YourAnswers[i] = ChoiceAns;

                double ResultMark = CheckAnswer(QuestionsOfExam[i], ChoiceAns);
                YourMark += ResultMark;
            }

            Console.WriteLine("=============================================");

            for(int i = 0; i < NumberOfQuestions; ++i)
            {
                Console.WriteLine($"Q{i + 1}");
                Console.WriteLine($"{QuestionsOfExam[i].BodyQuestion}");
                Console.WriteLine($"Your Answer : {QuestionsOfExam[i].Answers[YourAnswers[i]].AnswerText}");
            }

            Console.WriteLine("--------------");

            Console.WriteLine($"Your Mark In The Exam Is : {YourMark} From {this.GetTotalMark()}");
        }

        public double GetTotalMark()
        {
            double Sum = 0;

            for(int i = 0; i < this.NumberOfQuestions; ++i)
            {
                Sum += QuestionsOfExam[i].MarkOfQuestion;
            }

            return Sum;
        }

        public double CheckAnswer(Question Q, int Choice)
        {
            if (Q.Answers[Choice - 1].AnswerText == Q.RightAnswer.AnswerText)
            {
                return Q.MarkOfQuestion;
            }

            return 0;
        }

        public void CreateFinallExam()
        {
            string Msg1 = "Enter The Time Of Exam In Minutes :";
            double TimeOfExam = 0.0;
            Helper.ReadDouble(ref TimeOfExam, Msg1);

            this.TimeOfExam = TimeOfExam;

            string Msg2 = "Enter The Number Of Questions :";
            int NumsOfQues = 0;
            Helper.ReadInt(ref NumsOfQues, Msg2);

            this.NumberOfQuestions = NumsOfQues;
            this.QuestionsOfExam = new Question[this.NumberOfQuestions];

            for (int i = 0; i < this.NumberOfQuestions; ++i)
            {
                string Msg0 = "Enter The Type Of The Question\n1 - True or False\n2 - MCQ";
                int ChoiceQuesType = 0;
                Helper.ReadInt(ref ChoiceQuesType, Msg0);

                if(ChoiceQuesType == 1)
                {
                    TrueOrFalseQuestion Q = new TrueOrFalseQuestion();
                    Console.WriteLine("--------");
                    Q.CreateQustion(i);
                    this.QuestionsOfExam[i] = new TrueOrFalseQuestion();
                    this.QuestionsOfExam[i] = Q;
                }
                else
                {
                    MCQQuestion Q = new MCQQuestion();
                    Console.WriteLine("--------");
                    Q.CreateQuestion(i);
                    this.QuestionsOfExam[i] = new MCQQuestion();
                    this.QuestionsOfExam[i] = Q;
                }
            }
        }
    }
}
