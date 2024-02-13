namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = new List<int>() {1,1,2,2,4,4,5,5,5};
           
           Console.WriteLine(pickingNumbers(numbers));

        }

        public static int pickingNumbers(List<int> a)
        {
          int count = 1;
          a.Sort();
          List<int> result = new List<int>();
          result.Add(a[0]);
            for (int i = 1; i < a.Count; i++ )
            {
                
                //for (int j = 0; j < a.Count; j++)
                //{
                //    if (i == j) continue;
                    if (a[i] - a[i-1] <= 1)
                    {
                        result.Add(a[i]);
                        if (result.Count == 5)
                        {
                            result.Clear();
                            count++;
                        }
                    }
                    else
                    {
                        result.Clear();
                        count++;
                    }
                //}
            }
            //The maximum length subarray has 5 elements.
           
            return count;
        }
    }
}
