using System.Collections.Generic;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Question q1 = new Question(1, "question1", 1, "a1");
            Question q2 = new Question(2, "question2", 1, "b1");
            Question q3 = new Question(3, "question3", 1, "a1");
            Question q4 = new Question(4, "question4", 1, "d1");


            q1.ansrs.addAnswerstoQuestion(q1.qId, new List<string> { "a1","b1","c1","d1"});
            q2.ansrs.addAnswerstoQuestion(q2.qId, new List<string> { "a1", "b1", "c1", "d1" });
            q3.ansrs.addAnswerstoQuestion(q3.qId, new List<string> { "a1", "b1", "c1", "d1" });
            q4.ansrs.addAnswerstoQuestion(q4.qId, new List<string> { "a1", "b1", "c1", "d1" });

            QuestionList l1 = new QuestionList();
            l1.add(q1);
            l1.add(q2);
            l1.add(q3);
            l1.add(q4);

            QuestionList l2 = new QuestionList();
            l2.add(q1);
            l2.add(q2);
            l2.add(q3);

            practiceExam pe1 = new practiceExam();
            pe1.AddQuestionList(l1);
            pe1.showExam();

            finalExam f = new finalExam();
            f.AddQuestionList(l2);
            f.showExam();
        }
    }
}