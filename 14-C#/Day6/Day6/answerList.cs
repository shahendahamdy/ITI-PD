  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class answerList
    {
        public int qid;
        public List<string> answer;


        public answerList() { 
            answer= new List<string>();
        }
        public void addAnswerstoQuestion(int qid, string ansr)
        {
            this.qid = qid;
            answer.Add(ansr);

        }

        public void addAnswerstoQuestion(int qid, List<string> Qansr)
        {
            this.qid = qid;
            foreach(string s in Qansr)
            {
                answer.Add(s);
            }

        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in answer)
            {
                s += item.ToString()+"\n";
            }
            return s;
        }
    }
}
