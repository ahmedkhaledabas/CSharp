using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class T_FQuestions : Question
    {
        private bool checkTrueFalse;
        string Answer;

        public void TakeAnswer()
        {
            checkTrueFalse = true;
            Answer = "";
            do
            {
                Console.Write("Enter Your Correct Answer [ True , False ] : ");
                Answer = Console.ReadLine().ToLower().Trim();
                if (Answer == "true" || Answer == "false") 
                {
                    checkTrueFalse = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }else Console.ForegroundColor = ConsoleColor.Red;
            } while (checkTrueFalse);
            Answers.Add(Answer);
        }

        public override void CheckAnswer(int i)
        {
            do
            {
                checkTrueFalse = true;
                Answer = "";
                Console.Write("Answer [ True , False ]" + "\nYour Answer : ");
                Answer = Console.ReadLine().ToLower().Trim();
                if (Answer == "true" || Answer == "false")
                {
                    checkTrueFalse = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.ForegroundColor = ConsoleColor.Red;
                Correction(i,Answer);
               
            } while (checkTrueFalse);
           //return Answer == Answers[i];
        }
    }

}

