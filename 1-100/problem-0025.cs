using System.Numerics;

namespace proj_euler;

internal class P25
{
    public static void Run() 
    {
        BigInteger first = 0, second = 1;
        int index = 0;

        while (first.ToString().Length < 1000)
        {
            index++;

            BigInteger newTerm = first + second;
            first = second;
            second = newTerm;
        }

        Console.WriteLine(index);
    }
}
