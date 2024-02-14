namespace TaskTow
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                Console.WriteLine("Enter String You Want Check");
                var s = Convert.ToString(Console.ReadLine());
                Console.WriteLine(CheckPalindrome(s) ? "Is Palindrome" : "Isn't Palindrome");
            }
        }

        public static bool CheckPalindrome(string palindrome)
        {
            int i = 0;
            int j = palindrome.Length - 1;
            while(i != j && i < j)
            {
                if (palindrome[i] != palindrome[j]) return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
