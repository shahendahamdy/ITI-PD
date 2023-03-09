using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class finalExam : Exam
    {
        public override void showExam()
        {
            int res = 0;

            for (int i = 0; i < qlst.Count; i++)
            {
                Console.WriteLine(qlst[i].Body + '\n');
                qlst[i].showAns();
                Console.WriteLine("enter the ans");
                string ans = Console.ReadLine();
                if (ans == qlst[i].ModelAns) { res += qlst[i].marks; }
            }
            Console.WriteLine("total marks :: " + res + " marks");
        }
    }
}
