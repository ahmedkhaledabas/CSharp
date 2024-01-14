using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question
    {
        private List<string> _questions = new List<string>();
        private List<string> _answers = new List<string>();
        private List<string> _level = new List<string>();
        private List<int> _mark = new List<int>();
        private static int _totalGrade;
        private static int _grade;
        private int _numberOfQuestions;
        string Answer;

        public List<string> Questions { get => _questions; set => _questions = value;}
        public List<string> Answers { get => _answers; set => _answers = value; }
        public List<string> Level { get => _level; set => _level = value; }
        public List<int> Mark  { get => _mark; set => _mark = value; }
        public int Grade {get => _grade; set => _grade = value; }
        public int NumberOfQuestions { get => _numberOfQuestions; set => _numberOfQuestions = value; }

        public void WelcomeInstructor()
        {
            Console.WriteLine("welcome in system question bank");
            bool check;
            do
            {
                Console.WriteLine("enter number of questions");
                Console.WriteLine("Minimum 5 , Maximum 20");
                check = int.TryParse(Console.ReadLine(), out _numberOfQuestions);

                if (_numberOfQuestions >= 1 && _numberOfQuestions <= 20)
                {
                    check = true;
                }
                else check = false;
            } while (!check);
        }

        public void PrintQuestionsChoise()
        {
            Console.WriteLine("press 1 to true false");
            Console.WriteLine("press 2 to Choose");
            Console.WriteLine("press 3 to complete");
            Console.WriteLine("press 4 to translation");
        }

        public void TakeQuestion()
        {
            Console.WriteLine("enter question");
            Questions.Add(Console.ReadLine());
        }

        public void TakeAnswer()
        {
            Answer = "";
            Console.Write("enter answer : ");
            Answer = Console.ReadLine().ToLower().Trim();
            Answers.Add(Answer);
        }

        public void TakeLevel()
        {
            string level = "";
            bool checkLevel = true;
            do
            {
                Console.WriteLine("enter level [ Easy , Medium , Hard ]");
                level = Console.ReadLine().ToLower().Trim();
                if (level == "easy" || level == "medium" || level == "hard")
                {
                    checkLevel = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.ForegroundColor = ConsoleColor.Red;
            } while (checkLevel);
            Level.Add(level);
        }

        public void TakeMark()
        {
            int mark = 0;
            bool checkMark = true;
            do
            {
                Console.WriteLine("enter [ mark from 1 to 10 ]");
                bool x = int.TryParse(Console.ReadLine(), out mark);
                if (mark >= 1 && mark <= 10)
                {
                    checkMark = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }else Console.ForegroundColor = ConsoleColor.Red;
            } while (checkMark);
            Mark.Add(mark);
            _totalGrade += mark;
        }

        public virtual bool CheckAnswer(int i)
        {
            string answer = "";
            Console.Write("Your Answer : ");
            answer = Console.ReadLine().ToLower().Trim();
            Correction(i, answer.Trim());
            return answer == Answers[i];
        }

        public void startExam(string name)
        {
            Console.WriteLine($"{Questions.Count} {name}");
            Console.WriteLine("--------------------------------------\n");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($" Level : {Level[i].ToUpper()} , Mark : {Mark[i]}");
                Console.WriteLine($"No_{i + 1} - {Questions[i]} ? ");
                this.CheckAnswer(i);
            }
        }

        public void Correction(int i, string answer)
        {
            if (answer == Answers[i]) Grade += Mark[i];
        }

        public void WelcomeStudent()
        {
            Console.WriteLine("--------------WELCOME---------------");
            Console.WriteLine("-------------Start Exam-------------");
            Console.WriteLine($"{DateTime.Now.ToString("dddd, dd MMMM yyyy")}");
            Console.WriteLine("-----------BEST WISHES--------------\n");
        }

        public static void PrintGrade()
        {
            Console.WriteLine("\n");
            Console.WriteLine("--------------GOOD BEY-------------- \n");
            if (_grade >= (_totalGrade * 0.75))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent , GPA : A ");
            }
            else if (_grade < (_totalGrade * 0.75) && _grade >= (_totalGrade * 0.50))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Good , GPA : B ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Faild");
            }
            Console.WriteLine($"Your Grade : {_grade} from {_totalGrade}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------BEST WISHES--------------");
        }

    }
}
