namespace Documentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            var stream = typeof(Program).Assembly.GetManifestResourceStream(typeof(Program),"Data.Contries.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write((char)data[i]);
                System.Threading.Thread.Sleep(300);
            }
            stream.Close();


        }

        /// <summary>
        /// deference between max and min 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="arr"></param>
        /// <returns>
        /// type integer
        /// </returns>
        public static int maxMin(int k, List<int> arr)
        {
            int count = arr.Count;
            arr.Sort();
            int minUnfairness = int.MaxValue;
            List<int> ints = new List<int>();
            List<int> res = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (ints.Count == k)
                {
                    int max = ints.Max();
                    int min = ints.Min();
                    res.Add(max - min);
                    ints.Clear();
                    i--;
                }
                else
                {
                    ints.Add(arr[i]);
                    if (i == count - 1 && ints.Count == k)
                    {
                        int max = ints.Max();
                        int min = ints.Min();
                        res.Add(max - min);
                    }
                }
            }

            ints.Clear();

            if (count % k != 0)
            {
                for (int i = 1; i <= k; i++)
                {
                    ints.Add(arr[count - i]);
                }
                int max = ints.Max();
                int min = ints.Min();
                res.Add(max - min);
            }

            return 0;
        }

    }
}
