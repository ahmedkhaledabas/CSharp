﻿using QuestionsBank;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Question chooseQuestions = new ChooseQuestions();
            Question t_FQuestions = new T_FQuestions();
            Question completeQuestions = new CompleteQuestions();
            Question translateQuestion = new TranslateQuestion();
            chooseQuestions.WelcomeInstructor();

            bool x;
            int choosenQuestion;
            do
            {
                chooseQuestions.PrintQuestionsChoise();
                chooseQuestions.NumberOfQuestions--;
                x = int.TryParse(Console.ReadLine(), out choosenQuestion);
                switch (choosenQuestion)
                {
                    case 1:
                        {
                            t_FQuestions.TakeQuestion();
                            t_FQuestions.TakeAnswer();
                            t_FQuestions.TakeLevel();
                            t_FQuestions.TakeMark();
                        }
                        break;

                    case 2:
                        {
                            chooseQuestions.TakeQuestion();
                            chooseQuestions.TakeAnswer();
                            chooseQuestions.TakeLevel();
                            chooseQuestions.TakeMark();
                        }
                        break;

                    case 3:
                        {
                            completeQuestions.TakeQuestion();
                            completeQuestions.TakeAnswer();
                            completeQuestions.TakeLevel();
                            completeQuestions.TakeMark();
                        }
                        break;

                    case 4:
                        {
                            translateQuestion.TakeQuestion();
                            translateQuestion.TakeAnswer();
                            translateQuestion.TakeLevel();
                            translateQuestion.TakeMark();
                        }
                        break;

                    default:
                        {

                        }
                        break;
                }

            } while (!x || chooseQuestions.NumberOfQuestions != 0);

            t_FQuestions.WelcomeStudent();
            if (chooseQuestions.Questions.Count > 0) chooseQuestions.startExam("MCQ Questions");
            Console.WriteLine("\n");
            if (t_FQuestions.Questions.Count > 0) t_FQuestions.startExam("True & False Questions");
            Console.WriteLine("\n");
            if (completeQuestions.Questions.Count > 0) completeQuestions.startExam("Complete Questions");
            Console.WriteLine("\n");
            if (translateQuestion.Questions.Count > 0) translateQuestion.startExam("Translate Questions");
            Question.PrintGrade();
            chooseQuestions.CorrectionAnswer();
            t_FQuestions.CorrectionAnswer();
            completeQuestions.CorrectionAnswer();
            translateQuestion.CorrectionAnswer();
        }
    }
}