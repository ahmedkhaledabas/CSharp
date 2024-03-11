using System.Collections.Generic;

namespace HackerRankTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-yes  2-  no   3- 


            var aName =  typeof(Program).Assembly.GetName().Name;
            Console.WriteLine(aName);
        }

        public static string gridChallenge(List<string> grid)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < grid.Count; i++)
            {
                    char[] arr = grid[i].ToCharArray();
                    Array.Sort(arr);
                grid[i] = new string(arr);
            }
           for(int i =0; i < result.Count; i++)
            {
                string s = "";
                //for (int j = 0; j < result[i].Length; j++)
                    for (int j = 0; j < result.Count; j++)
                    {
                    if (i == result.Count - 1) break;
                    s += result[j][i];
                }
                char[] arr = s.ToCharArray().Distinct().ToArray();
                Array.Sort(arr);
                string output = new string(arr);
                if (output is string && s == output);
                else return "NO";
            }
            return "YES";
        }
        public static string gridChallenge1(List<string> grid)
        {
            for (int i = 0; i < grid.Count; i++)
            {
                char[] row = grid[i].ToCharArray();
                Array.Sort(row);
                grid[i] = new string(row);
            }

            for (int j = 0; j < grid[0].Length; j++)
            {
                for (int i = 0; i < grid.Count - 1; i++)
                {
                    if (grid[i][j] > grid[i + 1][j])
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }



        //public static int getTotalX(List<int> a, List<int> b)
        //{
        //    a.Sort();
        //    b.Sort();
        //    string s = "";
        //    string s2 = "";
        //    int result = 0;
        //    for (int i = 0; i < a.Count; i++)
        //    {
        //        if (i == a.Count - 1) break;
        //        if (a[i + 1] % a[i] == 0)
        //        {
        //            result++;
        //            for (int j = 0; j < b.Count; j++)
        //            {
        //                if (b[j] % a[i] == 0) s += '1';
        //                else s += 0;
        //            }
        //        }
        //        else
        //        {
        //            for (int q = 0; q < b.Count; q++)
        //            {
        //                if (b[q] % (a[i] * a[i + 1]) == 0) s2 += '1';
        //                else s2 += '0';
        //            }
        //        }
        //    }

        //    if (s.Contains('0')) { }
        //    else result++;
        //    if (s2.Contains('0')) { }
        //    else result++;
        //    return result;
        //}
    }
}
