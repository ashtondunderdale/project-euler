using System.Numerics;

namespace proj_euler;

internal class P36
{
    public static void Run()
    {
        int sum = 0;

        for (int i = 0; i < 1000000; i++)
        {
            if (IsPalindrome(i))
            {
                string binaryNum = Convert.ToString(i, 2);

                if (IsPalindrome(BigInteger.Parse(binaryNum)))
                    sum += i;
            }
        }

        Console.Write(sum);
    }

    private static bool IsPalindrome(BigInteger number)
    {
        string numberStr = number.ToString();
        return numberStr.SequenceEqual(numberStr.Reverse());
    }
}
