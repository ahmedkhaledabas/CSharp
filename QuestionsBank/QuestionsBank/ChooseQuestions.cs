using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ChooseQuestions : Question
    {
        static bool s;
        string[] ChoicesAnswers;

        public void TakeAnswer()
        {
            string a = "";
            string b = "";
            string c = "";
            string d = "";
            string correctAnswer;

            Console.WriteLine("enter 4 choices");
            Console.Write("A - ");
            a = Console.ReadLine().ToLower().Trim();
            
            do
            {
                s = true;
                Console.Write("B - ");
                b = Console.ReadLine().ToLower().Trim();
                if (b != a) s = false;
            } while (s);

            do
            {
                s = true;
                Console.Write("C - ");
                c = Console.ReadLine().ToLower().Trim();
                if (c != b && c != a) s = false;
            } while (s);

            do
            {
                s = true;
                Console.Write("D - ");
                d = Console.ReadLine().ToLower().Trim();
                if (d != c && d != a && d != b) s = false;
            } while (s);

            do
            {
                s = true;
                Console.Write("enter the correct answer :  ");
                correctAnswer = Console.ReadLine().ToLower().Trim();
                if (correctAnswer == a || correctAnswer == b || correctAnswer == c || correctAnswer == d) s = false;
            } while (s);
            Answers.Add($"{a} , {b} , {c} , {d} , {correctAnswer}");
        }

        public override bool CheckAnswer(int i)
        {
            string answer;
            ChoicesAnswers = Answers[i].Split(',');
            Console.WriteLine($"A - {ChoicesAnswers[0]} , B - {ChoicesAnswers[1]} , C - {ChoicesAnswers[2]} , D - {ChoicesAnswers[3]}");
            do
            {
                s = true;
                Console.Write("Your Answer : ");
                answer = Console.ReadLine().ToLower().Trim();
                foreach (var item in ChoicesAnswers)
                {
                    if (item.Trim() == answer)
                    {
                        s = false;
                        break;
                    }
                }
            } while (s);
            string CorrectAnswer = ChoicesAnswers[ChoicesAnswers.Length - 1].ToLower().Trim();
            Correction(i, answer);
            return answer == CorrectAnswer;
        }

        public void Correction(int i, string answer)
        {
            if (answer == ChoicesAnswers[0].Trim() || answer == ChoicesAnswers[1].Trim() || answer == ChoicesAnswers[2].Trim() || answer == ChoicesAnswers[3].Trim()) Grade += Mark[i];
        }

    }
}
