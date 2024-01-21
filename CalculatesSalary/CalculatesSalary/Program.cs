using System.ComponentModel;

namespace CalculatesSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(1, "Ahmed", 180, 10);
            Maintenance mc = new Maintenance(2, "Ali", 182, 8);
            Sales s = new Sales(3, "Khalid", 176, 9, 10000, .05m);
            Developer d = new Developer(4, "Ahmed Khaled", 186, 15, true);


            Employee[] emps = { m, mc, s, d };

            foreach (var item in emps)
            {
                Console.WriteLine(" \n --------------------");
                Console.WriteLine(item);
            }
        }
    }
}