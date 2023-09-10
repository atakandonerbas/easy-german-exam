using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_German_Exam
{
    internal class QuestionBank
    {
        Questions[] qs;
        public string ExamName { get; set; }

        public QuestionBank(string examName)
        {
            qs = new Questions[0];
            ExamName = examName;
        }

        public void add(Questions q) 
        {
            Questions[] temp = new Questions[qs.Length +1];
            Array.Copy(qs, temp, qs.Length);
            temp[temp.Length -1] = q; 
            qs = temp;
        }

        public void AllQuestions()
        {
            add(new Questions() { TextWordArticle = "Was ist deine Beruf?", A = "Ich komme aus Schweden.", B = "Ich liebe so viele Katzen.", C = "Ich lebe in der Turkei.", D = "Ich bin Kellner.", Correct = "D" });
            add(new Questions() { TextWordArticle = "Woher kommen Sie?", A = "Ich gehe ins Krankenhaus.", B = "Ich mag das Hemd.", C = "Ich komme aus Österreich.", D = "Ich bin nicht gut.", Correct = "C" });
            add(new Questions() { TextWordArticle = "Wo leben Sie?", A = "Eskişehir ist sehr klein.", B = "Ich lebe in Detschland.", C = "Ich habe Dorst.", D = "Ich fahre das Auto sehr schlecht.", Correct = "B" });
            add(new Questions() { TextWordArticle = "Wie alt sind Sie?", A = "Ich bin zweiundzwanzig Jahre alt.", B = "Ich habe kein Hund.", C = "Ich möchte so viele Brötchen essen.", D = "Das Wetter ist sehr heiss.", Correct = "A" });
            add(new Questions() { TextWordArticle = "tragen", A = "to undress", B = "to wear", C = "to die", D = "to read", Correct = "B" });
            add(new Questions() { TextWordArticle = "der Schauspieler", A = "waiter", B = "worker", C = "actor", D = "lawyer", Correct = "C" });
            add(new Questions() { TextWordArticle = "... Tier", A = "das", B = "den", C = "der", D = "die", Correct = "A" });
            add(new Questions() { TextWordArticle = "die Tür", A = "building", B = "door", C = "carpet", D = "floor", Correct = "B" });
            add(new Questions() { TextWordArticle = "schwimmen", A = "to play", B = "to run", C = "to swim", D = "to climb", Correct = "C" });
            add(new Questions() { TextWordArticle = "... Stadt", A = "das", B = "der", C = "den", D = "die", Correct = "D" });
        }
        public int QuestionCount()
        {
            return qs.Length;
        }

        public Questions ShowQs(int index) 
        {
            return qs[index];
        }
    }
}
