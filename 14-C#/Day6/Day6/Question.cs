using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Question
    {
        public int qId { get; set; }
        public int marks { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public answerList ansrs;
        string modelAns;
        public Question(int id,string body ,int mark ,string modelAn) 
        {
            qId = id;
            Body= body;
            marks = mark;
            modelAns = modelAn;
            ansrs = new answerList();
        }
       
        public string ModelAns { get { return modelAns; } set { modelAns = value; } }
    
        
        public void showAns()
        {
            for (int i = 0; i < ansrs.answer.Count; i++)
            {
                Console.WriteLine(ansrs.answer[i] + "\n");

            }
        }
    }

    class TF : Question
    {
        public TF(int id, string body, int mark, string modelAn) : base(id, body, mark, modelAn)
        {
        }
    }
    class ChooseOne : Question
    {
        public ChooseOne(int id, string body, int mark, string modelAn) : base(id, body, mark, modelAn)
        {
        }
    }
    class ChooseAll : Question
    {
        public ChooseAll(int id, string body, int mark, string modelAn) : base(id, body, mark, modelAn)
        {
        }
    }

}
