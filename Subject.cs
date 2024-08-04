using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }

        public Subject(int id, string subjectname)
        {
            this.SubjectId = id;
            this.SubjectName = subjectname;
        }

        public void CreateTheExam()
        {
            int ChoiceTheType = 0;
            string Msg = "Enter The Type Of Exam You Need To Creation : \n1 - Practical Exam\n2 - Final Exam";
            Helper.ReadInt(ref ChoiceTheType, Msg);

            if(ChoiceTheType == 1)
            {
                PracticalExam PE = new PracticalExam(this);
                PE.CreatePracticalExam();
                this.ExamOfSubject = PE;
            }
            else if(ChoiceTheType == 2)
            {
                FinalExam FE = new FinalExam(this);
                FE.CreateFinallExam();
                this.ExamOfSubject = FE;
            }
        }

        public void StartExam()
        {
            Stopwatch SP = new Stopwatch();

            SP.Start();

            ExamOfSubject.ShowExam();

            SP.Stop();

            TimeSpan T = SP.Elapsed;

            Console.WriteLine($"Time Consumed In The Exam :: {T}");
        }
    }
}
