using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal static class Helper
    {
        public static void ReadInt(ref int Temp, string Msg)
        {
            while (true)
            {
                Console.WriteLine(Msg);
                bool Flag = int.TryParse(Console.ReadLine(), out Temp);

                if (Flag == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Replay : Please Enter The Numeric Value");
                }
            }
        }

        public static void ReadDouble(ref double Temp, string Msg)
        {
            while (true)
            {
                Console.WriteLine(Msg);
                bool Flag = double.TryParse(Console.ReadLine(), out Temp);

                if (Flag == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Replay : Please Enter The Numeric Value");
                }
            }
        }
    }
}
