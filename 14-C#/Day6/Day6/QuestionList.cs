using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/
namespace Day6
{
    internal class QuestionList: List<Question> 
    {
        public static int num=0;
        public int added=0;
        public QuestionList()
        {
            num++;
        }
        public new void add(Question q)
        {
            string createText = q.Body +'\n';
            string path = $@"I:\.ITI\17.C#\C# workspace\Day6\Day6\txt\{num}.txt";
            if (added == 0)
            {
                File.WriteAllText(path, "");
            }
            added++;
            File.AppendAllText(path, createText);
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            base.Add(q);

        }

    }
}
