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

        
        public override void TakeAnswer()
        {
            string a , b , c , d = "";
            //string b = "";
            //string c = "";
            //string d = "";
            string correctAnswer;

            Console.WriteLine("Enter 4 Choices");
            Console.Write("A - ");
            a = Console.ReadLine().ToLower().Trim();
            
            do
            {
                s = true;
                Console.Write("B - ");
                b = Console.ReadLine().ToLower().Trim();
                if (b != a)
                {
                    s = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }else Console.ForegroundColor = ConsoleColor.Red;
            } while (s);

            do
            {
                s = true;
                Console.Write("C - ");
                c = Console.ReadLine().ToLower().Trim();
                if (c != b && c != a)
                {
                    s = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.ForegroundColor = ConsoleColor.Red;
            } while (s);

            do
            {
                s = true;
                Console.Write("D - ");
                d = Console.ReadLine().ToLower().Trim();
                if (d != c && d != a && d != b)
                {
                    s = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.ForegroundColor = ConsoleColor.Red;
            } while (s);

            do
            {
                s = true;
                Console.Write("Enter The Correct Answer :  ");
                correctAnswer = Console.ReadLine().ToLower().Trim();
                if (correctAnswer == a || correctAnswer == b || correctAnswer == c || correctAnswer == d)
                {
                    s = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.ForegroundColor = ConsoleColor.Red;
            } while (s);
            Answers.Add($"{a} , {b} , {c} , {d} , {correctAnswer}");
        }

        public override void CheckAnswer(int i)
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
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else Console.ForegroundColor = ConsoleColor.Red;
                }
            } while (s);
           
            Correction(i, answer);
        }

        public override void Correction(int i, string answer)
        {
            string CorrectAnswer = ChoicesAnswers[ChoicesAnswers.Length - 1].ToLower().Trim();
            if (answer == CorrectAnswer)
            {

                Grade += Mark[i];
            }
            else Corrections.Add(answer, i);
        }

        public override void CorrectionAnswer()
        {
            if (Corrections.Count > 0)
            {
                foreach (var item in Corrections)
                {
                     Console.ForegroundColor = ConsoleColor.White;
                     Console.WriteLine($"{Questions[item.Value]} ? ");
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine($"Your Answer : {item.Key}");
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine($"The Correct Answer : {ChoicesAnswers[ChoicesAnswers.Length - 1]}\n");
                }
                     Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
