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
        private  Dictionary <string,int> _corrections= new Dictionary<string,int>();
        private static int _totalGrade;
        private static int _grade;
        private int _numberOfQuestions;
        string Answer;

        public Dictionary<string,int> Corrections { get => _corrections; set => _corrections = value; }
        public List<string> Questions { get => _questions; set => _questions = value;}
        public List<string> Answers { get => _answers; set => _answers = value; }
        public List<string> Level { get => _level; set => _level = value; }
        public List<int> Mark  { get => _mark; set => _mark = value; }
        public int Grade {get => _grade; set => _grade = value; }
        public int NumberOfQuestions { get => _numberOfQuestions; set => _numberOfQuestions = value; }

        public void WelcomeInstructor()
        {
            Console.WriteLine("Welcome In System Question Bank");
            bool check;
            do
            {
                Console.WriteLine(" Enter Number Of Questions" + "\n  Minimum 5 , Maximum 20");
                check = int.TryParse(Console.ReadLine(), out _numberOfQuestions);
                if (_numberOfQuestions >= 1 && _numberOfQuestions <= 20)
                {
                    check = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    check = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            } while (check);
        }

        public void PrintQuestionsChoise()
        {
            Console.WriteLine("Press 1 To True & False" + "\nPress 2 To Choose" +
                              "\nPress 3 To Complete"   + "\nPress 4 To Translation");
        }

        public void TakeQuestion()
        {
            Console.Write("Enter Your Question : ");
            Questions.Add(Console.ReadLine());
        }

        public virtual void TakeAnswer()
        {
            Answer = "";
            Console.Write("Enter Your Correct Answer : ");
            Answer = Console.ReadLine().ToLower().Trim();
            Answers.Add(Answer);
        }

        public void TakeLevel()
        {
            string level = "";
            bool checkLevel = true;
            do
            {
                Console.Write("Enter Question Level [ Easy , Medium , Hard ] : ");
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
                Console.Write("Enter Question Mark [ From 1 to 10 ] : ");
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

        public virtual void CheckAnswer(int i)
        {
            string answer = "";
            Console.Write("Your Answer : ");
            answer = Console.ReadLine().ToLower().Trim();
            Correction(i, answer);
            //return answer == Answers[i];
        }

        public void startExam(string name)
        {
            Console.WriteLine($"{Questions.Count} {name}"+ "\n--------------------------------------");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($" Level : {Level[i]} , Mark : {Mark[i]}"+
                                  $"\nNo_{i + 1} - {Questions[i]} ? ");
                this.CheckAnswer(i);
            }
        }

        public virtual void Correction(int i, string answer)
        {
            if (answer == Answers[i])
            {
                Grade += Mark[i];
            }
            else
            {
                Corrections.Add(answer , i );
            }
        }

        public  void CorrectionAnswer()
        {
                if(Corrections.Count > 0)
            {
                foreach (var item in Corrections)
                {
                     Console.ForegroundColor= ConsoleColor.White;
                     Console.WriteLine($"{Questions[item.Value]} ? ");
                     Console.ForegroundColor= ConsoleColor.Red;
                     Console.WriteLine($"\nYour Answer : {item.Key}");
                     Console.ForegroundColor= ConsoleColor.Green;
                     Console.WriteLine($"The Correct Answer: { Answers[item.Value]}\n");
                }
                        Console.ForegroundColor= ConsoleColor.White;
            }
        }
        public void WelcomeStudent()
        {
            Console.WriteLine("--------------WELCOME---------------"+
                              "\n-------------Start Exam-------------" + 
                              $"\n{DateTime.Now}" +
                              "\n-----------BEST WISHES--------------\n");
        }

        public static void PrintGrade()
        {
            Console.WriteLine("\n--------------GOOD BEY--------------");
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
