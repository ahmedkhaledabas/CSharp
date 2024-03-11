namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello Dears\n Do you want change Colors ?  [ YES | NO ]");
            var response = Console.ReadLine();
            if(response == "YES")
            {
                Console.WriteLine("Change Text Color Press 1");
                Console.WriteLine("Change Background Color Press 2");
                var choice = Convert.ToInt16(Console.ReadLine());
                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                {
                    Console.WriteLine(color);
                }
                Console.WriteLine("Choose your fav color");
                var colorName =(ConsoleColor) Enum.Parse(typeof(ConsoleColor), Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.ForegroundColor = colorName;
                        break;
                    case 2:
                        Console.BackgroundColor = colorName;
                        break;
                    default:
                        Console.WriteLine("wrong");
                        break;
                }
            }
            Console.WriteLine("Thank You ");

        }
    }
}
