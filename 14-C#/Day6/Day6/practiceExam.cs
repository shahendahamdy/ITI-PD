using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class practiceExam : Exam
    {
        public override void showExam()
        {
            int res = 0;

            for (int i = 0; i < qlst.Count; i++)
            {
                Console.WriteLine(qlst[i].Body+'\n');
                qlst[i].showAns();
                Console.WriteLine("enter the ans");
                string ans = Console.ReadLine();
                Console.WriteLine("the right answer is " + qlst[i].ModelAns);
                if (ans == qlst[i].ModelAns) { Console.WriteLine("your score is " + qlst[i].marks); res += qlst[i].marks; }
                else Console.WriteLine("your score is 0");
            }
            Console.WriteLine("total marks :: " + res + " marks");
        }
    }
}
