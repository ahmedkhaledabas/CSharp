using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {2,5,4,5,2 };
            List<int> list1 = new List<int>() { 5,25,50,120};

            int index = char.ToUpper('a') - 64;
            decimal x = (5 / 2);
            string s = "abs";
            Console.WriteLine(saveThePrisoner(94431605, 679262176, 5284458));

            //Console.WriteLine(Math.Abs(4-5));
            //Console.WriteLine(Math.Abs(5 - 4));
        }
        //,,,,,5,5,5,5,6


        static int saveThePrisoner(int n, int m, int s)
        {
            if (s > n) s = s % n; // adjust s to be within the range of 1 to n
            if (m > n) m = m % n; // adjust m to be within the range of 1 to n

            for (int i = s; i <= n; i++)
            {
                m--;
                if (m == 0) return i;

                if (i == n) i = 1; // reset i to 1 when it reaches n
            }

            // return the last prisoner if m reaches 0
            return n;
        }





        public static int viralAdvertising(int n)
        {
            int shared = 0;
            int liked = 0;
            int cumulative = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    shared = 5;
                }
                else
                {
                    shared = liked * 3;
                }
                decimal x = (shared / 2);
                liked = (int)Math.Floor(x);
                cumulative += liked;
            }
            return cumulative;
        }



        public static int beautifulDays(int i, int j, int k)
        {
            int beautifulDays = 0;
            for (int strat = i; strat <= j; strat++)
            {
                int reversedNumber = 0;
                while (strat != 0)
                {
                    reversedNumber = (reversedNumber * 10) + (strat % 10);
                    strat =(int) decimal.Truncate((strat / 10));
                }
                strat = i;
                i++;
                if (((strat - reversedNumber) % k ) == 0) beautifulDays++;
            }
            return beautifulDays;
        }

        public static int hurdleRace(int k, List<int> height)
        {
            int max = height.Max();
            if (k >= max) return 0;
            else return max - k;
        }

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> res = new List<int>();
            List<int> sorted = ranked.Distinct().OrderByDescending(n => n).ToList();
            
            for (int i = 0; i < sorted.Count; i++)
            {
                if (player.Count == 0) break;
                int play = player[0];
                if (sorted[i] > play)
                {
                    if (i == sorted.Count-1)
                    {
                        res.Add(i + 2);
                        player.Remove(play);
                        sorted.Insert(i + 1, play);
                        i = -1;
                        continue;
                    }
                    else continue;
                }
                else if (sorted[i] == play)
                {
                    res.Add(i + 1);
                    player.Remove(play);
                    sorted.Insert(i+1,play);
                    i = -1;
                    continue;
                }
                else
                {
                    res.Add(i+1);
                    player.Remove(play);
                    sorted.Insert(i + 1, play);
                    i = -1;
                    continue;
                }


            }
            return res;
        }
   







    public static int utopianTree(int n)
        {
            int result = 1;
            int j = 1;
            for (int i = 1; i <= n; i++)
            {
                if (j == 3)
                {
                    j = 1;
                    result = result * 2;
                    
                }
                else
                {
                    j++;
                    result++;
                }
            }
            return result;

        }


        static int getMoneySpent(List<int> keyboards, List<int> drives, int b)
        {

            List<int> sum = new List<int>();
            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    if ((keyboard + drive) < b)
                    {
                        sum.Add(keyboard + drive);
                    }
                }
            }
            return sum.Count>0 ? sum.Max() : -1;

        }
        public static int sockMerchant(int n, List<int> ar)
        {
            int result = 0;
            ar.Sort();
            for (int i = 0; i < ar.Count;)
            {
                if (i == ar.Count - 1) break;
                if (ar[i] == ar[i + 1])
                {
                    result++;
                    ar.Remove(ar[i]);
                    ar.Remove(ar[i]);
                   
                }
                else
                {
                    ar.Remove(ar[i]);
                    
                }
            }
            return result;

        }
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int total = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (bill[i] == k) continue;
                else total += bill[i];
            }
            Console.WriteLine((total / 2) == b ? (b - (total / 2)) : "Bon Appetit");
        }



        public static string dayOfProgrammer(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                return $"12.09.{year}";
            }
            else {
                return $"13.09.{year}";
            }
        }


        public static int divisibleSumPairs( int k, List<int> ar)
        {
            int result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0) result++;
                }
            }
            return result;
        }




        //public static string gridChallenge(List<string> grid)
        //{
        //    List<string> result = new List<string>();
        //    for (int i = 0; i < grid.Count; i++)
        //    {
        //            char[] arr = grid[i].ToCharArray();
        //            Array.Sort(arr);
        //        grid[i] = new string(arr);
        //    }
        //   for(int i =0; i < result.Count; i++)
        //    {
        //        string s = "";
        //        //for (int j = 0; j < result[i].Length; j++)
        //            for (int j = 0; j < result.Count; j++)
        //            {
        //            if (i == result.Count - 1) break;
        //            s += result[j][i];
        //        }
        //        char[] arr = s.ToCharArray().Distinct().ToArray();
        //        Array.Sort(arr);
        //        string output = new string(arr);
        //        if (output is string && s == output);
        //        else return "NO";
        //    }
        //    return "YES";
        //}
        //public static string gridChallenge1(List<string> grid)
        //{
        //    for (int i = 0; i < grid.Count; i++)
        //    {
        //        char[] row = grid[i].ToCharArray();
        //        Array.Sort(row);
        //        grid[i] = new string(row);
        //    }

        //    for (int j = 0; j < grid[0].Length; j++)
        //    {
        //        for (int i = 0; i < grid.Count - 1; i++)
        //        {
        //            if (grid[i][j] > grid[i + 1][j])
        //            {
        //                return "NO";
        //            }
        //        }
        //    }

        //    return "YES";
        //}



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
