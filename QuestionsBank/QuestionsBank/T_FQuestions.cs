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
                Console.WriteLine("enter answer [ True , False ]");
                Answer = Console.ReadLine().ToLower().Trim();
                if (Answer == "true" || Answer == "false") checkTrueFalse = false;
            } while (checkTrueFalse);
            Answers.Add(Answer);
        }

        public override bool CheckAnswer(int i)
        {
            do
            {
                checkTrueFalse = true;
                Answer = "";
                Console.WriteLine("Answer [ True , False ]");
                Console.Write("Your Answer : ");
                Answer = Console.ReadLine().ToLower().Trim();
                if (Answer == "true" || Answer == "false") checkTrueFalse = false;
                 Correction(i,Answer);
               
            } while (checkTrueFalse);
           return Answer == Answers[i];
        }
    }

}

