namespace HackerRankTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = new List<int>() { 100 ,99 ,98 ,97 ,96 ,95 ,94 ,93, 92 ,91 };
            List<int> list1 = new List<int>() { 1, 2 ,3, 4, 5 ,6 ,7 ,8, 9 ,10 };
            Console.WriteLine(getTotalX(list,list1));
        }


        public static int getTotalX(List<int> a, List<int> b)
        {
            a.Sort();
            b.Sort();
            string s = "";
            string s2 = "";
            int result = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (i == a.Count - 1) break;
                if (a[i + 1] % a[i] == 0)
                {
                    result++;
                    for (int j = 0; j < b.Count; j++)
                    {
                        if (b[j] % a[i] == 0) s += '1';
                        else s += 0;
                    }
                }
                else
                {
                    for (int q = 0; q < b.Count; q++)
                    {
                        if (b[q] % (a[i] * a[i + 1]) == 0) s2 += '1';
                        else s2 += '0';
                    }
                }
            }

            if (s.Contains('0')) { }
            else result++;
            if (s2.Contains('0')) { }
            else result++;
            return result;
        }
    }
}
