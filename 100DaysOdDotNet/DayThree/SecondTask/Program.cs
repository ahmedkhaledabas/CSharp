using System.Text;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var chars = "ABCDEFGHIJKLMNOPQU";
            var rand = new Random();
            var s = new StringBuilder();
            for(int i = 0;i<9;i++)
            {
                var value = rand.Next(0,chars.Length);
                s.Append(chars[value]);
            }

            Console.WriteLine(s);

        }
    }
}
