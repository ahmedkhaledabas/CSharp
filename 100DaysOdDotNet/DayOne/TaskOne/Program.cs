namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = MakeArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == 0) Console.Write("Your Array : \n{ ");
                if(i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                    Console.Write(" }\n");
                }
                else
                {
                    Console.Write(arr[i]);
                    Console.Write(" , ");
                }
            }
            Console.WriteLine($"Maximun Value : {GetMax(arr)} \nMinimum Value : {GetMin(arr)} \nAvarage :{GetAvg(arr)}");
        }

        public static int[] MakeArray()
        {
            Console.WriteLine("Enter Size Of Array");
            int size = Convert.ToInt16(Console.ReadLine());
            int[] ints = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter Elements Number {i + 1}");
                ints[i] = Convert.ToInt16(Console.ReadLine());
            }

            return ints;
        }

        public static int GetMax(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length - 1];
        }

        public static int GetMin(int[] arr)
        {
            Array.Sort(arr);
            return arr[0];
        }

        public static double GetAvg(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum / arr.Length;
        }

    }
}
