namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pepole = new Any<Person>();
            pepole.Add(new Person("Ahmed", "Khaled"));
            pepole.Add(new Person("Tasneem", "Khaled"));
            pepole.Add(new Person("Shrouk", "Khaled"));

            pepole.DisplayList();
            pepole.RemoveAt(1);
            Console.WriteLine("");
            pepole.DisplayList();
            Console.WriteLine("\n\n---------------------\n");

            var numbers = new Any<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.DisplayList();
            numbers.RemoveAt(1);
            Console.WriteLine("");
            numbers.DisplayList();
        }
    }
}
