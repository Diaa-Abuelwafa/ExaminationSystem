namespace ExamOOP
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("============= Examination Sysytem =============");

            Console.WriteLine("Enter The Subject Of Exam You Need To Creation : ");
            string? SubjectName = Console.ReadLine();

            Subject S1 = new Subject(10, SubjectName);

            // Create The Exam
            S1.CreateTheExam();

            // Start The Exam And Calculate Time Consumed
            string? Msg = "Do You Want To Start The Exam\n1- Yes\n2 - No";
            int Choice = 0;
            Helper.ReadInt(ref Choice, Msg);

            if(Choice == 1)
            {
                S1.StartExam();
            }

        }
    }
}