using System;
using System.Linq;

namespace proj_euler
{
    internal class P4
    {
        public static void Run()
        {
            int largestPalindrome = Enumerable.Range(100, 900)
                .SelectMany(i => Enumerable.Range(100, 900).Select(j => i * j))
                .Where(IsPalindrome)
                .Max();

            Console.WriteLine(largestPalindrome);
        }

        private static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            return numberStr.SequenceEqual(numberStr.Reverse());
        }
    }
}
