using System;

namespace proj_euler;

internal class P4
{
    public static void Run()
    {
        int largestPalindrome = 0;

        for (int i = 100; i < 1000; i++)
        {
            for (int j = 100; j < 1000; j++)
            {
                int product = i * j;
                if (product > largestPalindrome && IsPalindrome(product))
                    largestPalindrome = product;     
            }
        }

        Console.WriteLine(largestPalindrome);
    }

    private static bool IsPalindrome(int number)
    {
        string numberStr = number.ToString();
        int length = numberStr.Length;

        for (int k = 0; k < length / 2; k++)
        {
            if (numberStr[k] != numberStr[length - k - 1])
                return false;       
        }

        return true;
    }
}
