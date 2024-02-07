namespace GenericDelegateType
{
    public delegate bool Filter<T>(T n);
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new int[]{1,2,3,4,5,6,7,8,9};
            Console.WriteLine("Less Than 6");
            PrintNumbers(numbers, n => n < 6);
            Console.WriteLine("\n-----------\n");

            IEnumerable<int> numbers3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Greter Than 4");
            PrintNumbers(numbers, n => n > 4);
            Console.WriteLine("\n-----------\n");

            IEnumerable<decimal> numbers2 = new decimal[] { 1.1m, 2.1m, 3.1m, 4.1m, 5.1m, 6.1m, 7.1m, 8.1m, 9.1m };
            Console.WriteLine("Greater Than 6.1");
            PrintNumbers(numbers2, n => n > 6.1m);
        }

        public static void PrintNumbers<T>(IEnumerable<T> numbers , Filter<T> filter)
        {
            foreach (var item in numbers)
            {
                if (filter(item)) Console.WriteLine(item);
            }
        }

    }
}
