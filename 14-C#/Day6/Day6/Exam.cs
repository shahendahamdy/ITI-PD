using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    abstract class Exam
    {
       protected QuestionList qlst = new QuestionList();

        DateTime time;
        int numOfQues;
        protected answers studentAnswersss;

        

        public void AddQuestionList(QuestionList questionList)
        {
            qlst = questionList;
        }
        public abstract void showExam();

    }
}
