using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_German_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestionBank qb = new QuestionBank("Goethe C2 Exam");
            qb.AllQuestions();

            Console.WriteLine("Welcome to " + qb.ExamName);
            Console.WriteLine("Question Count " + qb.QuestionCount());
            Console.WriteLine("Please type your name before the exam.");
            string name = Console.ReadLine();
            Console.WriteLine("Press enter to start the exam when you are ready! ");
            Console.ReadKey();

            int score = 0;

            for (int i = 0; i < qb.QuestionCount(); i++)
            {
                Console.Clear();
                Questions s = qb.ShowQs(i);
                Console.WriteLine($"{i + 1}) {s.TextWordArticle}");
                Console.WriteLine($"A) {s.A}");
                Console.WriteLine($"B) {s.B}");
                Console.WriteLine($"C) {s.C}");
                Console.WriteLine($"D) {s.D}");
                Console.Write("Your Answer = ");
                string answer = Console.ReadLine().ToUpper();
                               
                if (answer == s.Correct)
                {
                    score += 10;
                }
            }

            Console.Clear();
            Console.WriteLine("The exam is finished!");           

            if (score >= 60)
            {                
                Console.WriteLine($"Dear {name}, you have passed the exam. Congratulations!");
                Console.WriteLine($"Your score is {score}!");
                Console.Beep(300, 500); Console.Beep(500, 600); Console.Beep(700, 700); Console.Beep(900, 1000);
            }
            else 
            {                
                Console.WriteLine($"Dear {name}, unfortunately, you have failed the exam. Don't be sad. Maybe next time!");
                Console.WriteLine($"Your score is {score}!");
                Console.Beep(900, 500); Console.Beep(700, 600); Console.Beep(500, 700); Console.Beep(300, 1000);
            }









        }
    }
}
