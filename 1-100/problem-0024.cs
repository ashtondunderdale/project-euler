using System;

namespace proj_euler;

internal class P24
{
    public static void Run()
    {
        string str = "0123456789";

        string result = GetNthPermutation(str, 1000000);
        Console.WriteLine(result);
    }

    private static string GetNthPermutation(string str, int n)
    {
        char[] chars = str.ToCharArray();
        Array.Sort(chars);

        for (int count = 1; count < n; count++)
            GetNextPermutation(chars);

        return new string(chars);
    }

    private static bool GetNextPermutation(char[] chars)
    {
        int i = chars.Length - 2;

        while (i >= 0 && chars[i] >= chars[i + 1])
            i--;

        if (i < 0)
            return false;

        int j = chars.Length - 1;
        while (chars[j] <= chars[i])
            j--;

        (chars[j], chars[i]) = (chars[i], chars[j]);
        Array.Reverse(chars, i + 1, chars.Length - i - 1);

        return true;
    }
}
