namespace CAStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<Command> redo = new Stack<Command>();
           Stack<Command> undo = new Stack<Command>();
            string input;

            while(true)
            {
                Console.Write("Enter Exit To Quit : ");
                input = Console.ReadLine().ToLower();
                if (input == "exit")
                {
                    break;
                }
                else if (input == "back")
                {
                    if (undo.Count > 0)
                    {
                        var item = undo.Pop();
                        redo.Push(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (input == "forward")
                {
                    if (redo.Count > 0)
                    {
                        var item = redo.Pop();
                        undo.Push(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else // www.google.com
                {
                    undo.Push(new (input));
                }
                Console.Clear();
                Print("back", undo);
                Print("forward", redo);
            }
            
        }

        public static void Print(string name , Stack<Command> commands)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkBlue : ConsoleColor.DarkGreen;
            foreach (var item in commands)
            {
                Console.WriteLine($"\t{item }");
            }
            Console.BackgroundColor= ConsoleColor.Black;
        }
    }



    public class Command
    {
        private readonly string _url;
        private readonly DateTime _createdAt;

        public Command(string url)
        {
            _url = url;
            _createdAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{_createdAt}]  {_url}";
        }
    }
}
